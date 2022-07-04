/*
Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/
int GetNumber()
{
    int result = 0;

    while (true)
    {
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Вы ввели не число. Введите орректное числою");
        }
    }
    return result;
}

int GetSum(int number)
{
    int result = 0;
    for (int i = 1; 1 <= number; i++)
    {
        result += 1;
    }
    return result;
}

int number = GetNumber();
int result = GetSum(number);

Console.WriteLine(result);
