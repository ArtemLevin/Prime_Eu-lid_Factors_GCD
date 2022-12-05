Console.WriteLine("Введите число: ");
int n =  int.Parse(Console.ReadLine()!);
int ost; 
string newn;
while (n!=0)
{
    ost = n%2;
    n = n/2;
    newn = Convert.ToString(ost);
    Console.Write(newn);
}
