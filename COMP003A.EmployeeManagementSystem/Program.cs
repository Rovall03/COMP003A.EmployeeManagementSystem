using System.Security.Authentication;

namespace COMP003A.EmployeeManagementSystem
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string employeeId = "E001";
          
            string firstName = " Alice";
            string middleName = "Marie";
            string lastName = "Johnson";
            double salary =75000;



            Employee employee = new Employee(employeeId, firstName, middleName,lastName,salary);
            employee.DisplayEmployeeInfo(); 
   
       
            Console.WriteLine("Employee Created Successfully!");


       HRDepartment hr =new HRDepartment();
            

            hr.DisplayDepartmentInfo();
            hr.Operate();


ITDepartment it = new ITDepartment();
            it.DisplayDepartmentInfo();
            it.Operate();

        }
    }
}
