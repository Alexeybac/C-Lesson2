void fillbin(int x, int y)
{
    //int index = 0;
    while( x != 0)
    {
        Console.Write(x % y);
        x = x/y;
        //index++;
    }
} 

Console.Write("Введите целое десятичное число: ");
int count = int.Parse(Console.ReadLine());
Console.Write("Введите разрядность: ");
int des = int.Parse(Console.ReadLine());
fillbin(count, des);