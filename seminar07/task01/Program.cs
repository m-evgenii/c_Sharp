int[,] array = new int[4, 7];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

FillArray(array);