using System;

namespace COMP003A.EmployeeManagementSystem {
	public class HRDepartment : HRDepartment, IDepartmentOperations
	{
		public HRDepartment()
		{
			DepartmentName = "Human Resources";
		}

		public override string GetDepartmentDetails()
		{
			return "Handles Employee recruitment and their respective relationships.";
		}

		public void Operate()
		{
			Console.WriteLine("Performing the respective operations...")
		}
	}
}
