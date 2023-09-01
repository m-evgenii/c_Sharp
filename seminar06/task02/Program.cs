Console.WriteLine("Введите длины сторон треугольника:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if (a + b > c && a + c > b && b + c > a)
{
    Console.WriteLine("Треугольник существует.");
}
else
{
    Console.WriteLine("Треугольник не существует.");
}