using System;

class Program
{
    static void Main()
    {
      
        Console.Write("DIGITE UM NÚMERO: " );
        int numero = int.Parse(Console.ReadLine());
         
        switch(numero != 0){
        case true:
          Console.Write("Número diferente de 0 " );
          break;
          
        default:
          Console.Write("Número igual a 0" );
          break;
        }
      
      
        
       
    }
}