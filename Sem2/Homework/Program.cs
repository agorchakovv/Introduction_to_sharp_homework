/*
//Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int ShowSecondNum(int num)
{
    int result;
    result =  num%100/10;
    return result;
}

Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());
int secondDigit = ShowSecondNum(num);
Console.WriteLine($"Second digit of {num} is {secondDigit}");

*/

/*
//Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int ShowThirdDigit(int num)
{
    int result = 0;
    if (num <= 99)
        Console.WriteLine($"No third digit.");
    else
    {
        while (num > 999)
            num = num / 10;
        result = num % 10;
    }
    
    return result;
}
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int thirdDigit = ShowThirdDigit(num);
Console.WriteLine($"Third digit of {num} is {thirdDigit}.");

*/

/*
//Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Input day ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 6 ^ num ==7)
{
    Console.WriteLine($"Today {num} is holiday!");
}
else if ((num >= 1) & (num <= 5))
{
    Console.WriteLine($"Today {num} is working day!");
}
else if (num > 7)
{
    Console.WriteLine($"{num} it's not a day of the week");
}

*/

//