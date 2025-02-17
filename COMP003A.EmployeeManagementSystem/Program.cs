using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Security.Authentication;

namespace COMP003A.EmployeeManagementSystem
{
    internal class Program
    {

        static void Main(string[] args)
        {
                /// <summary>
                ///menu to add employee 
                /// </summary>
                string employeeId;
                string firstName;
                string middleName;
                string lastName;
                double salary;

                Console.Write("Enter Employee ID: ");
                employeeId = Console.ReadLine();


            try
            {


                Console.Write("Enter First Name: ");
                firstName = Console.ReadLine();
                if (string.IsNullOrEmpty(firstName))
                {
                    throw new ArgumentException("First name cannot be empty. Please try again.");

                }
            }
           


            catch (ArgumentException ex)
            {


                Console.WriteLine($"Error:{ex.Message}");
                return;
            }





            

                Console.Write("Enter Middle Name (Press Enter to skip): ");
                middleName = Console.ReadLine();
              
                    





            try { 
                Console.Write("Enter Last Name: ");
                lastName = Console.ReadLine();
            if (string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentException("Last name cannot be empty. Please try again.");

            }
        }
           


            catch (ArgumentException ex)
            {


                Console.WriteLine($"Error:{ex.Message}");
                return;
            }

            try { 

    Console.Write("Enter Salary: ");
                salary = double.Parse(Console.ReadLine());
            if(salary < 0)
                    
                    {
                        throw new ArgumentException("Salary can not be 0. Please try again.");

                    }
            }



            catch (ArgumentException ex)
            {


                Console.WriteLine($"Error:{ex.Message}");
                return;
            }






            Employee employee = new Employee(employeeId, firstName, middleName, lastName, salary);

                employee.DisplayEmployeeInfo();
                Console.WriteLine("Employee Created Successfully!");

                /// <summary>
                ///display dep info
                /// </summary>
                HRDepartment hr = new HRDepartment();
                hr.DisplayDepartmentInfo();
                hr.Operate();

                /// <summary>
                ///display dep info
                /// </summary>
                ITDepartment it = new ITDepartment();
                it.DisplayDepartmentInfo();
                it.Operate();
            }

            } }
    
