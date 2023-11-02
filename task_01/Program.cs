// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

int ReadNumber(string message = "ampty")
{
    if (message != "ampty")
    {
        Console.WriteLine(message);
    }
    int num = Convert.ToInt32(Console.ReadLine());
    return num;

}

int[,] array2D = GenerateArray2D(4, 4);
PrintArray2D(array2D);

int numLine = ReadNumber("Ведите номер строки: ");
int numCol = ReadNumber("Введите номер колонки: ");

if (numLine >= array2D.GetLength(0) || numCol >= array2D.GetLength(1))
{
    Console.WriteLine("Такого элемента нет!");
}
else{
    Console.WriteLine($"{array2D[numLine, numCol]} - элемент который вы ищите");
}







