Console.WriteLine("Введите номер четвеерти");
int coords = Convert.ToInt32(Console.ReadLine());
int x = 0;
int y = 0;
if(coords == 1){
    x = 1;
    y = 1;
    Console.WriteLine($"x и y от {x} до плюс бесконечности");
}
else if(coords == 2){
    x = -1;
    y = 1;
    Console.WriteLine($"x и y от {x} до минус бесконечности для x и от {y} до плюс бесконечности для y");
}
else if(coords == 3){
    x = 1;
    y = -1;
    Console.WriteLine($"x и y от {x} до плюс бесконечности и от {y} до минус бесконечности для y");
}
else if(coords == 4){
    x = -1;
    y = -1;
    Console.WriteLine($"x и y от {x} до минус бесконечности");
}
