// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
/*
int PosNum (int M)
{
    int count = 0;
    for (int i = 0; i < M; i++)
    {
        Console.WriteLine ("Input a number: ");
        int a = Convert.ToInt32(Console.ReadLine()); 
            if (a > 0) 
            count++;
        
    }
    return count;
}

Console.WriteLine ("How many numbers do you want to enter: ");
int numbers = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine(PosNum(numbers));
*/

  
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*
// Решение 1
double CrossPointX (double b1, double k1, double b2, double k2)
{
    double x = 0;
    x = (b2-b1)/(k1-k2);
    return x;
}
double CrossPointY (double b1, double k1, double b2, double k2)
{
    double y = 0;
    y = (k1*(b2-b1)/(k1-k2)) + b1;
    return y;
}
Console.WriteLine ("Input numB1: ");
int numB1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine ("Input numK1: ");
int numK1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine ("Input numB2: ");
int numB2 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine ("Input numK2: ");
int numK2 = Convert.ToInt32(Console.ReadLine()); 

double x = (CrossPointX(numB1, numK1, numB2, numK2));
double y = (CrossPointY(numB1, numK1, numB2, numK2));
Console.WriteLine($"{x}, {y}");
*/

// Решение 2
double CrossPoint (double b1, double k1, double b2, double k2)
{
    double x = 0;
    double y = 0;
    double res = Console.WriteLine($"{x}, {y}");
    x = (b2-b1)/(k1-k2);
    y = (k1*(b2-b1)/(k1-k2)) + b1;
    return res;
}

Console.WriteLine ("Input numB1: ");
int numB1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine ("Input numK1: ");
int numK1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine ("Input numB2: ");
int numB2 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine ("Input numK2: ");
int numK2 = Convert.ToInt32(Console.ReadLine()); 

double result = (CrossPoint(numB1, numK1, numB2, numK2));
Console.WriteLine(result);