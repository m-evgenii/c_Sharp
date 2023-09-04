double[] array = new double[4];
array[0] = 1.7;
array[1] = 3.7;
array[2] = 25.9;
array[3] = 20.9;
void MinMax(double[] array){
    double min = 0;
    double max = 0;
    max = array[0];
    min = array[0];
    for(int i = 0; i < array.Length; i ++){
        if(array[i] > max){
            max = array[i];
        }
        else if(array[i] < min){
            min = array[i];
        }
    }
    Console.Write(max - min);
}
MinMax(array);