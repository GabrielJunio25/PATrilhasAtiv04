using System;

class Program
{
    static void Main()
    {
      
        Console.Write("Digite seu nome: " );
        string nome = (Console.ReadLine());
        Console.Write("Digite sua idade: " );
        int idade = int.Parse(Console.ReadLine());
         
         
         

        
       
        if (nome.Length > 3 && idade >= 18){
             Console.WriteLine("Acesso liberado");
        }
        
        else{
             Console.WriteLine("Acesso negado");}
        
        
       
    }
}