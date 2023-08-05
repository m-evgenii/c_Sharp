Console.WriteLine("Напишите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int result = number / 10;
result = result % 10;
Console.WriteLine(result);
