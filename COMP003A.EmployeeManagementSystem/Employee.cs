using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem {
    public class Employee
    {
            /// <summary>
            /// Gathers everything needed for the employee to be entered into the system.
            /// </summary>
            private string _employeeId;
            private string _firstName;
            private string _middleName = ""; // sets all private strings and double needed relating to the employees
            private string _lastName;
            private double _salary;

            public string EmployeeId => _employeeId; //The safety net Employee ID is used for this section
            /// <summary>
            /// The rest do the same thing of setting the values to new public values
            /// </summary>
            public string MiddleName 
            {
                get => _middleName;
                set
                {
                    _middleName = value ?? ""; //the middle name is either null or blank
                }
            }
            public string LastName
            {
                get => _lastName; //gets the private last name variable
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException("Last name CANNOT be BLANK or EMPTY."); //if it is  null
                    }

                    _lastName = value; //if not null set it to the given value
                }
            }
        public string FirstName
        {
            get => _firstName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("First name CANNOT be EMPTY. Try AGAIN. "); //same as above
                }

                _firstName = value;
            }
        }
        public double Salary
            {
                get => _salary;
                set
                {
                    if (value < 0) 
                    {
                        throw new ArgumentException("SALARY CANNOT BE LESS THAN 0 THAT IS CRIMINAL!"); // it is criminal just like getting a 9.9/10 on an assignmnet
                    }
                    _salary = value;
                }
            }

            /// <summary>
            /// this is the constructor for the employee class which takes in the 5 variables
            /// </summary>
            /// <param name="employeeId"></param>
            /// <param name="firstName"></param>
            /// <param name="lastName"></param>
            /// <param name="salary"></param>
            /// <param name="middleName"></param>
            public Employee(string employeeId, string firstName, string lastName, double salary, string middleName = "")
            {

                _employeeId = employeeId;
                FirstName = firstName;
                MiddleName = middleName;
                LastName = lastName;
                Salary = salary;

            }

            /// <summary>
            /// does what you think it does, prints the full name
            /// </summary>
            public void PrintFullName()
            {
                if (string.IsNullOrWhiteSpace(MiddleName))
                {
                    Console.WriteLine(FirstName + " " + LastName); // if there is white space or just a blank variable
                }
                else
                {
                    Console.Write(FirstName + " " + MiddleName + " " + LastName); // if there isnt a blank value
                }
            }
        /// <summary>
        /// displays the information given to the employee that the user types in.
        /// </summary>
            public void DisplayEmployeeInformation()
            {
                Console.WriteLine("Employee ID: " + _employeeId);
                Console.Write("Name: ");
                PrintFullName();
                Console.WriteLine("\nSalary Given: $" + Salary);
            }

        
    }
}
