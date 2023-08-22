Console.WriteLine("Введите две коррдинаты");
int x_coords = Convert.ToInt32(Console.ReadLine());
int y_coords = Convert.ToInt32(Console.ReadLine());
int f = 0;
if(x_coords > 0 && y_coords > 0){
    f = 1;
    Console.WriteLine(f);
}
else if(x_coords<0 && y_coords>0)
{
    f = 2;
    Console.WriteLine(f);
}
else if(x_coords>0 && y_coords < 0)
{
    f = 3;
    Console.WriteLine(f);
}
else if(x_coords<0 && y_coords<0)
{
    f = 4;
    Console.WriteLine(f);
}
else
{
    Console.WriteLine("Ни к одной четверти это не относится");
}