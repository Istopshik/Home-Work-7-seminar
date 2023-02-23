// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет
Console.Clear();
System.Console.Write("Введите позицию строки: ");
int lines = SetNumber("lines");
System.Console.Write("Введите позицию столбца: ");
int columns = SetNumber("columns");
int[,] matrix = new int[10, 10];
FillArrayRandomNumbers(matrix);
PrintArray(matrix);
Print(matrix);

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    
}

void Print(int[,] matrix)
{
    if (lines > matrix.GetLength(0) || columns > matrix.GetLength(1))
    {
        System.Console.WriteLine("Такого элемента нет в массиве!");
    }
    else System.Console.WriteLine($"Элемент на строке {lines} и столбце {columns} равен {matrix[lines - 1, columns - 1]}");
}
void FillArrayRandomNumbers(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-100, 100);
        }
    }
}
int SetNumber(string numberName)
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}