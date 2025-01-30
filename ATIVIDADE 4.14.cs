using System;
using System.Threading;

class Program
{
    static void Main()
    {

        while (true) {
          Console.Write("Você é um cliente ativo? " );
          string opcao = (Console.ReadLine());

          switch(opcao.ToLower()){
          case "sim":
            Console.Write("Acesso liberado!" );
            break;
          case "nao":
            Console.Write("Por favor, atualize sua inscrição para continuar usufruindo dos benefícios do clube." );
            break;
          default:
            for (int i = 0; i < 5; i++) // Blink 5 times
            {
                Console.Write("Digite uma opcão válida.");
                Thread.Sleep(500); // Pause for 500 milliseconds
                Console.Clear(); // Clear the console
                Thread.Sleep(500); // Pause for 500 milliseconds
            }
            continue;
          }
          break; 

        }

    }
}