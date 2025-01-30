using System;

class Program
{
    static void Main()
    {
      
        Console.Write("Você é assinante da Netflix? ");
        string diploma = (Console.ReadLine());
          
         Console.Write("Você ja assistiu Round 6?");
         string idade = (Console.ReadLine());
         bool resposta = Convert.ToBoolean(diploma.Equals("sim", StringComparison.OrdinalIgnoreCase));
         bool resposta2 = Convert.ToBoolean(idade.Equals("sim", StringComparison.OrdinalIgnoreCase));
         

        
       
        if (resposta == true && resposta2 == true){
             Console.WriteLine("Parabéns, você ja pode assistir a nova temporada!");
        }
        
        else{
             Console.WriteLine("Você não pode assistir a nova temporada!");}
        
        
       
    }
}