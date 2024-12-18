namespace Aula04;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("-----CADASTRO DE USUÁRIO------");

    // Solicitar o nome do Usuário
    Console.WriteLine("Digite seu Nome:");
    string name = Console.ReadLine();
   
    // Solicitar a Idade
    Console.WriteLine("Digite sua Idade:");
    int age = Convert.ToInt32(Console.ReadLine());

    // Solicitar a Idade
    Console.WriteLine("Digite sua Altura:");
    double height = Convert.ToDouble(Console.ReadLine());

    // Resultado
    Console.WriteLine($"-----------------------");
    Console.WriteLine($"Nome do Usuário: {name}");
    Console.WriteLine($"Idade: {age}");
    Console.WriteLine($"Altura: {height} metros");
  }
}
