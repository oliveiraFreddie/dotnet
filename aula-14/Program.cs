﻿namespace Aula14;

public class Program
{
  public static void Main()
  {
    // for (int i = 1; i <= 10; i++)
    // {
    //   Console.WriteLine(i);
    // }

    Console.WriteLine("========Tabela de Multiplicação========");
    for (int i = 1; i <= 10; i++)
    {
      for (int j = 1; j <= 10; j++)
      {
        Console.WriteLine($"{i} x {j} = {i * j}");
      }
      Console.WriteLine();
    }
  }
}