void PrintArray(int[] array)
{
    for(int i = 0; i< array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void PrintArrayForEach(int[] array)
{
    foreach(int item in array)
    {
        Console.Write($"{item} ");
    }
}


var array = new int[8];
Random rnd = new Random();

for(int i=0; i < array.Length; i++)
{
    array[i] = rnd.Next(1,10);
}

Console.WriteLine("Вывод через цикл for: ");
PrintArray(array);
Console.WriteLine();


Console.WriteLine("Вывод через цикл foreach: ");
PrintArrayForEach(array);

