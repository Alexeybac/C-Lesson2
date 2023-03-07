void fillbin(int x)
{
    int index = 0;
    while( x != 0)
    {
        int rez = (x % 2);
        x = x/2;
        Console.Write(rez);
        index++;
    }
} 


Console.Write("Введите десятичное число: ");
int des = int.Parse(Console.ReadLine());
fillbin(des);
