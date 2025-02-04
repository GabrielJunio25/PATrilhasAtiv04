using System;


class Program
{
  static void Main()
  {
    Console.Write("Digite um número: ");
    float num1 = float.Parse(Console.ReadLine());

    float valorAbs = Math.Abs(num1);
    Console.WriteLine("O valor absoluto de {0} é {1}", num1, valorAbs")
  }
  
}