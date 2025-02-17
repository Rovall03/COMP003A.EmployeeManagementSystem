using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem
{
    /// <summary>
    /// info for dep
    /// </summary>
    class ITDepartment : Department, IDepartmentOperations
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