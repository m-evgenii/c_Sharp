for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();
foreach (int element in array) {
    Console.Write(element + " ");
}
Console.WriteLine();
string arrayOutput = String.Join(", ", array);
Console.WriteLine("[" + arrayOutput + "]");