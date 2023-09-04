int[] array = new int[4];
void FillArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    Console.WriteLine(String.Join(" ", array)); 
}
FillArray(array);
int counter = 0;
int Count(int[] array){
    for(int i = 0; i < array.Length; i ++){
        if(array[i] % 2 == 0){
            counter ++;
        }
    }
    return counter;
}
Count(array);
Console.Write(counter);