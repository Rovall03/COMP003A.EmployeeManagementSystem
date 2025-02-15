using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem
{
    abstract class Department
    {
 /// <summary>
/// gets and sets department name 
/// </summary>
        public string DepartmentName { get; set; }

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
namespace COMP003A.EmployeeManagementSystem
{
    /// <summary>
    /// info for dep
    /// </summary>
    class HRDepartment : Department, IDepartmentOperations
    {
       
        public HRDepartment()
        {
            DepartmentName = "Human Resources";
        }
        public override string GetDepartmentDetails()
        {
            return "Handles employee relations and recruitment.";
        }
       
        public void Operate()
        {
            Console.WriteLine("Performing HR operations...");
        }
    }
}
namespace COMP003A.EmployeeManagementSystem
{
    /// <summary>
    /// info for dep
    /// </summary>
    class ITDepartment : Department , IDepartmentOperations
    {
        public ITDepartment()
        {

            DepartmentName = "IT";
        }
        public override string GetDepartmentDetails()
        {
            return "Manages technical resources and infrastructure. ";
        }
        
        public void Operate()
        {
            Console.WriteLine("Performing IT operations...");
        }
    }
}
namespace COMP003A.EmployeeManagementSystem
{
    /// <summary>
    /// what each dep. does 
    /// </summary>
    interface IDepartmentOperations
    {
        void Operate();
    }
}