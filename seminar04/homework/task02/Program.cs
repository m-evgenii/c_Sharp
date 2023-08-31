Console.WriteLine("Введите число, и мы покажем вам сумму чисел в этом числе.");
int counter = 0;
int number = Convert.ToInt32(Console.ReadLine());
int counter_number(int number){
    while(number != 0){
        number = number / 10;
        counter ++;
    }
    return counter;
}
counter_number(number);
int Sum_ofnumbs_innumb(int counter){
    int sum_numbers = 0;
    while(counter != 0)
    {
        sum_numbers = sum_numbers + (number % 10);
        counter --;
    }
    return sum_numbers;
}
int sum_of_numbers = Sum_ofnumbs_innumb(counter);
Console.WriteLine($"Сумма чисел в этом числе равна: {sum_of_numbers}");