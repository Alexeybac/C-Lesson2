int a1 = 15;
int b1 = 111121;
int c1 = 39;
int a2 = 12;
int b2 = 2334;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 333;

int arg (int arg1, int arg2, int arg3)
{
    int max = arg1;
    if (arg2 > max) max = arg2;
    if (arg3 > max) max = arg3;
    return max;
}

int Max = arg(arg(a1, b1, c1),
              arg(a2, b2, c2),
              arg(a3, b3, c3));

Console.WriteLine(Max);
