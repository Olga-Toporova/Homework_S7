/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

Console.Write("Введите количество строк (m): ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов (n): ");
int column = int.Parse(Console.ReadLine());
double[,] matrix = new double[row, column];
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        matrix[i, j] = new Random().Next(-10, 10);
        Console.Write($"{matrix[i, j]}, ");
    }
    Console.WriteLine();
}

