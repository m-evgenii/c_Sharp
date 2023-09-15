// два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int Result(int number, int number2){
    if (number2 == 1) {
        return number;
    }
    return number * Result(number, --number2);
}
int result = Result(a, b);
Console.WriteLine(result);