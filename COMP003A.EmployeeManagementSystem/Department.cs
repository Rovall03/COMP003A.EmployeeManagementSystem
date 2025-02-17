// Author: Rosa Ovalle
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Employee management system demonstrating OOP principles in C#
namespace COMP003A.EmployeeManagementSystem
{
    abstract class Department
    {
 /// <summary>
/// gets and sets department name 
/// </summary>
        public string DepartmentName { get; set; }
        /// <summary>
        /// detais of each dept
        /// </summary>
        /// <returns> string detais of each dept.GetDepartmentDetails(); </returns>
        public abstract string GetDepartmentDetails();
        /// <summary>
        /// dispalys info for department
        /// </summary>
        public void DisplayDepartmentInfo()
        {
            Console.WriteLine($"Department Name: {DepartmentName}");
            Console.WriteLine($"Details:{GetDepartmentDetails()}");
        }
    }
}


