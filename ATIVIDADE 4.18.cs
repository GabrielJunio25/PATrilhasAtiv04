using System;


class Program
{
  static void Main()
  {
    Console.Write("DIGITE UM NÚMERO: " );
    float x = float.Parse(Console.ReadLine());
    Console.Write("DIGITE OUTRO NÚMERO: " );
    float y = float.Parse(Console.ReadLine());
    
      Console.Write(x > y ? "{0} é maior" : "{1} é maior", x, y );
  }
  
}