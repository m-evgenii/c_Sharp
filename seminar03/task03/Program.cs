Console.WriteLine("Введите число!");
int a = Convert.ToInt32(Console.ReadLine());
int f = 1;
int i = 1;
while(i / a / a != a){
    i = f * f * f;
    Console.Write(i+" ");
    f ++;
}