using System;

class Program
{
    static void Main()
    {
      
        Console.Write("Você quer leite ou açucar no seu café? " );
        string escolha = (Console.ReadLine());
          
         bool acucar = Convert.ToBoolean(escolha.Equals("açucar", StringComparison.OrdinalIgnoreCase));
         bool leite = Convert.ToBoolean(escolha.Equals("leite", StringComparison.OrdinalIgnoreCase));
         
         

        
       
        if (acucar == true){
             Console.WriteLine("Açuc,ar adicionado ao café!");
        }
        
         else if(leite == true){
             Console.WriteLine("Leite adicionado ao café!");
              }
         else{
              Console.WriteLine("Dados inválidos!");}
     
        
       
    }
}