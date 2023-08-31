int[] array = new int[8];
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    Console.WriteLine(String.Join(" ", array));
}
FillArray(array);