﻿namespace Aula08;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("============Operadores Relacionais============\n");
    Console.WriteLine("Digite o primeiro número: ");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite o segundo número: ");
    int y = Convert.ToInt32(Console.ReadLine());

    string result;

    // Operador de Igualdade (==)
    if(x == y)
    {
      result = "x é igual a y";
    }
    else
    {
      result = "x é diferente de y";
    }
    Console.WriteLine($"\nIgualdade (==): {result}");

    // Operador de Não Igualdade (!=)
    if(x != y)
    {
      result = "x é diferente de y";
    }
    else
    {
      result = "x  é igual a y";
    }
    Console.WriteLine($"\nNão Igualdade (!=): {result}");

    // Operador Maior que (>)
    if(x > y)
    {
      result = "x é maior que y";
    }
    else if(x == y)
    {
      result = "x  é igual a y";
    }
    else
    {
      result = "x é menor que y";
    }
    Console.WriteLine($"\nMaior que (>): {result}");

    // Operador Menor que (>)
    if(x < y)
    {
      result = "x é menor que y";
    }
    else if(x == y)
    {
      result = "x  é igual a y";
    }
    else
    {
      result = "x é maior que y";
    }
    Console.WriteLine($"\nMenor que (<): {result}");

    // Operador Maior ou igual (>=)
    if(x >= y)
    {
      result = "x é maior ou igual a y";
    }
    else
    {
      result = "x é menor que y";
    }
    Console.WriteLine($"\nMaior ou igual (>=): {result}");

    // Operador Menor ou igual (<=)
    if(x <= y)
    {
      result = "x é menor ou igual a y";
    }
    else
    {
      result = "x é maior que y";
    }
    Console.WriteLine($"\nMenor ou igual (<=): {result}");

  }
}