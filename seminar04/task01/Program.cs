//int number = Convert.ToInt32(Console.ReadLine());
//int sum = 0
//for(int index = 0, index <= number, index++){
//    sum += index
//}
int parse(string text){
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
string text = "Введите число";
int sum(int number){
    int sum = 0;
    for(int index = 0, index <= number, index ++)
    {
        sum += index;
    }
    return sum;
}
int number = parse(text);
int Sum = sum(number);
int a = sum(4);
int b = sum(5);
Console.WriteLine(a + b + Sum);