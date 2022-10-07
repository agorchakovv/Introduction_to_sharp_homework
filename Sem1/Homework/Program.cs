/*
//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Input first number");
int numa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number");
int numb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (numa > numb)
{
    Console.WriteLine($"{numa} more {numb}");
}
else if (numb > numa)
{
    Console.WriteLine($"{numb} more {numa}");
}
else
{
    Console.WriteLine($"{numa} and {numb} are equal.");
}

*/

/*
//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Input first number");
int numa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input first number");
int numb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input first number");
int numc = Convert.ToInt32(Console.ReadLine());

int Max(int a, int b, int c)
{
    int max = a;
    if(b > max) max = b;
    if(c > max) max = c;
    return max;
}

int max = Max(numa, numb, numc);
Console.WriteLine("Maximum number " + max);

*/

/*
//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());

if (num %2 == 0)
{
    Console.WriteLine($"{num} является четным числом");
}
else
{
    Console.WriteLine($"{num} является не четным числом");
}

*/

/*
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
{
    int current = 2;
    while (current <= num)
    {
        Console.Write(current + " ");
        current += 2;
    }
}
else if (num <= 0)
{
    int current = -2;
    while (current >= num)
    {
        Console.Write(current + " ");
        current -= 2;
    }
}

*/