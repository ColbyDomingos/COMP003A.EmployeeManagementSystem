// Author: Colby D
// Course: COMP-003A
// Faculty: Jonathan Rodrigo Cruz
// Purpose: Employee management system demonstrating OOP principles in C#

namespace COMP003A.EmployeeManagementSystem
{
    /// <summary>
    /// Sets the Department Operations and plays the operate method
    /// </summary>
    interface IDepartmentOperations
    {
        void Operate();
    }

    internal class Program
    {
        /// <summary>
        /// This just connects all of the other classes and takes in all the info for the employees and displays it.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter your employee's ID: ");
                string id = Console.ReadLine();

                Console.WriteLine("Enter their First Name: ");
                string firstName = Console.ReadLine();

                Console.WriteLine("Enter their middle name (Press enter to skip): ");
                string middleName = Console.ReadLine();

                Console.WriteLine("Enter thir Last Name: ");
                string lastName = Console.ReadLine();

                Console.WriteLine("Enter their salary: ");
                double salary = double.Parse(Console.ReadLine());

                Employee emp = new Employee(id, firstName, lastName, salary, middleName); //gets all the variables and sets them into the employee constructor
                Console.WriteLine("\nEmployee successfuly imputted! They will serve for life...\n");

                emp.DisplayEmployeeInformation(); //in the Employee class it displays the information from that method

                HRDepartment hr = new HRDepartment(); //sets the name of the class HRDepartment
                ITDepartment it = new ITDepartment(); //sets the name of the class ITDepartment

                hr.DisplayDepartmentInformation();
                hr.Operate(); //Puts the info from the HR Department into the department class

                it.DisplayDepartmentInformation();
                it.Operate(); //Puts the info from the IT Department into the department class
            }
            catch (FormatException) //catches the format exception if there is one
            {
                Console.WriteLine("SALARY INCORRECT! GET THE CORRECT SALARY!");

            }
            catch (ArgumentException ex) //catches argument exception and gives the message of the error
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}