/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

int[,] matrix = { {1, 4, 7, 2},
                  {5, 9, 2, 3},
                  {8, 4, 2, 4} };
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.Write("Введите значение строки: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите значение столбца: ");
int column = int.Parse(Console.ReadLine());
if (row > 0 && row < 4 && column > 0 && column < 5)
{
    Console.Write($"На указанной позиции находится число {matrix[row - 1, column - 1]}");
}
else Console.Write("Такого элемента нет");
