using System;


class Program
{
  static void Main()
  {
    Console.Write("Digite dois números: ");
    int num1 = int.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());
    
    
    Console.Write(num1 % num2 == 0 ? "É divisível" : "Não é divisível");;
  }
  
}