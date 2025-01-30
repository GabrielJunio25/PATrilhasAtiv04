using System;

class Program
{
    static void Main()
    {
      
        Console.Write("Digite seu nome: " );
        string nome = (Console.ReadLine());
          bool acesso = Convert.ToBoolean(nome.Equals("wilson", StringComparison.OrdinalIgnoreCase) ||
                                       nome.Equals("gloria", StringComparison.OrdinalIgnoreCase));
        if (acesso == true){
             Console.WriteLine("Acceso permitido");
           }
        else{
              Console.WriteLine("Acesso negado");
           }
     
        
       
    }
}