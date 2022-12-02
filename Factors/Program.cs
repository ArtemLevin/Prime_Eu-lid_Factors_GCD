
Console.Write("Enter the number: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(" ");
int i;
Console.Write($"{N} = 1");
while (N != 1)
 {
    i=2;
    while (N%i!=0)
    {
      i++;
    }
    Console.Write("*"+i);
    N = N/i;
 }