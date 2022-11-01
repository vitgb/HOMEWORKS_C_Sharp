// ДЗ1
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
/*
Console.WriteLine("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input b nubmber: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;
if (a>max) max=a;
if (b>max) max=b;

Console.Write($"max = {max}");
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Input a first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;
if (number1>max)
{
    max = number1;
}
if (number2>max)
{
    max = number2;
}
if (number3>max)
{
    max = number3;
}
Console.WriteLine(max);
