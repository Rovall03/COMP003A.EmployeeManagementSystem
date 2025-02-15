
// Author: Rosa Ovalle
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Employee management system demonstrating OOP principles in C#
using System.Linq.Expressions;
using System.Xml.Linq;

namespace COMP003A.EmployeeManagementSystem
{
    /// <summary>
    /// methode for entering employee and details 
    /// </summary>
    internal class Employee
    {


        private readonly string _employeeId;
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private double _salary;

        public string EmployeeId
        {
            get { return _employeeId; }       
        }
        /// <summary>
        /// Gets or sets the first name . must have an input 
        /// </summary>
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                 

            throw new ArgumentException("First name cannot be empty. Please try again.");

                _firstName = value; }

        }
        /// <summary>
        /// Gets or sets the middle name . can be empty
        /// </summary>
        public string MiddleName
        {
            get { return _middleName; }
            set
            {
                if (value == null)
                {
                    _middleName = string.Empty;
                }
            }
        }
        /// <summary>
        /// Gets or sets the last name . must have an input 
        /// </summary>
        public string LastName
        {
            get { return _lastName; }
            set {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Last name cannot be empty. Please try again.");
                _lastName = value; }
        }
        /// <summary>
        /// Gets or sets the salary. The value cannot be less than 0.
        /// </summary>
        public double Salary
        {
            get { return _salary; }
            set { if (value < 0)
                    throw new ArgumentException("cant be less than 0");
                    _salary = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="EmployeeId"></param>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <param name="Salary"></param>

        public Employee(string employeeId, string firstName, string middleName, string lastName, double salary)
        {
            _employeeId = employeeId;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Salary = salary;

        }
      /// <summary>
      /// name of emplyee displayed 
      /// </summary>
        public void PrintFullName()
        {
           
            if (string.IsNullOrEmpty(MiddleName)) Console.WriteLine($"{FirstName},{LastName}");
        else Console.WriteLine($"{FirstName}, {MiddleName},{LastName}");

        }
        /// <summary>
        /// displays full name and diplays info
        /// </summary>
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee ID: {EmployeeId} " );
            Console.WriteLine($"First Name: {FirstName}");
            Console.WriteLine($" Middle Name: {MiddleName}" );
            Console.WriteLine($"Last Name:  {LastName}");
            Console.WriteLine($" Salary: {Salary}");
            }
      
    }
}


