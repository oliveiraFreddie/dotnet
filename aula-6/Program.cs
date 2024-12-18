namespace Aula06
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("===================Verificador de Número Par ou Ímpar====================");
      Console.WriteLine("Digite um número: ");
      int number = Convert.ToInt32(Console.ReadLine());

      int result = number % 2;
      Console.WriteLine("===================Resultado====================");
      if(result == 0)
      {
        Console.WriteLine("Esse número é Par!");
      }
      else
      {
        Console.WriteLine("Esse número é Ímpar!");
      }
    }
  }
}

