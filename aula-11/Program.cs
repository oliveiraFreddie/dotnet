namespace Aula11;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Digite um número:");
    int number = Convert.ToInt32(Console.ReadLine());

    switch (number)
    {
      case 1:
        Console.WriteLine("O número é 1.");
        break;
      case 2:
        Console.WriteLine("O número é 2.");
        break;
      default: // O default no switch funciona como um "else" e é executado se nenhum dos outros casos for verdadeiro.
        Console.WriteLine("O número é outro qualquer.");
        break;
    }
  }
}