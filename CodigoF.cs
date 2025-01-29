using System;

	class Program
	{
		public static void Main()
		{	
			Console.Write("Insira um numero: ");
			
			float numero = Convert.ToSingle(Console.ReadLine());
			float raiz_quadrada = Convert.ToSingle(Math.Sqrt(numero));
			
			Console.Write("A raiz quadrada do numero: " + numero);
				Console.Write(" é: " + raiz_quadrada);
					Console.ReadKey(true);		
		}
	}
