int [] GetArray(int dimension)
{
    int [] arr = new int[dimension];
    Random randomizer = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = randomizer.Next(1,10);
    }

    return arr;
}

void PrintArray(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int [] ArrayReverse(int [] arr)
{
    int [] resultArray = new int[arr.Length];
    int count = 0;

    for (int i = arr.Length - 1; i >= 0; i--)
    {
        resultArray[count] = arr[i];
        count++;
    }

    return resultArray;
}
Console.WriteLine("Начальный массив: ");
int[] primaryArr = GetArray(6);
PrintArray(primaryArr);

Console.WriteLine();
Console.WriteLine("Конечный массив: ");

int[] resultArray = ArrayReverse(primaryArr);
PrintArray(resultArray);

Console.WriteLine();
Console.WriteLine("Начальный массив через Reverse(): ");
PrintArray(primaryArr.Reverse().ToArray());
