﻿Console.WriteLine("Введите две коррдинаты");
int x_coords1 = Convert.ToInt32(Console.ReadLine());
int y_coords1 = Convert.ToInt32(Console.ReadLine());
int z_coords1 = Convert.ToInt32(Console.ReadLine());
int x_coords2 = Convert.ToInt32(Console.ReadLine());
int y_coords2 = Convert.ToInt32(Console.ReadLine());
int z_coords2 = Convert.ToInt32(Console.ReadLine());
double f = 0;
f = Math.Sqrt((x_coords2 - x_coords1)*(x_coords2 - x_coords1) + (y_coords2 - y_coords1)*(y_coords2 - y_coords1) + (z_coords2 - z_coords1)*(z_coords2 - z_coords1));
Console.WriteLine($"{f:N2}");