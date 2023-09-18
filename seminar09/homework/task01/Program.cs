int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int Sum(int m, int n){
    if(m == n + 1){
        return sum;
    }
    return sum = m + Sum(m + 1, n);
}
Sum(m,n);
Console.WriteLine(sum);