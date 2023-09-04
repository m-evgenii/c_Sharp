int[] array = new int[4];
void FillArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
    Console.WriteLine(String.Join(" ", array)); 
}
FillArray(array);
int counter = 0;
int Count(int[] array){
    for(int i = 1; i < array.Length; i = i + 2){
        counter += array[i];
    }
    return counter;
}
Count(array);
Console.Write(counter);