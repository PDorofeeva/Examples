/*
Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/
int GetNumber()
{
    int result = 0;
    string error = "error";
    Console.WriteLine("Print number");

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
int numb = 0;
int number = GetNumber();
while (number>1)
{
    number = number/10;
    numb++;
}
numb = numb+1;
Console.WriteLine($"Кол-во цифр в числе {number} {numb}");