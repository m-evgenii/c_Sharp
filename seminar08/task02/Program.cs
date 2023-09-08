int m = 4;
int n = 4;
int[,] array = new int[m, n];
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
FillArray(array);
Console.WriteLine("-----------------------");
int[,] array2 = new int[n, m];
void FinalArray(int[,] array2, int[,] array)
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            array2[j, i] = array[j, i];
            Console.Write(array2[j, i] + " ");
        }
        Console.WriteLine();
    }
}
FinalArray(array2, array);
if(m != n){
    Console.WriteLine("Невозможно перевернуть массив!");
}