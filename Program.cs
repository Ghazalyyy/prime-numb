using System;

namespace PRIME_NUMB1
{
	 class MainClass {

		static bool isPrime(int x)
		{

			if (x == 2) return true;
			if (x == 3) return true;


			for (int i = 2; i < 5; i++)
			{
				if (x % i == 0) return false;

			}
			return true;
		}

		static void Main(string[] args)
		{

			int i = 2;
			while (i <= 100)
			{
				if (isPrime(i))
					Console.Write(i + " ");
				i++;
			}

		}
	}
}
