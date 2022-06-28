/*Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/
Random num = new Random();
int number = num.Next(1, 1000);
Console.WriteLine(number);
int ThirdNumber = number % 10;
int FirstNumber = number / 100;
Console.Write(FirstNumber);
Console.Write(ThirdNumber);
