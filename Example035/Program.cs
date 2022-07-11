/*
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух 
других сторон

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

void Tringle(int a, int b, int c)
{
    if (a+b>c && a+c>b && c+b>a)
    {
        Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} существует");
    }
    else 
    {
        Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} не существует");
    }
}

int a = GetNumber();
int b = GetNumber(); 
int c = GetNumber();
Tringle(a, b, c);
