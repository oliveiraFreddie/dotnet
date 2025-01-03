﻿namespace Aula10;
public class Program
{
  public static void Main()
  {
    bool varContinue = true;

    while (varContinue)
    {
      // Inicialização do programa
      Console.WriteLine("============Caulculadora Simples============");
      Console.WriteLine("Digite o primeiro número: ");
      double num1 = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Digite o segundo número: ");
      double num2 = Convert.ToDouble(Console.ReadLine());

      // Selecionr o tipo de operação
      Console.WriteLine("\nEscolha uma operação:");
      Console.WriteLine("1. Adição (+)");
      Console.WriteLine("2. Subtração (-)");
      Console.WriteLine("3. Multiplicação (*)");
      Console.WriteLine("4. Divisão (/)");
      Console.WriteLine("Digite o numero da operação: ");
      int operation = Convert.ToInt32(Console.ReadLine());

      double result = 0;

      // Condições
      if(operation == 1)
      {
        result = num1 + num2;
      }
      else if(operation == 2)
      {
        result = num1 - num2;
      }
      else if(operation == 3)
      {
        result = num1 * num2;
      }
      else if(operation == 4)
      {
        if(num2 != 0)
        {
          result = num1 / num2;
        }
        else
        {
          Console.WriteLine("Erro! não é possível dividir um número por Zero.");
        }
      }
      else
      {
        Console.WriteLine("Operação Inválida");
      }
      Console.WriteLine($"\nResultado: {result} \n");
      Console.WriteLine("\n Deseja realizar outra operação (s/n) ?");
      string response = Console.ReadLine();

      if(response != "s")
      {
        varContinue = false;
      }
    }
    Console.WriteLine("Bye");
  }
}