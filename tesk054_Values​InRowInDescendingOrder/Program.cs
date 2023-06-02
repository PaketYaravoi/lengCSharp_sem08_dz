        /*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2  
*/


int[,] SortArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int[] copyRow = new int[array.GetLength(1)]; // при переходе на новую строку создаем одномерный массив который будет ее зеркалить 
        for(int j = 0; j < array.GetLength(1); j++)
        {
            copyRow[j] = array[i,j]; //  зеркалим строку из матрицы в одномерный (только что созданный ↑ массив)
        }
        copyRow = Bubble_Sort(copyRow);   // сортируем строку методом пузырька
        
        for(int j = 0; j < copyRow.Length; j++) // копируем обратно из одномерного в матрицу уже отсортированную строку
        {
            array[i, j] = copyRow[j];
        } 
    }
    return array;
}

int[] Bubble_Sort(int[] array)  5 1 4 3 // 1 4 3 5 8 12 54   
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - 1 - i; j++)   // ? почему именно такая записть
        {
            if (array[j] < array[j + 1]) // сортировка большее на меньшее
            {
                int temp = array[j];
                array[j] = array[j+1];
                array[j+1] = temp;
            }
        }
    }
    return array;
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


int rows = 10;
int columns = 5;
int minValue = 1;
int maxValue = 100;

int[,] randomMass2D = GetArray2D(rows, columns, minValue, maxValue);
PrintArray2D(randomMass2D);

int[,] sortedMatrix = SortArray(randomMass2D);
PrintArray2D(sortedMatrix);