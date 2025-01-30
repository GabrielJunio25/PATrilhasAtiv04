using System;

class Program
{
    static void Main()
    {
      
        Console.Write("Digite um número: " );
        float x = float.Parse(Console.ReadLine());
          
        if (x % 3 == 0 && x % 3 == 0 ){
             Console.WriteLine("O número é divisivel por 3 e por 5");
           }
        else{
              Console.WriteLine("O número não é divisivel por 3 e por 5");
           }
     
        
       
    }
}