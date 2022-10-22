//Задача. Задать массив из 12 элементов, заполнить случайными числами от -9 до 9, найти сумму отриицательных элементов массива.

// Заполнение массивва вводом пользователя
int[] CreateArray(int size)
{
    int[] array = new int[size];
    Console.WriteLine("Creating array");
    for (int i = 0; i < size; i++)
    {
        Console.Write($"input a {i + 1} element of array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Complete!");
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int SumNegativeNum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
            sum += array[i];
    }
    return sum;
}

Console.WriteLine("input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size);
int result = SumNegativeNum(myArray);

ShowArray(myArray);
Console.WriteLine("Sum of a negative elements is " + result);