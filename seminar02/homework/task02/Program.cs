Console.WriteLine("Введите число и мы покажем число сотен в этом числе");
int number = Convert.ToInt32(Console.ReadLine());
if(number<100){
    Console.WriteLine("третьей цифры нет");
}
else{
    number = number / 100;
    Console.WriteLine(number);
}
