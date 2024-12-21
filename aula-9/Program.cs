namespace Aula09;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("==========Operadores Lógicos==========");

    bool isLogged = true;
    bool hasAdminAcces = false;

    Console.WriteLine("\nInformações do Usuário");
    Console.WriteLine($"Usuário logado: {isLogged}");
    Console.WriteLine($"Acesso ao painel de administrador: {hasAdminAcces}");

    // Operador (&&) - E
    if (isLogged && hasAdminAcces)
    {
      Console.WriteLine("Acesso ao painel de administrador concedido");
    }
    else
    {
      Console.WriteLine("Acesso ao painel de administrador negado");
    }

    // Operador (||) - Ou
    if (isLogged || hasAdminAcces)
    {
      Console.WriteLine("Acesso concedido");
    }
    else
    {
      Console.WriteLine("Sem acesso");
    }

    // Operador (!) - Negação
    if (!isLogged)
    {
      Console.WriteLine("Usuário Ausente");
    }
    else
    {
      Console.WriteLine("Usuário Logado");
    }
  }
}