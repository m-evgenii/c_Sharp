int[] array = new int[10];
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 1001);
    }
    Console.WriteLine(String.Join(" ", array));
}
FillArray(array);
int[] array2 = new int[array.Length];
void array_f(int[] array, int[] array2){
    int i2 = 0;
    for(int i = array.Length -1; i > -1; i --){
        array2[i2] = array[i];
        i2 ++;
    }
    Console.WriteLine(String.Join(" ", array2));
}
array_f(array,array2);