using System;

class Program
{
    static void Main()
    {
      
        Console.Write("\nDigite seu nome: ");
        string nome = (Console.ReadLine());
          Console.Write("\nDigite sua idade: ");
          int idade = int.Parse(Console.ReadLine());
         Console.Write("\nVocê possui CNH?: ");
         string cnh = (Console.ReadLine());
         bool resposta = Convert.ToBoolean(cnh.Equals("sim", StringComparison.OrdinalIgnoreCase));
         

        
       
        if (idade >= 18 && resposta == true){
             Console.WriteLine("{0}, Você pode dirigir!", nome);
        }
        
        else{
             Console.WriteLine("{0}, Você não pode dirigir!", nome);}
        
        
       
    }
}