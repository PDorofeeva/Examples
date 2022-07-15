/*
Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
(с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/

Console.WriteLine("Print m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Print n: ");
int n = int.Parse(Console.ReadLine());
int count = 0;
Random yuy = new Random();
int[,] matrix = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = yuy.Next(1, 10);
        if (i == j)
        {
            count = count + matrix[i, j];
        }
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine($"Сумма: {count}");