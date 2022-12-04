Console.Write("Enter the first number: ");
int x = int.Parse(Console.ReadLine())!;

int ost= 0;
int newnum = 0;
int newost;

while (x!=0)
{
    newost = x%10;
    newnum = ost*10 + newost;
    ost = newnum;
    x/=10;
}

Console.Write("Число наоборот: " + newnum);