int m = 2;
int n = 2;
int[,] array = new int[m, n];
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 4);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
FillArray(array);
Console.WriteLine("----------------");
int[,] array2 = new int[2, 2];
void FillArray2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 4);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
FillArray2(array2);
Console.WriteLine("----------------");
int arg = 0;
int[,] matrix = new int[m, n];
int[,] Final(int[,] array, int[,] array2){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array2.GetLength(1); j++){
            for (int k = 0; k < array2.GetLength(1); k++){
                arg = arg + array[i,k] * array2[k,j];
            }
            matrix[i,j] = arg;
            arg = 0;
        }
    }
    return matrix;
}
Final(array,array2);
void PrintMatrix(int[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
PrintMatrix(matrix);