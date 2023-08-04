Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int a = number / 100;
a = a * 10;
int b = number % 10;
int result = a + b;
Console.WriteLine(result);
