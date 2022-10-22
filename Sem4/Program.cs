//Задача. Заполнить массив единицами и нулями в случайном порядке и вывести на экран

// Заполнить массив рандомными элементами

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

//Распечатать массив

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.WriteLine("Input size array: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = 0;
int max = 1;

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);