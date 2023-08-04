Console.WriteLine("Введите первое число");
string input1 = Console.ReadLine();
int number1 = Convert.ToInt32(input1);
Console.WriteLine("Введите второе число");
string input2 = Console.ReadLine();
int number2 = Convert.ToInt32(input2);
if (number2 == number1 * number1 || number1 == number2 * number2) // || - это или
{
    Console.WriteLine("да");
}
else{
    Console.WriteLine("нет");
}