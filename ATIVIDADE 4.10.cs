using System;

class Program
{
    static void Main()
    {
      
        Console.Write("Digite um número: " );
        float x = float.Parse(Console.ReadLine());
         
        if (x > 10 || x < 0){
             Console.WriteLine("Número válido");
           }
        else{
              Console.WriteLine("Número inválido");
           }
     
        
       
    }
}