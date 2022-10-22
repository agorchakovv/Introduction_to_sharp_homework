//Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int AmountPositiveNums(int amount)
{
    int count = 0;
    for (int i = 0; i < amount; i++)
    {
        Console.WriteLine("Input number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0) count++;
    }
    return count;
}

// Console.Write("Input amount numbers: ");
// int amount = Convert.ToInt32(Console.ReadLine());
// int result = AmountPositiveNums(amount);
// Console.WriteLine($"Amount positive numbers = {result}");



//Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

double[] IntersectionLines(double b1, double k1, double b2, double k2)
{
    double[] array = new double[2];
    array[0] = (b2-b1)/(k1-k2);
    array[1] = k1 * array[0] + b1;
    return array;
}
void PrintIntersection(double[] array)
{
    Console.Write($"Точка пересечения = [{array[0]}; {array[1]}].");
}

Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
if(k1 == k2) Console.WriteLine("Прямые параллельны, точки пересечения нет.");
else
{
    double[] result = IntersectionLines(b1,k1,b2,k2);
    PrintIntersection(result);
}
