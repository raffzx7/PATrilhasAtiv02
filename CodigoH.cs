using System;

namespace att01
{
	class Program
	{
		public static void Main()
		{	
			Console.Write("Insira um numero: ");
			
			float numero = Convert.ToSingle(Console.ReadLine());
			float absoluto = Convert.ToSingle(Math.Abs(numero));
			
			Console.Write("O valor absoluto do numero " + numero);
			  Console.Write(" é: " + absoluto);
			    Console.ReadKey(true);
		}
    
	}
  
}
