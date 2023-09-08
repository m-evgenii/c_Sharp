Console.WriteLine("Введите кол-во чисел в массиве");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];
Console.WriteLine("Введите числа");
void FillArray(int[] array){
    for(int i = 0; i < m; i ++){
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine(String.Join(" ", array));
}
FillArray(array);
int count = 0;
int Counter(int[] array){
    for(int i = 0; i < array.Length; i ++){
        if (array[i] > 0){
            count ++;
        }
    }
    return count;
}
Counter(array);
Console.WriteLine(count);