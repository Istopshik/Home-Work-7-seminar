// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4


Console.Clear();
System.Console.Write("Введите количество строк: ");
int lines = SetNumber("lines");
System.Console.Write("Введите количество столбцов: ");
int columns = SetNumber("columns");
System.Console.Write("Введите максимальное число: ");
int maxNumbers = SetNumber("max");
System.Console.Write("Введите минимальное число: ");
int minNumbers = SetNumber("min");
var matrix = GetMatrix(lines, columns, maxNumbers, minNumbers);
PrintArray(matrix);
System.Console.WriteLine("Мы получили среднее арифметическое от нашего массива: ");
ArithmeticMean(matrix);

int SetNumber(string numberName)
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int[,] GetMatrix(int lines, int columns, int maxNumbers, int minNumbers)
{
    int[,] matrix = new int[lines, columns];
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = Convert.ToInt32(new Random().Next(minNumbers, maxNumbers));
        }
    }
    return matrix;
}
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
void ArithmeticMean(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double average = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            average += matrix[i, j];
        }
        average /= lines; 
        
        Console.Write(average + "; ");
    }
}



