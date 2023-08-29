int[] array = new int[4];
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    Console.WriteLine(String.Join(" ", array));
}
FillArray(array);
void metod(int[] array){
    for( int i = 0; i < array.Length; i ++){
        array[i] *= -1;
    }
    Console.WriteLine(String.Join(" ", array));
}
metod(array);
