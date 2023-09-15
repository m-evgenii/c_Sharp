using System;

public class Answer {
    public static void PrintArray (int [,] matrix)
    {
      for (int i = 0; i < matrix.GetLength(0); i++)
      {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine(" ");
      }

    }
  
    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
      int[,] matrix = new int[n, m];
      matrix[0,0] = 1;
      for(int i = 0; i < matrix.GetLength(0); i++)
      {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          
          if(i == 0 && j ==0){
            j++;
            }
          if(j==0){
            matrix[i, j] = matrix[i - 1, m - 1] + k;
            }
          else{
            matrix[i, j] = matrix[i, j - 1] + k;
          }
        }
      }
      return matrix;
    }
  
    static void PrintListAvr (double [] list)
    {
      Console.WriteLine("The averages in columns are: ");
      for(int i = 0; i < list.Length; i++){
        Console.Write($"{list[i]:N2}" + "\t");
      }
      Console.Write(" ");

    }

    static double [] FindAverageInColumns (int [,] matrix)
    { 
      double[] list = new double[matrix.GetLength(1)];
      for(int i = 0; i < matrix.GetLength(1);i ++){
        for(int j = 0; j < matrix.GetLength(0); j++){
          list[i]  = list[i] + matrix[j, i];
        }
        list[i] = list[i] / matrix.GetLength(0);
      }
      return list;
    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int n, m, k;

        if (args.Length >= 3) {
           n = int.Parse(args[0]);
           m = int.Parse(args[1]);
           k = int.Parse(args[2]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           n = 3;
           m = 4;
           k = 3;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
    }
}