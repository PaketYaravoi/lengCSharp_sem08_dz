/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/





void FillArray2D(int[,] array, int minValue, int maxValue)
{
    Random rnd = new Random();
    for(int i = 0; i < array.GetLength(0); i ++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minValue, maxValue +1);
        }
    }

}

int[,] GetArray2D(int rows, int columns, int minValue, int maxValue)
{
    int[,] array2d = new int[rows,columns];
    FillArray2D(array2d, minValue, maxValue);
    return array2d;
}

void PrintArray2D(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int GetMinIndex(int[,] array)
{
    int minSum = Int32.MaxValue;
    int index = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int rowSum = 0;
        for(int j =0; j < array.GetLength(1); j++)
        {
            rowSum += array[i,j];
        }
        if(minSum > rowSum)
        {
            index = i;
            minSum = rowSum;
        }
    }
    return index;
}

int rows = 1;
int columns = 1;
int minValue = 0;
int MaxValue = 10;

int[,] array2d = GetArray2D(rows, columns, minValue, MaxValue);
PrintArray2D(array2d);

int index = GetMinIndex(array2d);
Console.WriteLine($"номер строки с наименьшей сумой чисел = {index + 1}");
