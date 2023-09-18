int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int ack(int m, int n){
    if(m == 0){
        return n + 1;
    }
    else if(n == 0){
        return ack(m - 1, 1);
    }
    return ack(m-1, ack (m, n - 1));
}
int final = ack(m,n);
Console.WriteLine(final); //первое задание вы сказали можно не делать