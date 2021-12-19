using System;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
			int num;
			Console.WriteLine("Eeded daxil edin");
			num = Console.Read();
			int result = 0;
		
		if (num <= 0)
		{
			Console.WriteLine("Musbet eded daxil edin.");
		}
		else if (num == 1)
		{
			Console.WriteLine(num + " Sade ve murekkeb eded deyil .");
		}
		else
		{
			for (int i = 1; i <= num; i++)
			{
				if(num % i == 0)
				{
					result++;
				}
			}
			
			if (result > 2)
			{
				Console.WriteLine(num + " Murekkeb ededdir.");
			}
			else
			{
				Console.WriteLine(num + " Sade ededdir.");
                    Console.ReadKey();
			}
		}
        }
    }
}
