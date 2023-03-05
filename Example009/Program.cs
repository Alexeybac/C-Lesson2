int arg (int arg1, int arg2, int arg3)
{
    int max = arg1;
    if (arg2 > max) max = arg2;
    if (arg3 > max) max = arg3;
    return max;
}

int [] aray = { 11, 12222, 13, 14, 15, 600, 71, 81, 91};

int Max = arg(arg(aray[0], aray[1], aray[2]),
              arg(aray[3], aray[4], aray[5]),
              arg(aray[6], aray[7], aray[8]));

Console.WriteLine(Max);