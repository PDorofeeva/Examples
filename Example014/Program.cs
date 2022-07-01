/*
Напишите программу, которая принимает на вход координаты точек X и Y,
причём x и y не могут быть равны нулю. Программа выдаёт номер четверти плоскости, в которой находится эта точка.
*/
int FirstFunction(string message)
{
    int result = 0;
    string error = "Введите корректное число, пожалуйста!";

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            if(result == 0)
            {
                Console.Clear();
                Console.WriteLine(error);
            }
            else
            {
                break;
            }
        }
        else 
        {
            Console.Clear();
            Console.WriteLine(error);
        }
    }

    return result;
}


int Quater(int x, int y)
{
    if (x>0 && y>0)
    {
        return 1;
    }
    else if(x<0 && y>0)
    {
        return 2;
    }
    else if(x<0 && y<0)
    {
        return 3;
    }
    else
    {
        return 4;
    }
}


int x = FirstFunction("Введите первое число: ");
int y = FirstFunction("Введите второе число: ");
int quater = Quater(x, y);

Console.WriteLine($"Точка ({x}, {y}) лежат в {quater} четверти.");