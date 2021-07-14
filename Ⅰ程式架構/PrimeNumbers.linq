<Query Kind="Program" />

using System;
using System.Collections;
using System.Diagnostics;

namespace Test
{
	class Test
	{
		public static void Main()
		{
			new Test();
		}
		
		private Test()
		{
			Stopwatch sw = new Stopwatch();
			List<int> primes = new List<int>();
			
			Console.WriteLine("Welcome to PRIMEWORLD.");
			while(true)
			{
				int count = 0;
				Console.WriteLine("please enter counts of prime numbers,\nZERO for exit hte program.");
				count = Convert.ToInt32(Console.ReadLine());
				if(count==0) break;
				sw.Restart();
				
				for(int i=primes.LastOrDefault()+1; primes.Count<count; i++)
				{
					int j;
					for(j=2; j<=i; j++)
					{
						if(i%j == 0) break;
					}
					if(j==i) primes.Add(j);
				}
				
				foreach(int e in primes.Take(count))
				{
					Console.Write(e+", ");
				}
				Console.WriteLine("\n\n");
				sw.Stop();
				Console.WriteLine("Program span : "+sw.Elapsed);
				Console.WriteLine();
			}
		}
	}
}