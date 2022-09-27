// Задача 56:
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет
// находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
Console.WriteLine("");
Console.WriteLine("\t Задача 56");
int[,] array = GetArray(4, 6, 0, 9);
PrintArray(array);
int[,] sumArray = SumLine(array);
PrintArray(sumArray);
SeаrchMax(sumArray);
Console.WriteLine("");

void SeаrchMax(int[,] array)
{
    int minValue = array[0, 0];
    int min = 0;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        if (array[i, 0] < minValue)
        {
            minValue = array[i, 0];
            min = i+1;
        }
    }
    if (min == 0)
    {
        min = 1;
    }
    Console.WriteLine($"Наименьшая сумма элементов в строке № {min}");
}

int[,] SumLine(int[,] array)
{
    int[,] sumArray = new int[array.GetLength(0), 1];
    // int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumArray[i, 0] = sumArray[i, 0] + array[i, j];
        }
    }
    return sumArray;
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    Console.WriteLine("");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.SetCursorPosition(Console.CursorLeft - 4, Console.CursorTop);
        Console.WriteLine(" ]");
    }
    Console.WriteLine("");
}