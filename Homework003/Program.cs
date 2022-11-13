// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
/*
bool Palindrome (int num)
{
    if (num/10000 == num %10 && (num/1000) % 10 == (num % 100)/10)
    return true;
    else
    return false;
    
}
Console.WriteLine("Input 5 digit number: ");
int Number = Convert.ToInt32(Console.ReadLine());

bool res = Palindrome(Number);
Console.WriteLine(res);
*/


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// Задача 23
/*
double Segment3dLenght (double sizeX1, double sizeY1, double sizeZ1, double sizeX2, double sizeY2, double sizeZ2)
{
    Double distanceAB3d= 0;
    double AC = 0;
    AC = sizeX2 - sizeX1;
    double BC = 0;
    BC = sizeY2 - sizeY1;
    double DC = 0;
    DC = sizeZ2 - sizeZ1;

    distanceAB3d = Math.Sqrt(Math.Pow(AC, 2) + Math.Pow(BC, 2) + Math.Pow(DC, 2));

    return Math.Round(distanceAB3d, 2);
}
 
Console.Write("Input X1 point A: ");
double X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y1 point A: ");
double Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Z1 point A: ");
double Z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input X2 point B: ");
double X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y2 point B: ");
double Y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Z2 point B: ");
double Z2= Convert.ToInt32(Console.ReadLine());


double res = Segment3dLenght(X1, Y1, Z1, X2, Y2, Z2);
Console.WriteLine($"Segmet Lenght is {res}");
*/


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void CubesOfNumbers (double numN)
{
    int count = 1;
    if(count<=numN) Console.Write($"{count} ");
    while (count <= numN)
    {
        Console.Write($"{count*count*count} ");
        count++;
    }
}

Console.WriteLine("Input a number N: ");
double N = Convert.ToInt32(Console.ReadLine());

Console.Write($"Table Cubes Of Numbers from 1 to {N} looks like ");
CubesOfNumbers(N);
