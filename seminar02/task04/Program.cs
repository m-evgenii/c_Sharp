int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 % number2 == 0){
    Console.WriteLine("Кратно");
}
else{
    Console.WriteLine("Не кратно");
    Console.WriteLine($"остаток = {number1 % number2}");
}
