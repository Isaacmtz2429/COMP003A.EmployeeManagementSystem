using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem
{
    /// <summary>
    /// Abstract class representing a department
    /// </summary>
    public abstract class Department
    {
        public string DepartmentName { get; set; }

        public Department(string departmentName)
        {
            DepartmentName = departmentName;
        }

        /// <summary>
        /// Abstract method to get department details
        /// </summary>
        /// <returns>Department details as a string.</returns>
        public abstract string GetDepartmentDetails();

        /// <summary>
        /// Display department information.
        /// </summary>
        public void DisplayDepartmentInfo()
        {
            Console.WriteLine($"Department: {DepartmentName}");
        }
    }

    /// <summary>
    /// Inferface for department operations.
    /// </summary>
    public interface IDepartmenOperations
    {
        /// <summary>
        /// Operate method to perform department-specific operations
        /// </summary>
        void Operate();
    }

    /// <summary>
    /// Hr Department class inheriting from Department and implementing IDepartmentOperations
    /// </summary>
    public class HRDepartment : Department, IDepartmenOperations
    {
        public HRDepartment(string departmentName) : base(departmentName) { }

        /// <summary>
        /// Gets HR department details
        /// </summary>
        /// <returns>HR department details as a string.</returns>
        public override string GetDepartmentDetails()
        {
            return "Handles employee relations and recruitment.";
        }

        /// <summary>
        /// Performs HR department operations.
        /// </summary>
        public void Operate()
        {
            Console.WriteLine("Performing HR operations...");
        }
    }

    /// <summary>
    /// IT department class inheriting from department and implementing IDpartmentOperations.
    /// </summary>
    public class ITDepartment : Department, IDepartmentOperations
    {
        public ITDepartment(string departmentName) : base(departmentName) { }

        /// <summary>
        /// Get IT department details.
        /// </summary>
        public override string GetDepartmentDetails()
        {
            return "Manages technical resources and infrastructure.";
        }

        /// <summary>
        /// Performs IT department operations.
        /// </summary>
        public void Operate()
        {
            Console.WriteLine("Performing IT operatoins...");
        }
    }
}
