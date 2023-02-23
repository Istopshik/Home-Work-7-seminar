// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
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


double[,] GetMatrix(int lines, int columns, int maxNumbers, int minNumbers)
{
    double[,] matrix = new double[lines, columns];
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = Convert.ToDouble(new Random().Next(minNumbers, maxNumbers)) / 10;
        }
    }
    return matrix;
}
int SetNumber(string numberName)
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
void PrintArray(double[,] matrix)
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
