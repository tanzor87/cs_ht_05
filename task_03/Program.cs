// Задача 3: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с
// наименьшей суммой элементов.

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

int MinSumLine(int[,] array)
{
    int minSumLine = 0;
    int sumLine = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (i == 0)
        {
            sumLine = sum;
        }
        else
        {
            if (sumLine > sum)
            {
                sumLine = sum;
                minSumLine = i;
            }
        }

    }
    return minSumLine;
}

Console.WriteLine($"Номер строки с наименьшей суммой элементов = {MinSumLine(array2D)}");
