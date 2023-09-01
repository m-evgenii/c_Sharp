int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
int a = 0;
int b = 1;
array[0] = 0;
array[1] = 1;
Console.Write(" " + array[0]);
Console.Write(" " + array[1]);
void array_fobo(int[] array){
    for(int i = 2; i < number; i++){
        array[i] = a + b;
        a = array[i-1];
        b = array[i];
        Console.Write(" " + array[i]);
    }
}
array_fobo(array);