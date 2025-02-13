using System;

namespace COMP003A.EmployeeManagementSystem
{
	public abstract class Department
	{
		public string DepartmentName { get; protected set; }
		public abstract string GetDepartmentDetails();
		public void DisplayDepartmentInfo()
		{
			Console.WriteLine("Department: " + DepartmentName);
			Console.WriteLine("Details " + GetDepartmentDetails());
		}
	}
}
