//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ToThePowerOfB (int numberA, int numberB)
{
    int result = 1;

    for (int count = 0; count != numberB; count++)
        result = result*numberA;

    return result;
}

Console.WriteLine("Input a numberA: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a numberB: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Number {A} to the power of {B} is {ToThePowerOfB(A, B)}");