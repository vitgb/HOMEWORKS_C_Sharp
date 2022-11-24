﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*
double [,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] array = new double [rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue +1) + Math.Round(new Random().NextDouble(), 2);
    
    return array;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

Console.WriteLine ("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
*/
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или 
//же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> числа с такими индексами в массиве нет
/*
int [,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int [rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue +1);
    
    return array;
}

void Show2dArray(int[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

void FindArrayValue(int[,] array, int i, int j)
{
    //int FindNumber = array[i,j];
    if(i < array.GetLength(0) && i >= 0 && j < array.GetLength(1) && j >= 0)
         Console.WriteLine (array[i,j]);
    else 
        Console.WriteLine("There are no numbers with such indices in the array!!!");
   
}


Console.WriteLine ("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
Console.WriteLine ("Enter the value of the given rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Enter the value of the given columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

FindArrayValue(myArray, rows, columns);
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int [rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue +1);
    
    return array;
}

void Show2dArray(int[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

double[] AverageOfColumns(int[,] array)
{
    double sum = 0;
    double[] New1dArray = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum +array[i,j];
        }
        double mid = sum/array.GetLength(0);
        New1dArray[j] = mid;
    }
    return New1dArray;
       
}

void Show1dArray (double[] New1dArray)
{
    for(int i = 0; i < New1dArray.Length; i++)
        Console.Write(New1dArray[i] + " ");

    Console.WriteLine();
}

Console.WriteLine ("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
Console.WriteLine();
double[] my1dArray = AverageOfColumns(myArray);
Show1dArray(my1dArray);