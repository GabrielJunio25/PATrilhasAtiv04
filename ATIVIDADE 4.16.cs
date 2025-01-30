using System;


class Program
{
  static void Main()
  {
    Console.Write("Você não deseja cancelar a operação?" );
    string escolha = (Console.ReadLine());
      if (escolha.ToLower() == "não"){
        Console.WriteLine("Por favor, confirme o cancelamento da operação");
        }
      else{
        Console.WriteLine("A operação irá continuar!");
        }
  }
  
}