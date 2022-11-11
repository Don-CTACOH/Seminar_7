/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

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
Console.Write($"Введите число: ");
int element = Convert.ToInt32(Console.ReadLine());
string chislo = "Числа нет в массиве!";
for (int i = 0; i < matrix0.GetLength(0); i++)
{
    for (int j = 0; j < matrix0.GetLength(1); j++)
    {
        if (matrix0[i, j] == element) chislo = "Число есть в массиве!";
    }
}
Console.WriteLine(chislo);
