// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
// строки двумерного массива.

int[,] Create2dArray()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(1, 9);
    return array;
}
void Print2Array(int[,] array)
{
    Console.WriteLine("Созданный массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}
int[,] ChangeOrderElementsRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, j])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, j];
                    array[i, j] = temp;
                }
            }
        }
    }
    return array;
}

// int[,] newArray = Create2dArray();
// Print2Array(newArray);
// Console.WriteLine();
// int[,] changeArray = ChangeOrderElementsRows(newArray);
// Print2Array(changeArray);



// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.

int[,] Create2dRecArray()
{
    int rows = 5;
    int columns = 10;
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(1, 9);
    return array;
}
int[] SumElementsRows(int[,] array)
{
    int[] sumArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
            sumArray[i] = sum;
        }
    }
    return sumArray;
}
void PrintSumArray(int[] array)
{
    Console.Write("Сумма элементов в строке: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
            Console.Write(", ");
    }
    Console.WriteLine();
}
int IndexMinElements(int[] array)
{
    int iMin = 0;
    int min = array[iMin];
    for (int i = 1; i < array.Length - 1; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            iMin = i;
        }
    }
    return iMin;
}

// int[,] newArray = Create2dRecArray();
// Print2Array(newArray);
// Console.WriteLine();
// int[] sumArray = SumElementsRows(newArray);
// PrintSumArray(sumArray);
// int numberRow = (IndexMinElements(sumArray) + 1);
// Console.WriteLine($"Номер строки с наименьшей суммой элементов - {numberRow}.");



// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] MatrixMultiplication(int[,] array1, int[,] array2)
{
    var newArray = new int[array1.GetLength(0), array2.GetLength(1)];
    if (array1.GetLength(0) != array2.GetLength(1))
    {
        Console.WriteLine("Произведение матриц невозможно.");
        Console.WriteLine("Количество строк первой матрицы должно быть равно количеству столбцов второй.");
        return null;
    }
    else
    {
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                newArray[i, j] = 0;
                for (int k = 0; k < array2.GetLength(0); k++)
                {
                    newArray[i, j] += array1[i, k] * array2[k, j];
                }
            }
        }
        return newArray;
    }
}

// int[,] array1 = Create2dArray();
// Print2Array(array1);
// int[,] array2 = Create2dArray();
// Print2Array(array2);
// int[,] resultArray = MatrixMultiplication(array1,array2);
// Console.ForegroundColor = ConsoleColor.Green;
// if(resultArray != null) Print2Array(resultArray);

//  Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] FillSquareArraySpiral()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,] arraySpiral = new int[rows, columns];
    for (int passage = 0, valueElements = 1; valueElements <= rows * columns; passage++)
    {
        for (int i = passage, j = passage; j < columns - passage; j++)
        {
            arraySpiral[i, j] = valueElements;
            valueElements++;
        }
        if(valueElements > rows * columns) break;
        for (int i = passage + 1, j = columns - passage - 1; i < rows - passage; i++)
        {
            arraySpiral[i, j] = valueElements;
            valueElements++;
        }
        if(valueElements > rows * columns) break;
        for (int i = rows - passage - 1, j = columns - passage - 2; j >= passage; j--)
        {
            arraySpiral[i, j] = valueElements;
            valueElements++;
        }
        if(valueElements > rows * columns) break;
        for (int i = rows - passage - 2, j = passage; i > passage; i--)
        {
            arraySpiral[i, j] = valueElements;
            valueElements++;
        }
    }
    return arraySpiral;
}
void PrintArraySpiral(int[,] array, int fillZeros = 2)
{
    Console.WriteLine("Массив, заполненный спирально: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j].ToString($"D{fillZeros}") + " "); 
        Console.WriteLine();
    }
}

int[,] arraySpiral = FillSquareArraySpiral();
PrintArraySpiral(arraySpiral);
