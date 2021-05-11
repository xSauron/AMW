using System;

namespace Implementacja_Programu_1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Podaj N = ");
			int N = Convert.ToInt32(Console.ReadLine());
			Console.Write("Podaj a = ");
			int a = Convert.ToInt32(Console.ReadLine());
			N = N - 1;
			int minimalna = a;

			do
			{
				Console.Write("Podaj a = ");
				a = Convert.ToInt32(Console.ReadLine());
				if (a < minimalna)
				{
					minimalna = a;
				}
				N = N - 1;
			} while (N > 0);

			Console.WriteLine("Minimalna liczba = " + minimalna);
			Console.WriteLine("Kliknij dowolny klawicz aby zamknąć!");
			Console.ReadKey();
		}
	}
}
