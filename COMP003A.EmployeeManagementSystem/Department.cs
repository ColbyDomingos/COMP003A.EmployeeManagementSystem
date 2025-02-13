using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public abstract class Department
{
	/// <summary>
	/// gets the name of the Department and sets the department to which ever department is referenced
	/// </summary>
	public string DepartmentName {  get; protected set; }

	public abstract string GetDepartmentDetails(); //gets the department details from the 2 departments

	/// <summary>
	/// Literally just displays what it gets from the other departments
	/// </summary>
	public void DisplayDepartmentInformation()
	{
		Console.WriteLine("\nDepartment: " + DepartmentName); 
		Console.WriteLine("Details " + GetDepartmentDetails());
	}
}
