﻿double b1 = Convert.ToInt32(Console.ReadLine());
double k1 = Convert.ToInt32(Console.ReadLine());
double b2 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());
double x =(b2 - b1) / (k1 - k2);
double y=k1*x+b1;
Console.WriteLine(x + "; " + y);