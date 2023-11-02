// Задача 4*(не обязательная): Задайте двумерный массив
// из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен
// наименьший элемент массива. Под удалением
// понимается создание нового двумерного массива без
// строки и столбца

int[,] GenerateArray2D(int LenLine, int LenColumns)
{
    int[,] array = new int[LenLine, LenColumns];
    for (int i = 0; i < LenLine; i++)
    {
        for (int j = 0; j < LenColumns; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] array2D = GenerateArray2D(4, 4);
PrintArray2D(array2D);

int minLine = 0;
int minCol = 0;
int element = array2D[0, 0];

for (int i = 0; i < array2D.GetLength(0); i++)
{
    for (int j = 0; j < array2D.GetLength(1); j++)
    {
        if (element > array2D[i, j])
        {
            element = array2D[i, j];
            minLine = i;
            minCol = j;
        }
    }
}
Console.WriteLine($"позиция минимального элемента ({minLine}, {minCol})");

int[,] array2D2 = new int[array2D.GetLength(0) - 1, array2D.GetLength(1) - 1];
    for (int i = 0; i < array2D2.GetLength(0); i++)
    {
        for (int j = 0; j < array2D2.GetLength(0); j++)
        {   
            if 
            array[i, j] = new Random().Next(1, 10);
        }
    }
