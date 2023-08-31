int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
void metod(int number1, int number2){
    int a = number1;
    for(int i = 1; i != number2; i ++){
        number1 = number1 * a;
    }
    Console.WriteLine(number1);
}
metod(number1,number2);