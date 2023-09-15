int m = 4;
int n = 3;
int[,] array = new int[m, n];
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
Console.WriteLine("----------------");
int min = array[0,0];
int minStr = 0;
int minStl = 0;
void FindMinIndex(int[,] array){

    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            if(min>array[i,j]){
                min = array[i,j];
                minStr = i;
                minStl = j;
            }
        }
    }
}
FindMinIndex(array);
Console.WriteLine(minStr);
Console.WriteLine(minStl);
Console.WriteLine("----------------");
int[,] array2 = new int[m, n];
void PrintArray(int[,] array, int[,] array2)
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        if(i == minStr){
            i++;
        }
        for (int j = 0; j < array2.GetLength(1); j++)
        {

            if(j == minStl){
                array2[i,j] = 0;
                if(j == array2.GetLength(1)){
                    i++;
                    j--;
                }
                j++;
            }
            array2[i, j] = array[i,j]; //Вообщем почти сделал задачу, но так не понял как исправить ошибку если меньшая цифра находится в 3 столбце
            Console.Write(array2[i, j] + " ");
        }
        Console.WriteLine();
    }
}
PrintArray(array,array2);