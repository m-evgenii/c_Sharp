﻿int n = Convert.ToInt32(Console.ReadLine());
int SumDigit(int n)
{
    // базовый случай - число состоит из одной цифры
    if (n < 10)
    {
        return n;
    }
    // рекурсивный случай - число состоит из 2 и более цифр
    else
    {
        return n % 10 + SumDigit(n / 10);
    }
}
Console.WriteLine("Сумма цирф {0} равна {1}", n, SumDigit(n));