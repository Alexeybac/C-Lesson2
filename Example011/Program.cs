void fillaray(int[] collection)
{

int length = collection.Length;
int index = 0;
while (index < length)
{
    collection[index] = new Random().Next(1,100);
    index++;
}
}

void writearay(int[] col)
{
    int count = col.Length;
    int positon = 0;
    while (positon < count)
    {
        Console.Write(col[positon]);
        Console.Write(", ");
        positon++;
    }
}

//int [] aray = new int[5];
int [] aray = {1, 2, 3, 4, 5, 6, 7, 8};
//fillaray(aray);
writearay(aray);