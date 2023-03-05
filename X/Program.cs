int X( int[] mass1, int [] mass2)
{
    int count1 = mass1.Length;
    int count2 = mass2.Length;
    int index1 = 0;
    int index2 = 0;
    int sum = 0;

    while (index1 < count1)
    {
        while(index2 < count2)
        {
            sum = sum + mass1[index1] * mass2[index2];
            index2++;
        }
        index1++;
        index2 = 0;
    }
    return sum;
}

int [] aray1 = {1, 8, 3, 5};
int [] aray2 = {1, 3, 15, 42, 18, 34, 46};

int result = X(aray1, aray2);
Console.WriteLine(result);