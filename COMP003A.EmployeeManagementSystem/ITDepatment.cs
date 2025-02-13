using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem
{
	/// <summary>
	/// Set the ITDepartment class and make it and pass through the department class
	/// </summary>
	public class ITDepartment : Department, IDepartmentOperations
	{
		public ITDepartment()
		{
			DepartmentName = "IT"; //its short term name is IT

		}
		/// <summary>
		/// ovverides the string in GetDepartmentDetails to set the department details for the selected department
		/// </summary>
		/// <returns></returns>
		public override string GetDepartmentDetails()
		{
			return "Manages the technology used at the company.";
		}
		/// <summary>
		/// Sets the operate function to what the it department is doing
		/// </summary>
		public void Operate()
		{
			Console.WriteLine("Doing IT things...");
		}
	}
}
