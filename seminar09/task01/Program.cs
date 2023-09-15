void PrintNumber(int n, int m)
{
    if (n == m) {
        Console.Write(n);
        return;
    }
    Console.Write(n + ", ");
    PrintNumber(n + 1, m);
}

PrintNumber(1, 5);