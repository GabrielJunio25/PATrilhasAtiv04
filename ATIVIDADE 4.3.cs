using System;

class Program
{
    static void Main()
    {
      
        Console.Write("Você possui um diploma de ensino superior? ");
        string diploma = (Console.ReadLine());
          
         Console.Write("Você tem mais de 21 anos? ");
         string idade = (Console.ReadLine());
         bool resposta = Convert.ToBoolean(diploma.Equals("sim", StringComparison.OrdinalIgnoreCase));
         bool resposta2 = Convert.ToBoolean(idade.Equals("sim", StringComparison.OrdinalIgnoreCase));
         

        
       
        if (resposta == true && resposta2 == true){
             Console.WriteLine("Você é qualificado.");
        }
        
        else{
             Console.WriteLine("Você não é qualificado.");}
        
        
       
    }
}