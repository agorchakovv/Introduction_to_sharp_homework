//Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreatRandomDouble2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            double integerPart = new Random().Next(minValue, maxValue); 
            double fractionalPart = new Random().NextDouble();
            array[i, j] = Math.Round(integerPart + fractionalPart, 2);
        }
    }
    return array;
}

void ShowDouble2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "|");

        Console.WriteLine();
    }
}

double[,] array = CreatRandomDouble2dArray();
ShowDouble2dArray(array);


//Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreatRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

void FindElement(int[,] array)
{
    Console.Write("Input an index 'i' of element: ");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input an index 'j' of element: ");
    int j = Convert.ToInt32(Console.ReadLine());
    if ((i >= 0 && i < array.GetLength(0)) && (j >= 0 && j < array.GetLength(1)))
        Console.WriteLine($"Element with indexes [{i},{j}] = {array[i, j]}");
    else
        Console.WriteLine("There is no element with such index.");
}

// int[,] array = CreatRandom2dArray();
// Show2dArray(array);
// FindElement(array);


//Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[] AverageElementInColumn(int[,] array)
{
    int[] avarageArray = new int[array.GetLength(1)];

    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            avarageArray[i] += array[j,i];
        }
    }
    return avarageArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

// int[,] array = CreatRandom2dArray();
// Show2dArray(array);
// int[] avarageArray = AverageElementInColumn(array);
// ShowArray(avarageArray);