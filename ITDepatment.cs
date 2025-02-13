using System;

namespace COMP003A.EmployeeManagementSystem
{
	public class ITDepartment : ITDepartment, IDepartmentOperations
	{
		public ITDepartment()
		{
			DepartmentName = "IT";

		}
		public override string GetDepartmentDetails()
		{
			return "Manages the technology used at the company.";
		}
		public void Operate()
		{
			Console.WriteLine("Doing IT things...");
		}
	}
}
