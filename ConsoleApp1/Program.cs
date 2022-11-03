using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("請輸入時間:");
			string input = Console.ReadLine();
			DateTime intputday = Convert.ToDateTime(input);
			Console.WriteLine(intputday);
			switch (intputday.DayOfWeek)
			{
				case DayOfWeek.Sunday:
				case DayOfWeek.Saturday:
					Console.WriteLine("今天是禮拜六,不是交易日");
					break;
				default:

					if (intputday.Hour < 9)
					{
						Console.WriteLine("現在不是交易時間");
					}
					else if (intputday.Hour > 13)
					{
						Console.WriteLine("現在不是交易時間");
					}
					else if (intputday.Hour >= 13 && intputday.Minute >= 30)
					{
						Console.WriteLine("現在不是交易時間");
					}
					else { Console.WriteLine("現在是交易時間"); }

					break;
			}
		}
	}
}
