Console.WriteLine("Введите число M и N ");

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
FillArray(array);