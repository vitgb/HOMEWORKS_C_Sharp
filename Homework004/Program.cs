//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
/*
int ToThePowerOfB (int numberA, int numberB)
{
    int result = 1;

    for (int count = 0; count < numberB; count++)
        result = result*numberA;

    return result;
}

Console.WriteLine("Input a numberA: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a numberB: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Number {A} to the power of {B} is {ToThePowerOfB(A, B)}");
*/


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
/*
int FindSumDigit (int number)
{
    int digitsum = 0;
    
    while (number != 0)
    {
        digitsum = digitsum + number % 10;
        number = number / 10;
    }
    return digitsum;
    
}

Console.WriteLine("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Digit sum of number {a} is {FindSumDigit(a)} ");
*/


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// void PrintArray(int[n] array);
// {
//     int n = 8;
//     int[n] array = new int [n];
// }
// PrintArray

void FillArray (int[] SomeNumbers)
{
    int lenght = SomeNumbers.Length;
    int index = 0;
    while (index < lenght)
    {
        SomeNumbers[index] = new Random().Next (1, 100); 
        Console.Write(SomeNumbers[index] + " ");
        index++;
        
    }
}

int[] array = new int[8];
Console.Write("Array of 8 numbers looks like: ");
FillArray(array);
