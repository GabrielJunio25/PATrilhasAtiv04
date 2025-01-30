using System;

class Program
{
    static void Main()
    {
      
        Console.Write("Você é um robô: " );
        string resposta = (Console.ReadLine());
         
        switch(resposta.ToLower()){
        case "nao":
          Console.Write("Prove que você não é um robô " );
          break;

        case "sim":
          Console.Write("Acesso negado! " );
          break;
          
        default:
          Console.Write("Acesso negado!" );
          break;
        }
      
      
        
       
    }
}