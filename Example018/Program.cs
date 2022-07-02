// ВИДЫ МЕТОДОВ

// 1 Метод
void FirstMethod()
{
    Console.WriteLine("I'm Barashnya. Nice to see you here.");
}
//FirstMethod();   Обращение к функции


// 2 Метод
void Method2(string message)
{
    Console.WriteLine(message);
}
//Method2(message: "Текст сообщения");


void Method21(string message, int count)
{
   int i = 0;
   while(i<count)
   {
    Console.WriteLine(message);
    i++;
   }
}
//Method21(message: "HAHAHAHA", 5);
//Method21(count: 4, message:"Новый текст");


// 3 Метод
int Method3()
{
    return DateTime.Now.Month;
}

int month = Method3();
// Console.WriteLine(month);


/* 4 Метод
string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;

    while (i<count)
    {
        result= result + c;
        i++;
    }
    return result;
}
string res = Method4(10, "be");
Console.Write(res);
*/

string Method4(int count, string c)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result= result + c;
    }
    return result;
}
string res = Method4(10, "be");
Console.WriteLine(res);

