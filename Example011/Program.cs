void fillaray(int[] collection)
{

int length = collection.Length;
int index = 0;
while (index < length)
{
    collection[index] = new Random().Next(1,10);
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

int Indexoff( int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int positon = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            positon = index;
            break;
        }
        index++;
    }
    return positon;
}

int [] aray = new int[10];

fillaray(aray);
writearay(aray);
Console.WriteLine();

int pos = Indexoff(aray, 40);
Console.WriteLine(pos);