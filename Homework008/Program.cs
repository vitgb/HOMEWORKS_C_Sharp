// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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

void SelectionSort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = j+1; k < array.GetLength(1); k++)
                {
                    int MaxPosition = array [i,j];
                    if(array[i,k] > array[i,j]) 
                    {
                        MaxPosition = array[i,k];
                        array[i,k] = array[i,j];
                        array[i,j] = MaxPosition;
                    }
                }
                
            } 
}
Console.WriteLine ("");
SelectionSort(myArray);
Show2dArray(myArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
int SummOfElements (int [,] array)   
{
    int Rownum = 0, MinSumm = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int Summ = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            Summ += array[i,j];
        if (i == 0) MinSumm = Summ;
        else if (Summ < MinSumm)
        {
            MinSumm = Summ;
            Rownum = i+1;
        }
    }
    return Rownum;    
}       

Console.WriteLine ("");
SummOfElements (myArray);
Console.WriteLine ($"Row number with the smallest sum of elements: " + SummOfElements (myArray));
 */

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
/*
int [,] CreateArray1(int M, int N, int minValue, int maxValue)
{
    int[,] array1 = new int [M, N];

    for (int i = 0; i < M; i++)
        for (int j = 0; j < N; j++)
            array1[i,j] = new Random().Next(minValue, maxValue +1);
           
    return array1;
}

int [,] CreateArray2(int N, int K, int minValue, int maxValue)
{
    int[,] array2 = new int [N, K];

    for (int i = 0; i < N; i++)
        for (int j = 0; j < K; j++)
            array2[i,j] = new Random().Next(minValue, maxValue +1); 
    return array2;
}

void ShowArray1(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
            Console.Write(array1[i,j] + " ");

        Console.WriteLine();
    }
}    
void ShowArray2(int[,] array2)
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
            Console.Write(array2[i,j] + " ");

        Console.WriteLine();
    }
}

void MatrixProduct(int[,] array1, int[,] array2)
{
    int[,] ResultArray = new int [array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {              
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            for (int s = 0; s < array2.GetLength(0); s++)
                ResultArray[i,j] += (array1[i,s]*array2[s,j]);
            Console.Write(ResultArray[i,j] + " ");
        }

        Console.WriteLine();
    }
   

}

Console.WriteLine ("Input a number of array1 rows (M): ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input a number of array1 columns & array2 rows (N): ");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input a number of array2 columns (K): ");
int numK = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input a min possible value for both matrix: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input a max possible value for both matrix: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray1 = CreateArray1(numM, numN, min, max);
int[,] myArray2 = CreateArray2(numN, numK, min, max);
ShowArray1(myArray1); 
Console.WriteLine ("");
ShowArray2(myArray2);
Console.WriteLine ("Product of two matrices:");
MatrixProduct(myArray1, myArray2);
*/


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно 
//выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

/*
int [,,] Create3dArray(int rows, int columns, int layers)// Заполнение массива рандомно неповторяющимися числами от 10 до 99
{
    int[,,] array = new int [rows, columns, layers];
    int [] New1dArray = new int[array.GetLength(0)*array.GetLength(1)*array.GetLength(2)];
    int number=0;

    if (array.GetLength(0)*array.GetLength(1)*array.GetLength(2) <= 180)
    {  
        for (int i = 0; i < New1dArray.Length; i++)
        {
            New1dArray[i] = new Random().Next(-99,100);
            while (New1dArray[i]*New1dArray[i] < 100)//исключаем числа от -9 до 9
                    {
                        New1dArray[i] = new Random().Next(-99,100);
                        i = 0;
                        number = New1dArray[i];
                    }
            if (i >= 1)
            {
                for (int j = 0; j < i; j++)
                {
                    while (New1dArray[i] == New1dArray[j] && New1dArray[i]*New1dArray[i] < 100)
                    {
                        New1dArray[i] = new Random().Next(-99,100);
                        j = 0;
                        number = New1dArray[i];
                    }
                    number = New1dArray[i];
                }
            }
        }
        
        int count = 0;
        for (int x = 0; x < rows; x++)
            for (int y = 0; y < columns; y++)
                for (int z = 0; z < layers; z++)
                {
                    array[x,y,z] = New1dArray[count];
                    count++;
                }
    
    }
    return array;

}

void Show3dArray(int[,,] array)// вывод массива
{
    for (int i = 0; i < array.GetLength(0); i++)      
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
    
        }
       
}


Console.WriteLine ("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input a number of layers: ");
int l = Convert.ToInt32(Console.ReadLine());


int[,,] myArray = Create3dArray(m, n, l);
Show3dArray(myArray);
*/

// // Console.WriteLine("");
// // int[] My1dArray = DifferentNumbers(myArray);
// // Show1dArray(My1dArray);


// // Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// // Например, на выходе получается вот такой массив:
// // 01 02 03 04
// // 12 13 14 05
// // 11 16 15 06
// // 10 09 08 07
// // for (int i = 0; i < rows; i++)
// //         for (int j = 0; j < columns; j++)
// //             array[i,j] = new Random().Next(minValue, maxValue +1);
// //             for( int j = columns-1; j < rows; j-=2)

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

void TransferArray(int[,] array)
{
    int[] New1dArray = new int[array.GetLength(1)*array.GetLength(0)];
    
    int a = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            New1dArray [a] = array[i,j];
            Console.Write($"{New1dArray [a]} ");
            a++;
        }

    Console.WriteLine("");
    
    int x = 0;
    int y = 0;
    int[,] Spiral2dArray = new int [x,y];
    int x1=0;
    int y1=0;

    int count = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        array[x,y] = New1dArray [i];
        Console.Write($"{New1dArray [i]} ");
        x++;
        count++;
    }
    x1 = x;

    for (int j = 0; j < array.GetLength(0)-1; j++)
    {
        array[x1,y-1] = New1dArray [count];
        Console.WriteLine($"{New1dArray [count]} ");
        y--;
        count++;
    }
    y1 = y;

    for (int k = 0; k < array.GetLength(1); k++)
    {
        array[x1, y1] = New1dArray[count];
        Console.Write($"{New1dArray [count]} ");
        x1--;
        count++;
    }
    x1 = 0;

    for (int m = 0; m < array.GetLength(0); m++)
    {
        array[x1, y1] = New1dArray[count];
        Console.WriteLine($"{New1dArray [count]} ");
        x1--;
        count++;
    }
    x1 = 0;
      
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
Console.WriteLine("");
TransferArray(myArray);
*/


           






