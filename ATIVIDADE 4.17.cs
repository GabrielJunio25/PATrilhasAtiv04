using System;


class Program
{
  static void Main()
  {
    Console.Write("DIGITE UM NÚMERO" );
    float x = float.Parse(Console.ReadLine());
    
      Console.Write(x % 2 == 0 ? "O número é par" : "O número é impar" );
  }
  
}