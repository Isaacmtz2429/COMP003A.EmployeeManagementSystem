/*
// Author: Isaac Martinez
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Employee management system demonstrating OOP principles in C#
*/
namespace COMP003A.EmployeeManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // List to hold emplyee records
                List<Employee> employees = new List<Employee>();

                // Adding an employee with user input
                Console.WriteLine("Enter Employee ID:");
                string employeeId = Console.ReadLine();
                Console.WriteLine("Enter First Name:");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter Middle Name (Press Enter to Skip);");
                string middleName = Console.ReadLine();
                Console.WriteLine("Enter Last Name:");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter Salary:");
                double salary = double.Parse(Console.ReadLine());

                // Add the new employee to the list
                employees.Add(new Employee(employeeId, firstName, lastName, salary, middleName));\

                Console.WriteLine("\nEmployee Created Successfully!\n");

                // Display employee information
                foreach (var employee in employees)
                {
                    employee.DisplayEmployeeInfo();
                }

                //
            }
        }
    }
}
