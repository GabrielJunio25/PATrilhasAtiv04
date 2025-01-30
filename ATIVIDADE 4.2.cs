using System;

class Program
{
    static void Main()
    {
      
        Console.Write("Deseja comprar um carro? ");
        string desejo = (Console.ReadLine());
          
         Console.Write("\nPossui dinheiro suficiente? ");
         string dinheiro = (Console.ReadLine());
         bool resposta = Convert.ToBoolean(desejo.Equals("sim", StringComparison.OrdinalIgnoreCase));
         bool resposta2 = Convert.ToBoolean(dinheiro.Equals("sim", StringComparison.OrdinalIgnoreCase));
         

        
       
        if (resposta == true && resposta2 == true){
             Console.WriteLine("Parabéns, você pode comprar um carro.");
        }
        
        else{
             Console.WriteLine("Ops, você não pode comprar um carro.");}
        
        
       
    }
}