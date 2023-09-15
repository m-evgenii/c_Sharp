int n = 4;
int m = 4;
int k = 1; //множитель определаяющий на сколько больше будет каждое следующие число массива
int[,] array = new int[n,m];
void FillArray(int[,] array)
{
    array[0, 0] = 1;
    for(int i = 0; i < array.GetLength(1); i++){
        if(i==0){
            array[0, i] = array[0, m - 1] + k;
        }
        else{
            array[0, i] = array[0, i - 1] + k;
        }
    }
    for(int i = 1; i < array.GetLength(1); i++){
        array[i, 3] = array[i - 1, 3] + k;
    }
    for (int i = 3; i > 0; i--)
    {
        array[3,i - 1] = array[3,i] + k;
    }
    for(int i = 2; i > 0; i--){
        array[i, 0] = array[i + 1, 0] + k;
    }
    for(int i = 1; i < array.GetLength(1) - 1; i++){
        array[1, i] = array[1, i - 1] + k;
    }
    for(int i = 2; i < array.GetLength(1)-1; i++){
        array[i, 2] = array[i - 1, 2] + k;
    }
    for (int i = 1; i > 0; i--)
    {
        array[2,i] = array[2,i + 1] + k;
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
FillArray(array);