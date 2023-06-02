/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] GetMatrixMultiply(int[,] matrix1, int[,] matrix2)
{
    int[,] resoltMatrix = new int[2,2];
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for(int k = 0; k < 2; k++)
            {
                resoltMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return resoltMatrix;
}



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



int rows = 1;
int columns = 1;
int minValue = 0;
int MaxValue = 10;

int[,] matrix1 = new int [2,2]{{2,4},{3,2}};
int[,] matrix2 = new int [2,2]{{3,4}, {3,3}};            //GetArray2D(rows, columns, minValue, MaxValue);
                                          //GetArray2D(rows, columns, minValue, MaxValue);
PrintArray2D(matrix1);
PrintArray2D(matrix2);

int[,] matrixMultiply = GetMatrixMultiply(matrix1, matrix2);
PrintArray2D(matrixMultiply);
