using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
	internal class SquareRoot
	{

		static void CalculateSquare(ref double input, ref double result)
		{
			result = input * input;
		}

		static void CalculateSquareRoot(ref double input, ref double result)
		{
			result = Math.Sqrt(input);
		}
		static void Main(string[] args)
		{
			Console.Write("Enter a number: ");
			double number = double.Parse(Console.ReadLine());

			
			double squareResult = 0;
			CalculateSquare(ref number, ref squareResult);
			Console.WriteLine($"Square of the number: {squareResult}");

			
			double squareRootResult = 0;
			CalculateSquareRoot(ref number, ref squareRootResult);
			Console.WriteLine($"Square root of the number: {squareRootResult}");
		}
	}
}


