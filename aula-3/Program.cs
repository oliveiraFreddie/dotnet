namespace Aula03;
public class Program
{
  public static void Main()
  {
     string myName = "Frederico";
     int age = 20;
     double height = 1.65;
     char character = 'a';
     bool boolean = true;
     // Interpolação
     Console.WriteLine($"Oi meu nome é {myName} e tenho {age} anos e tenho {height} de altura.");
     // Concatenação
     Console.WriteLine("Oi meu nome é " + myName + " e tenho " + age + " anos.");
     // String.Format
     Console.WriteLine(string.Format("Oi meu nome é {0} e tenho {1} anos.", myName, age));
     // Utilizando bool e char interpolando
     Console.WriteLine($"Você mora na Rua do Morro casa {character}? {boolean}, eu moro lá.");

     // Utilizando var, ele identifica o tipo da variável na primeira atribuição (não aceita modificar o tipo em uma próxima atribuição)

     var qualquer = "Fred";
     // qualquer = 01; Vai gerar erro pois tentou-se mudar o tipo
     qualquer = "Bia";
     Console.WriteLine(qualquer);

      // Utilizando dynamic, é possível mudar o tipo a cada atribuição
     dynamic variable = 20;
     variable = "Pedro";
     Console.WriteLine(variable);
  }
}
