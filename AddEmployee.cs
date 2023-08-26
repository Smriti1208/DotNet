using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
	internal class AddEmployee
	{
		static void Main(string[] args)
		{
			List<string> employees = new List<string>();

			// Add employees to the list
			employees.Add("Alice");
			employees.Add("Bob");
			employees.Add("Charlie");
			employees.Add("David");

			// Display the names of employees
			Console.WriteLine("List of Employees:");
			foreach (string employee in employees)
			{
				Console.WriteLine(employee);
			}
		}
	}
}






