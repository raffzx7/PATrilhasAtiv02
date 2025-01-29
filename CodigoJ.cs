using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Insira numero: ");
      
      float n1 = Convert.ToSingle(Console.ReadLine());
      
      float resultado = 2 / n1;
      
      Console.Write("A divisão entre o numero 2 e " + n1);
       Console.Write(" é: " + resultado);
      Console.ReadKey(true);
    }
    
  }
  
}
