using System;

class Program
{
    static void Main()
    {
      
        Console.Write("Deseja comprar um produto?: " );
        string escolha = (Console.ReadLine());
          bool sim = Convert.ToBoolean(escolha.Equals("sim", StringComparison.OrdinalIgnoreCase) ||
                                       escolha.Equals("s", StringComparison.OrdinalIgnoreCase));
        if (sim == true){
             Console.WriteLine("Obrigado pela compra!");
           }
        else{
              Console.WriteLine("Adeus, então!");
           }
     
        
       
    }
}