int[] aray = {1, 2, 3,100, 4, 5, 6, 7,100};

int index = 0;
int n = aray.Length;

int find = 300;

while (index < n)
{
    if (aray[index] == find)
    {
        Console.Write("Индекс искомого числа в массиве соответствует: -  ");
        Console.WriteLine(index);
        break;
    }
    index++;
    
}
