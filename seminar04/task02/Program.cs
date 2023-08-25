int Parce(string text)
{
    System.Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int Count(int number)
{
    int count = 1;

    for (int i = 0; number > 9; i++)
    {
        number /= 10;
        count++;
    }
    return count;
}
string text = "Введите число";
int number = Parce("Введите число");
int a = Count(number);
System.Console.WriteLine(a);