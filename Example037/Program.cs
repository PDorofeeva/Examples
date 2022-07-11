/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8

string[] a = Console.ReadLine().Split(new Char[] { ' ' });
*/
int GetNumber()
{
    int result = 0;
    string error = "error";
    Console.WriteLine("Print number:");

    while (true)
    {

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine(error);
        }
    }
    return result;
}

void Fibonacci(int number)
{
    int result = 0;
    int sum = 0;
    int firstnumber = 1;
    int secondnumber = 1;

    if (number == 0)
    {
        Console.WriteLine("0");
        return;
    }
    else if(number == 1)
    {
        Console.WriteLine("0 1");
        return;
    }
    else if(number == 2)
    {
        Console.Write("0 1 1 ");
        return;
    }
Console.Write("0 1 1 ");
    for (int i = 3; i < number; i++)
    {   
        sum = firstnumber + secondnumber;
        firstnumber = secondnumber;
        secondnumber = sum;
        Console.Write($"{sum} ");
    }
    
}
int number1 = GetNumber();
Fibonacci(number1);
