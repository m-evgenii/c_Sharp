﻿int[] MyArray(int[] array)
{
    // int[] array = new int[8];

    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0,2);
        
        System.Console.Write(array[i] + " | ");

    }
    return array;
}

int[] array = new int[8];

MyArray(array);