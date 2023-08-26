using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
	internal class LoanCal
	{
		public static void Main()
		{
			Console.Write("Enter The total amount ");
			double Principle = double.Parse(Console.ReadLine());

			Console.Write("Enter the tenure (in years): ");
			double tenure = double.Parse(Console.ReadLine());

			Console.Write("Enter rate of interest (%): ");
			double interestRate = double.Parse(Console.ReadLine());

			// Calculate simple interest
			double simpleInterest = (Principle * interestRate * tenure) / 100;

	
			Console.WriteLine($"Loan Amount: {Principle}");
			Console.WriteLine($"Tenure: {tenure} years");
			Console.WriteLine($"Interest Rate: {interestRate}%");
			Console.WriteLine($"Simple Interest: {simpleInterest}");
			

		}
	}
}










