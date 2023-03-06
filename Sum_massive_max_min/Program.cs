
int method(int [] massiv)
{
int index = 0;
int max = massiv[index];
int min = massiv[index];
int n = massiv.Length;
int sum = 0;

    while (index < n)
    {
        sum = sum + massiv[index];
        if (massiv[index] > max) max = massiv[index];
        if (massiv[index] < min) min = massiv[index];
        index++;
    }
    sum = sum - max - min;
return sum;
}

void fillmass(int [] collection)
{
    int index =0;
    int length = collection.Length;

    while (index < length)
    {
        collection[index] = new Random().Next(500,1000);
        index++;
    }
}


int [] mass = new int[1000];
fillmass(mass);
int rezult = method(mass);
Console.WriteLine(rezult);