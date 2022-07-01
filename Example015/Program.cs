/*
Напишите программу, которая по заданному номеру четверти показываетcя
диапазон возможных координат точек в этой четверти (x, y).
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
             if(result>=1 && result<=4)
            {
               break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(error);
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

void Result( int quater)
{
    if (quater == 1)
    {
        Console.WriteLine("x>0 && y>0");
    }
    else if(quater == 2)
    {
        Console.WriteLine("x<0 && y>0");
    }
    else if(quater == 3)
    {
        Console.WriteLine("x<0 && y<0");
    }
    else
    {
        Console.WriteLine("x>0 && y<0");
    }
}
int quater = FirstFunction("Введите номер четверти: ");
Result(quater);
