int[,] array = new int[3, 4];

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
int[,] array2 = new int[3, 4];
void ChangeArray(int[,] array){
    for(int i2 = array.GetLength(1); i2 > 0; i2 --){
        for (int i = 0; i < array2.GetLength(1); i ++){
        array2[0, i] = array[array.GetLength(0), i2];
        }
    }
}
ChangeArray(array);
Console.WriteLine("-----------------------");
void Vivod(int[,] array2){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array2[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Vivod(array2);
//    int res = 0;
//    for (int i = 0; i < array.GetLength(1); i++)
//    {
//        res = array[0, i];
//        array[0, i] = array[array.GetLength(0) - 1, i];
//        array[array.GetLength(0) - 1, i] = res;
//}