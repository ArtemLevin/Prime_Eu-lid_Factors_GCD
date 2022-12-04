int a, b, c, n;
a = -10;
while (a<11)
{
    b = -10000;
    while (b<11)
    {
        c = -10;
        while (c<11)
        {
            n = -10;
            while (n<11)
            {
                if ((b*b - 4*a*c) == (b + n)*(b + n) && c!=0 && a!=0 && b!=0 && (b*b - 4*a*c) > 10000 )
                {
                    Console.WriteLine ($" a = {a}, b = {b}, c = {c}, n = {n}");
                }
                n++;
            }
            c++;
        }
        b++;
        
    }
    a++;
}
