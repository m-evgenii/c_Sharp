int[,] array = new int[3, 4];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 20);
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
FillArray(array);
void Diog(int[,] array)
{
    int diog = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i == j){
                diog = diog + array[i, j];
            }
        }
    }
    Console.WriteLine(diog);
}
Diog(array);