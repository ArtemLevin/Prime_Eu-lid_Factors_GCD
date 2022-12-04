Console.Write("Enter the first number: ");
int x = int.Parse(Console.ReadLine())!;

Console.Write("Enter the second number: ");
int y = int.Parse(Console.ReadLine()!);
int i = 1;

while (i <=x*y)

{
    if (i%x == 0 && i%y ==0)
    {
        Console.Write ($"LCM is {i} ");
        break;
    }
    i++;
}


