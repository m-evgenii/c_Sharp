int[] array = {4,5,48,3,45,2,6,9};
int find = 9;
int result = -1;
int index = 0;
while(index<array.Length)
{
    if(array[index] == find){
        result = index;
    }
    index++;
}
Console.WriteLine(result);
