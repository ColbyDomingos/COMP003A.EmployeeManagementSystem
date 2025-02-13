using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem {
	/// <summary>
	/// Sets the class and passses through the class Department and the operate method
	/// </summary>
	public class HRDepartment : Department, IDepartmentOperations
	{
		public HRDepartment() //gives the department name
		{
			DepartmentName = "Human Resources";
		}

		public override string GetDepartmentDetails() //gives the details that override the string in the Department Class
		{
			return "Handles Employee recruitment and their respective relationships.";
		}

		public void Operate() //Sets the operate method to the Console.WriteLine set here
		{
			Console.WriteLine("Performing the respective operations...");
		}
	}
}
