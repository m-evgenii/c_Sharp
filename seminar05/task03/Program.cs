int[] array = new int[4];
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-1000, 1001);
    }
    Console.WriteLine(String.Join(" ", array));
}
FillArray(array);
int final = 0;
int number = Convert.ToInt32(Console.ReadLine());
void metod(int[] array){
    for( int i = 0; i < array.Length; i ++){
        if(array[i] == number){
            final = 1;
        }
    }
    if(final == 1){
        Console.WriteLine("Да");
    }
    else{
        Console.WriteLine("Нет");
    }
}
metod(array);
