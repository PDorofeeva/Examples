/*
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да

*/
Random rnd = new Random();
int[] array = new int[10];
int find = 0;
for (int i = 0; i < array.Length; i++)
{
   array[i] = rnd.Next(0, 10);
   if(array[i] == find)
   {
    Console.WriteLine($"Искомый элемент {array[i]} присутствует в заданном массиве.");
    break;
   }

}
