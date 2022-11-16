// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке 
// от N до 1. Выполнить с помощью рекурсии.

void PrintDigits(int n)
{
    Console.Write(n + " ");
    if (n > 1) PrintDigits(n - 1);
}

// int n = 10;
// Console.Write($"N = {n} -> ");
// PrintDigits(n);



// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в 
// промежутке от M до N.

int SumElements(int FirstNum, int LastNum)
{
    if (FirstNum > LastNum) return FirstNum + SumElements(FirstNum - 1, LastNum);
    if (FirstNum < LastNum) return FirstNum + SumElements(FirstNum + 1, LastNum);
    else return FirstNum;
}

// Console.Write("Введите число m: ");
// int FirstNum = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число n: ");
// int LastNum = Convert.ToInt32(Console.ReadLine());

// int result = SumElements(FirstNum, LastNum);
// Console.WriteLine("Сумма натуральных элементов в промежутке от m до n: " + result);



// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два 
// неотрицательных числа m и n.

int Akk(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Akk(m - 1, 1);
    if (m > 0 && n > 0) return Akk(m - 1, Akk(m,n - 1));
    return Akk(m,n); 
}                  

Console.Write("Введите число m больше 0: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число n больше 0: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"m = {m}, n = {n} -> Akkerman(m,n) = {Akk(m,n)}");    