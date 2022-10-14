/*

//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

double Exponentiation(double a, double b)
{
    double res = 0;
    res = Math.Pow(a,b);
    return res;
}

Console.WriteLine("Введите число, которое хотите возвести в степень: ");
double a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень, в котороую хотите возвести число: ");
double b = Convert.ToInt32(Console.ReadLine());

double exponentiation = Exponentiation(a,b);

Console.WriteLine($"Число {a} в степени {b} равно {exponentiation}");

*/

/*

//Задача 3: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumOfDigits(int a)
{
    int res = 0;
    if (a < 0) a *= -1;

    while (a > 0)
    {
        res += a % 10;
        a /= 10;
    }

    return res;
}

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int sum = SumOfDigits(a);

Console.WriteLine($"Сумма чисел {a} равна {sum}");

*/



//Задача 3: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

int[] CreateRandomArray(int size)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(1, 99);

    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.WriteLine("Input size array: ");
int size = Convert.ToInt32(Console.ReadLine());
// int min = 1;
// int max = 99;

int[] array = CreateRandomArray(size);
ShowArray(array);