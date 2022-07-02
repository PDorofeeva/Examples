/*
Напишите программу, которая принимает на вход координаты двух
точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/

int FirstFunction(string message)
{
    int result = 0;
    string error = "Введите корректное число, пожалуйста!";

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result)) // int выводиm
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

int x1 = FirstFunction("Введите координату x первой точки: ");
int y1 = FirstFunction("Введите координату y первой точки: ");
int x2 = FirstFunction("Введите координату x второй точки: ");
int y2 = FirstFunction("Введите координату y второй точки: ");

double length = Math.Sqrt(Math.Pow(x2-x1,2)+ Math.Pow(y2-y1,2));
Console.WriteLine($"Расстояние между точками: {length} ");

