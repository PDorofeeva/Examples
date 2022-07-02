// Упорядочить элементы массива.

int[] array = {1, 2, 3, 40, 9, 6, 7, 8, 0, 10};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i<array.Length; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j]> array[maxPosition])
            {
                maxPosition = j;
            }
        }


        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}
SelectionSort(array);

PrintArray(array);