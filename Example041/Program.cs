/*
Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы
на их квадраты. Например, изначально массив выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
*/

Console.WriteLine("Print m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Print n: ");
int n = int.Parse(Console.ReadLine());
Random yuy = new Random();
int[,] matrix = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = yuy.Next(1, 10);
        if (i%2 == 0 && j%2 ==0)
        {
            matrix[i, j] = matrix[i, j]*matrix[i,j];
        }
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}