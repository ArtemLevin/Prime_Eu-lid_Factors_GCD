int index = 0;
bool count = false;


int n1 = new Random().Next(1, 100);
   if (n1 % 2 == 0)
    {
        Console.Write("P");
        index++;
    }
    else
    {
        Console.Write("O");
        index++;
    }

int a = new Random().Next(1, 100);
   if (a % 2 == 0)
    {
        Console.Write("P");
        index++;
    }
    else
    {
        Console.Write("O");
        index++;
    }

int b = new Random().Next(1, 100);
   if (b % 2 == 0)
    {
        Console.Write("P");
        index++;
    }
    else
    {
        Console.Write("O");
        index++;
    }

if ((n1%2 == 0 && a%2==0 && b%2==0) || (n1%2 != 0 && a%2!=0 && b%2!=0))
{
    Console.Write($"(попыток 3)");
}

else
{

while (count !=true)
{
n1 = new Random().Next(1, 100);
   if (n1 % 2 == 0)
    {
        Console.Write("P");
        index++;
    }
    else
    {
        Console.Write("O");
        index++;
    }

    if ((n1%2 == 0 && a%2==0 && b%2==0)|| (n1%2 != 0 && a%2!=0 && b%2!=0))
    {
        count = true;
    }
    if (index%2 ==0)
    {
        a = n1;
    }
     if (index%2 !=0)
    {
        b = n1;
    }
}
}
Console.Write($"(попыток {index})");



