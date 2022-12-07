
int rev = 0;
int rem;
int orin;
Console.WriteLine("Введите число: ");
int n =  int.Parse(Console.ReadLine()!);
orin = n;

while (n!=0)
{
    rem = n%10; 
    rev = rev*10 + rem;
    n=n/10;
}

if (orin == rev)
{
    Console.WriteLine("палиндром");
}
else
{
    Console.WriteLine("Не явялется палиндромом");
}