/*
ВОПРОС К УЧИТЕЛЮ ПО ЗАДАЧЕ С 5-ОГО СЕМИНАРА
Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5

Random rnd = new Random();
int[] array = new int[124];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(0, 150);
    Console.Write($" {array[i]}");
    if(array[i]<99 && array[i]>10)
    {
        count++;
    }
}
Console.WriteLine(" ");
Console.WriteLine($"Количество элементов в промеутке [10, 99]: {count}");
*/

int[] GetArray(int dimension)
{
    int[] arr = new int[dimension];
    Random randomizer = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = randomizer.Next(0, 100);
    }

    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void Sum(int[] arr)
{
    int summ = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] <= 99)
            summ++;
    }
    Console.WriteLine($"Кол-во чисел в отрезке от 10 до 99 в массиве из 123 {summ} ");
}

Console.WriteLine("Введите число массива");
int[] array = GetArray(123);
PrintArray(array);
Console.WriteLine();
Sum(array);
