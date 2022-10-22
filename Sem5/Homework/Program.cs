

//Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateRandomArray()
{
    int[] newArray = new int[10];

    for (int i = 0; i < newArray.Length; i++)
        newArray[i] = new Random().Next(100, 999);

    return newArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

void CountEvenNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) count++;
    Console.WriteLine($"Even numbers in array = {count}");
}

// int[] array = CreateRandomArray();
// PrintArray(array);
// CountEvenNum(array);



//Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void CountOddNum(int[] array)
{
    int count = 0;
    for (int i = 1; i < array.Length; i += 2)
        count += array[i];
    Console.WriteLine($"Sun odd numbers in array = {count}");
}

// int[] array = CreateRandomArray();
// PrintArray(array);
// CountOddNum(array);



//Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double DifMinMax(double[] arr) 
{
    double min = arr[0];
    double max = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        else if (arr[i] < min) min = arr[i];
    }
    return max - min;
}

double[] CreateRandomDifArray()
{
    double[] array = new double[10];
        for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble();
    }
    return array;
}

void PrintDifArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
double[] arrayDif = CreateRandomDifArray();
PrintDifArray(arrayDif);
double res = DifMinMax(arrayDif);
Console.WriteLine($"Difference min max = {res}");