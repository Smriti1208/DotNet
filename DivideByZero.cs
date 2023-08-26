using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
	internal class DivideByZero
	{

		static int Divide(int dividend, int divisor)
		{
			return dividend / divisor; 
		}
		public static void Main(string[] args)
		{
			try
			{
				Console.Write("Enter a number:");
				int dividend = int.Parse(Console.ReadLine());

				Console.Write("Enter a number: ");
				int divisor = int.Parse(Console.ReadLine());

				int result = Divide(dividend, divisor);
				Console.WriteLine($"Result of division: {result}");
			}
			catch (DivideByZeroException ex)
			{
				Console.WriteLine("Error: " + ex.Message);
			}
			catch (FormatException ex)
			{
				Console.WriteLine("Error: Invalid input format.");
			}
			
		}
	}

}

