using System.Diagnostics.Metrics;
using System.Security.Authentication;

namespace COMP003A.EmployeeManagementSystem
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee ID: ");
            string employeeId = Console.ReadLine();
            Console.WriteLine("Enter First Name: ");
string firstName = Console.ReadLine();

            Console.WriteLine("Enter Middle Name (Press Enter to skip): ");
            string middleName = Console.ReadLine();

            Console.WriteLine("Enter Last Name: ");
string lastName = Console.ReadLine();

            Console.WriteLine("Enter Salary: ");
            
          
            
            
            double salary = double.Parse(Console.ReadLine());



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
