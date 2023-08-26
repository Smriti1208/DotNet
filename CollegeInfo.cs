using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
	class CollegeInfo
	{

		public static void CollegeDet()
		{
			// Get user information
			Console.Write("Enter your name: ");
			string userName = Console.ReadLine();

			// Get college information
			Console.Write("Enter college name: ");
			string collegeName = Console.ReadLine();

			Console.Write("Enter college strength: ");
			int collegeStrength = int.Parse(Console.ReadLine());

			// Display the collected information
			Console.WriteLine("\nUser Information:");
			Console.WriteLine($"Name: {userName}");

			Console.WriteLine($"College Name: {collegeName}");
			Console.WriteLine($"College Strength: {collegeStrength}");


		}
		static void Main()
		{
			CollegeDet();
			Console.WriteLine("\nThank you for providing your information!");
		}
	}
}
