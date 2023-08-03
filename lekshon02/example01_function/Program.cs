int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2>result) result = arg2;
    if(arg3>result) result = arg3;
    return result;
}
int a1 = 5;
int b1 = 35;
int c1 = 8;
int a2 = 6;
int b2 = 25;
int c2 = 87;
int a3 = 45;
int b3 = 644;
int c3 = 18;
int max = Max(Max(a1,b1,c1),Max(a2,b2,c2),Max(a3,b3,c3));
Console.WriteLine(max);
