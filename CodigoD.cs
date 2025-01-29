using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Insira numero: ");
      
      float n1 = Convert.ToSingle(Console.ReadLine());
      float resultado = n1 * n1;
      ;
      
      Console.Write("o numero " + n1);
          Console.Write(" elevado ao quadrado é " + resultado);
            Console.ReadKey(true);
    }
    
  }
  
}
