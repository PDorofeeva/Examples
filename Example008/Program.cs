int Max( int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2>result) result = arg2;
    if (arg3>result) result =arg3;
    return result;
}

int a1 = 23;
int b1 = 56;
int c1 = 15677;
int a2 = 24;
int b2 = 31;
int c2 = 40;
int a3 = 480;
int b3 = 32;
int c3 = 13;

int max = Max(
    Max(a1, b1, c1), 
    Max(a2, b2, c2), 
    Max(a3, b3, c3));
Console.WriteLine($"Максимальное значение: {max}");
