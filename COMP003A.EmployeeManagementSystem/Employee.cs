using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem
{
    /// <summary>
    /// Represents an employee with properties and methods to manage employee details
    /// </summary>
    public class Employee
    {
        // Private fields
        private string _employeeId;
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private double _salary;

        // Public properties
        public string EmployeeId
        {
            get { return _employeeId; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("First name cannot be empty or null. ");
            }
        }

        public string MiddleName
        {
            get { return _middleName; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Middle name cannot be null");
                _middleName = value;
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Last name cannot be empty or null");
                _lastName = value;
            }
        }

        public double Salary
        {
            get { return _salary; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Salary cannot be less than 0.");
                _salary = value;
            }
        }

        // Constructor
        public Employee(string employeeID, string firstName, string lastName, double salary, string middleName = "")
        {
            _employeeId = employeeID;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            MiddleName = middleName; // Optional
        }

        // Method to print full name
        public void PrintFullName()
        {
            if (string.IsNullOrEmpty(MiddleName))
                Console.WriteLine($"{FirstName} {LastName}");
            else
                Console.WriteLine($"{FirstName} {MiddleName} {LastName}");
        }

        // Method to display employee info
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}");
            PrintFullName();
            Console.WriteLine($"Salary: ${Salary:0,0.00}");
        }
    }
}
