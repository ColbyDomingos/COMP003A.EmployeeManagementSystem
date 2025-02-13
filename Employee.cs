using System;
using System.Collections.generic;
using System.Linq
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem {
    public class Employee
    {
        class Employee
        {
            private string _employeeId;
            private string _firstName;
            private string _middleName = ""; // sets all private strings and double needed relating to the employees
            private string _lastName;
            private double _salary;

            public string EmployeeId = _employeeId;
            public string FirstName
            {
                get => _firstName;
                set
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentException("First name CANNOT be EMPTY. try AGAIN. ");
                    }

                    _firstName = value;
                }
            }
            public string MiddleName
            {
                get => _middleName;
                set
                {
                    _middleName = value ?? "";
                }
            }
            public string LastName
            {
                get => _lastName;
                set
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentException("Last name CANNOT be BLANK or EMPTY.");
                    }
                }
            }
            public double Salary
            {
                get => _salary;
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("SALARY CANNOT BE LESS THAN 0 THAT IS CRIMINAL!");
                    }
                    _salary = value;
                }
            }

            public Employee(string employeeId, string firstName, string middleName = "", string lastName, double salary)
            {
                _employeeId = employeeId;
                FirstName = firstName;
                MiddleName = middleName;
                LastName = lastName;
                Salary = salary;


            }

            public void PrintFullName()
            {
                if (string.IsNullOrWhiteSpace(MiddleName))
                {
                    Console.WriteLine(FirstName + " " + LastName);
                }
                else
                {
                    Console.Write(FirstName + " " + MiddleName + " " + LastName);
                }
            }
            public void DisplayEmployeeInformation()
            {
                Console.WriteLine("Employee Id: " + _employeeId);
                Console.Write("Name: ");
                    PrintFullName();
                Console.WriteLine("Salary Given: $" + Salary + " Givn to:  " + FirstName);
            }

        }
    }
}
