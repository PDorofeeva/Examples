int[] array = {2, 45, 5, 432, 3, 89, 50, 43, 7, 1, 34, 50};

int n = array.Length;
int index = 0;
Console.WriteLine("Укажите искомое значение: ");
int find = int.Parse(Console.ReadLine());

while (index<n)
{
    if (array[index] == find)
    {
        Console.WriteLine($"Индекс, принадлежащий числу {find}: {index}");
        break;
    }

    index++;
}

