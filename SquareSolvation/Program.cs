int a = -10;
int b = -10;
int c = -10;
int x;
int count = 0;

while(a<11)
{
        b = -10;
        while(b<11)
        {
                c = -10;
                while (c < 11)
                {
                        x = -10;
                        while (x < 11)
                        {
                              if ((a*x*x + b*x + c )==0)
                              {
                                Console.WriteLine($"N = {count}, a = {a}, b = {b}, c = {c}, x = {x}");
                              }  
                              x++;
                              count ++;
                        }
                        c++;
                }
      
        b++;
        }
        a++;
   
}

