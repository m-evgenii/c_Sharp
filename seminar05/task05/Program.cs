Console.WriteLine("Введите количество чисел в массиве, а потом мы покажем произведения последнего и первого числа, предпоследнего и второго и тд.");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
void Array_numbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
       array[i] = new Random().Next(1, 101);
    }
    Console.WriteLine(String.Join(" ", array));
}
Array_numbers(array);
void final(int[] array)
{
    int i_i = array.Length - 1;
    int number_multi = 0;
    int i_half = array.Length / 2;
    for(int i = 0; i < i_half; i++)
    {
        number_multi = array[i_i] * array[i];
        Console.Write($"{number_multi} ");
        i_i = i_i - 1;
    }
    if(array.Length % 2 != 0)
    {
    Console.Write(array[i_half]);
    }
}
final(array);