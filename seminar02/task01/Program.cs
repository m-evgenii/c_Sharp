Random rand = new Random();
int number = rand.Next(10,100);
Console.WriteLine(number);
int first_number = number % 10;
int secont_number = number / 10;
int max = first_number;
if(secont_number>first_number){
    max = secont_number;
    Console.WriteLine(max);
}
else if(first_number == secont_number){
    Console.WriteLine("Числа равны");
}
else if(first_number>secont_number){
    Console.WriteLine(max);
}