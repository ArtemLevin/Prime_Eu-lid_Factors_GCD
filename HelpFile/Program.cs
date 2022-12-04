Console.Write(" Введите число N = ");
double N = Convert.ToDouble(Console.ReadLine());
string output =string.Format($" Результат деления:  + {N/3:F}");
Console.Write(output);

string sq =string.Format($" Результат извлечения корня:  + {Math.Sqrt(N):F}");
Console.Write(sq);


