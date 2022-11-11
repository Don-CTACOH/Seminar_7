/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

void PrintArray(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            Console.Write($"{matrix[rows, columns]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            matrix[rows, columns] = new Random().Next(1, 10);
        }
    }
}
int[,] matrix0 = new int[3, 4];
FillArray(matrix0);
PrintArray(matrix0);
double sum = 0;
for (int j = 0; j < matrix0.GetLength(1); j++)
{
    for (int i = 0; i < matrix0.GetLength(0); i++)
    {
    sum = sum + matrix0[i, j];
    }
    Console.Write($"{sum / matrix0.GetLength(0)};");
}