using System;
using System.Threading;

class Program
{
    static void Main()
    {

        while (true) {
          Console.Write("\nVocê é um cliente ativo? " );
          string opcao = (Console.ReadLine());

          switch(opcao.ToLower()){
          case "sim":
            Console.Write("Acesso liberado!" );
            break;
          case "nao":
            Console.Write("Por favor, atualize sua inscrição para continuar usufruindo dos benefícios do clube." );
            break;
          default:
            Console.Write("Digite uma opcão válida.");
            Thread.Sleep(2000); 
            continue;
          }
          break; 

        }

    }
}