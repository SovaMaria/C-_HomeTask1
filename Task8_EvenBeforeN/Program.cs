﻿Console.WriteLine ("Введите число: ");
int n = Convert.ToInt32 (Console.ReadLine ());
int x = 1;
while (x<=n)
{
    if (x % 2 == 0)
    Console.WriteLine ($"{x} четное число");
    x = x + 1;
}
