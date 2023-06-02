/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
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


int[,] array2d = GetArray2D(rows:4, columns:4, minValue:0, maxValue:10);
PrintArray2D(array2d);