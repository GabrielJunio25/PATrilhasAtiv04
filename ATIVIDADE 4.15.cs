using System;


class Program
{
  static void Main()
  {
    Console.Write("Digite uma palavra: " );
    string palavra = (Console.ReadLine());
      if (palavra.Length == 0){
        Console.WriteLine("Palavra vazia");
        }
      else{
        Console.WriteLine("Palavra não vazia");
        }
  }
  
}