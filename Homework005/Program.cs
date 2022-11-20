// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray (int[] array)

{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int EvenNumber (int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            count++;

    return count;
}

Console.WriteLine ("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
Console.WriteLine(EvenNumber(myArray));
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void ShowArray (int[] array)

{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int SumOddNumber (int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i=i+2)
        sum += array[i];
    return sum;
}

Console.WriteLine ("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);

int Sum = SumOddNumber(myArray);
Console.WriteLine (Sum);
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
/*
double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1) +  Math.Round(new Random().NextDouble(), 2);
            
    return array;
}

void ShowArray (double[] array)

{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

double Diff (double[] array)
{
    double max = array[0];
    for(int i = 0; i < array.Length; i++)
        if (array[i] > max) max = array[i];
    double min = array[0];
    for(int i = 0; i < array.Length; i++)
        if (array[i] < min) min = array[i];
    double dif = max - min; 
    
    return Math.Round(dif, 2);
}

Console.WriteLine ("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
double MaxMinusMin = Diff(myArray);
Console.WriteLine(Diff(myArray));
*/