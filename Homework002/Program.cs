// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
/*
int TenthOfNumber (int num)
{
    num = (num / 10) % 10;
    return num;
}
Console.WriteLine("Input a three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number/100 > 1 && number/100 < 10)
{
    int result = TenthOfNumber(number);
    Console.WriteLine($"The Tenth part of a number {number} is {result}");
}
else
{
    Console.WriteLine("WRONG NUMBER");
}
*/    


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
/*
int ThirdDigitOfNum (int number)
{
    int count = 0;
    while (number >= 1000)
    {
        number = number / 10;
        count++;
    }
        if(number < 100)
        {
            Console.WriteLine("Третьей цифры нет");
        }  
    return number % 10;
}

Console.WriteLine("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = ThirdDigitOfNum(number);
Console.WriteLine(result);
*/



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
/*
bool DigitDayOff (int num)
{
    if(num == 6 || num == 7)
    {
        return true;
    }
    else
    {
        return false;
    }
}
Console.WriteLine("Input a number day of the week: ");
int number = Convert.ToInt32(Console.ReadLine());
bool result = DigitDayOff(number);
Console.WriteLine($"Number {number} of the week is {result}");
*/
