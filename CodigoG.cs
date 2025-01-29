using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Insira numero: ");
      
      float n1 = Convert.ToSingle(Console.ReadLine());
      
      Console.Write("Insira outro numero ");
      
      float n2 = Convert.ToSingle(Console.ReadLine());
      float resultado = n1 - n2;
      
      Console.Write("A subtração entre os dois numero é " + resultado);
      Console.ReadKey(true);
    }
    
  }
  
}
