Console.Write("Пожалуйста, введите имя пользователя ");
string username = Console.ReadLine();

if(username.ToLower() == "igor")
{
    Console.WriteLine("Hi, beauty :-D");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
    Console.WriteLine("Where is my sweet Igor?");
}
