int number = 73573;
int a1 = number % 10;
int a2 = number / 10;
a2 = a2 % 10;
int a3 = number / 100;
a3 = a3 % 10;
int a4 = number / 1000;
a4 = a4 % 10;
int a5 = number / 10000;
string final = $"{a1}" + $"{a2}" + $"{a3}" + $"{a4}" + $"{a5}";
int right_final = Convert.ToInt32(final);
if(number == right_final){
    Console.WriteLine("true");
}
else{
    Console.WriteLine("false");
}