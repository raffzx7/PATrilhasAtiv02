using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Insira numero: ");
      
      float n1 = Convert.ToSingle(Console.ReadLine());
      float soma = n1 * 2;
      
      Console.Write("O dobro do numero " + n1);
          Console.Write(" é " + soma);
            Console.ReadKey(true);
    }
    
  }
  
}
