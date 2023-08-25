int Parce(string text)
{
    System.Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
string text = "Введите число";
int number = Parce("Введите число");
int sum = 1;
int Cam(int number){
    for(int i = 2; i != number + 1; i ++){
        sum = sum * i;
        Console.WriteLine($"sum = {sum}");
    }
    return sum;
}
Cam(number);