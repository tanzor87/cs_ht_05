// Задача 2: Задайте двумерный массив. Напишите
// программу, которая поменяет местами первую и
// последнюю строку массива.


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


int[] firstLine = new int[array2D.GetLength(1)];
int[] lastLine = new int[array2D.GetLength(1)];

for (int i = 0; i < array2D.GetLength(0); i++)
{
    for (int j = 0; j < array2D.GetLength(1); j++)
    {
        if (i == 0)
        {
            firstLine[j] = array2D[i, j];
        }
        else if (i == array2D.GetLength(0)-1)
        {
            lastLine[j] = array2D[i, j];
            array2D[i, j] = firstLine[j];
        }
    }
}
for (int i = 0; i < lastLine.Length; i++)
{
    array2D[0, i] = lastLine[i];
}

Console.WriteLine();
PrintArray2D(array2D);

// firstLine = array2D[0];
// for (int i = 0; i < firstLine.Length; i++); 
// {
//     Console.WriteLine(firstLine[i]);
// }
