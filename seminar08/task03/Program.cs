int m = 3;
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
int[] sum = new int[m];
int[] Stroka(int[,] array){
    for(int j = 0; j < array.GetLength(0); j ++){
        for (int i = 0; i < array.GetLength(1); i++){
            sum[j] += array[j, i];
    }
    }
    return sum;
}
Stroka(array);
void Final(int[] sum){
    int min = sum[0];
    int count = 1;
    for (int i = 0; i < sum.Length; i++)
    {
        if(min>sum[i]){
            min = sum[i];
            count = i + 1;
        }
    }
    Console.WriteLine(count);
}
Final(sum);