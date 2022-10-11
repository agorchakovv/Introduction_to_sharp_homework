
//Задача 1 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*

int ReverseNumber(int num)
{
    int result = 0;
    while (num > 0)
    {
        result *= 10;
        result = result + num % 10;
        num /= 10;
    }
    return result;
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int reverseNum = ReverseNumber(num);

Console.WriteLine(reverseNum);

if(num == reverseNum)
{
    Console.WriteLine($"Число {num} - палиндром.");
}
else
{
    Console.WriteLine($"Число {num} не является палиндромом.");
}

*/

// Задача 2 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*

double FindDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    return distance;
}
Console.Write("Введите кординату x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кординату y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кординату z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кординату x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кординату y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кординату z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());
double distance = FindDistance(x1,y1,z1,x2,y2,z2);
double Distance = Math.Round(distance,2);
Console.WriteLine($"Растояние между точкой А({x1},{y1},{z1}) и точкой B({x2},{y2},{z2}) = {Distance}");

*/

//Задача 3 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void QuartsOfNumbersA(int n)
{
    int count = 1;
    while (count <= n)
    {
        Console.Write($"{Math.Pow(count, 3)} | ");
        count++;
    }
}

Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());
QuartsOfNumbersA(n);