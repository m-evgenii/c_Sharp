int number = Convert.ToInt32(Console.ReadLine());
int counter = 0;
int counter_( int number){
    while(number > 0){
        number /= 2;
        counter ++;
    }
    return counter;
}
counter_(number);
int[] zalupa = new int[counter];
int[] final(int number, int counter, int[] zalupa){
    for(int i = 0; i < counter; i ++){
        int bu = number / 2;
        if(number % 2 == 0){
            zalupa[i] = 0;
        }
        else{
            zalupa[i] = 1;
        }
        number = bu;
    }
    return zalupa;
}
final(number, counter, zalupa);
int[] array2 = new int[counter];
void array_f(int[] array, int[] array2){
    int i2 = 0;
    for(int i = array.Length -1; i > -1; i --){
        array2[i2] = array[i];
        i2 ++;
    }
    Console.WriteLine(String.Join(" ", array2));
}
array_f(zalupa,array2);