Console.Write("Enter the number: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(" ");
int i;
Console.Write($"{N} = 1");
int count = 0;
while (N != 1)
 {
    i=2;
    while (N%i!=0)
    {
      i++;
    }
    Console.Write("*"+i);
    N = N/i;
    count ++;
 }

 if (count == 1)
 {
    Console.WriteLine(" ");
    Console.Write("Введено простое число");
 }
 else
 {
    Console.WriteLine(" ");
    Console.Write("Введено составное число");
 }