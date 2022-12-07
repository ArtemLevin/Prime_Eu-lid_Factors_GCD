
Console.SetCursorPosition(0, 5);
int i, j, k, Stolb, Stroka, p, R;
string Point;

for (k = 1; k <= 3; k++)
{
    for (i = 0; i <= 18; i++)
    {
        Console.Write("-");
    }
    Console.WriteLine(" ");

    for (j = 0; j <= 6; j++) ;
    {
        Console.WriteLine("|     |     |     |");
    }
}
for (i = 0; i <= 18; i++)
{
    Console.Write("-");
}
void location(int Stolb, int Stroka, string Point)

{
    if (Stolb == 1 && Stroka == 1)
    {
        Console.SetCursorPosition(3, 6);
    }
    if (Stolb == 1 && Stroka == 2)
    {
        Console.SetCursorPosition(3, 8);
    }
    if (Stolb == 1 && Stroka == 3)
    {
        Console.SetCursorPosition(3, 10);
    }
    if (Stolb == 2 && Stroka == 1)
    {
        Console.SetCursorPosition(9, 6);
    }
    if (Stolb == 2 && Stroka == 2)
    {
        Console.SetCursorPosition(9, 8);
    }
    if (Stolb == 2 && Stroka == 3)
    {
        Console.SetCursorPosition(9, 10);
    }
    if (Stolb == 3 && Stroka == 1)
    {
        Console.SetCursorPosition(15, 6);
    }
    if (Stolb == 3 && Stroka == 2)
    {
        Console.SetCursorPosition(15, 8);
    }
    if (Stolb == 3 && Stroka == 3)
    {
        Console.SetCursorPosition(15, 10);
    }
    Console.Write($"{Point}");
}

for (p = 1; p <= 10; p++)
{
    if (p % 2 != 0)
    {
        Point = "X";
        R = 1;
    }
    else
    {
        Point = "O";
        R = 2;
    }

    Console.WriteLine(" ");
    Console.Write($" Игрок {R} введите номер столбца: ");
    Stolb = int.Parse(Console.ReadLine()!);
    Console.Write($" Игрок {R} введите номер строки: ");
    Stroka = int.Parse(Console.ReadLine()!);
    location(Stolb, Stroka, Point);
    Console.SetCursorPosition(0, 11);


}

