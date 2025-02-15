using System.Security.Authentication;

namespace COMP003A.EmployeeManagementSystem
{
    internal class Program
    {

        static void Main(string[] args)
        {
           
   
       
       HRDepartment hr =new HRDepartment();
            ITDepartment it = new ITDepartment();

            hr.DisplayDepartmentInfo();
            hr.Operate();
            it.DisplayDepartmentInfo();
            it.Operate();

        }
    }
}
