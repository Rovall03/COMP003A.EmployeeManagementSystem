﻿using System.Diagnostics.Metrics;
using System.Security.Authentication;

namespace COMP003A.EmployeeManagementSystem
{
    internal class Program
    {

        static void Main(string[] args)
        {

            string employeeId;
            string firstName;
            string middleName;
            string lastName;
            double salary;

            Console.Write("Enter Employee ID: ");
             employeeId = Console.ReadLine();
            Console.Write("Enter First Name: ");
            firstName = Console.ReadLine();

            Console.Write("Enter Middle Name (Press Enter to skip): ");
            middleName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            lastName = Console.ReadLine();

            Console.Write("Enter Salary: ");
            salary = double.Parse(Console.ReadLine());



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
