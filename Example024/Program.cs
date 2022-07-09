/*
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
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
void SymNumber(int number)
{
    int result = 1;
    for (int i = 1; i <= number; i++)
    {
        result = result * i;
    }
     Console.WriteLine(result);
}
//Основной код
int digit = GetNumber();
SymNumber(digit);

