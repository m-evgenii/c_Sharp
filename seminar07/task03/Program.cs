int[,] array = new int[3, 4];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 20);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
FillArray(array);

void FillArray2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i % 2 != 0 && j % 2 != 0){
                array[i, j] = array[i, j] * array[i, j];
            }
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
FillArray2(array);