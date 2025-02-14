
// Author: Rosa Ovalle
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Employee management system demonstrating OOP principles in C#
namespace COMP003A.EmployeeManagementSystem
{
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

        public string FirstName
        {
            get { return _firstName; }
            set { if (String.IsNullOrWhiteSpace(value))
                    _firstName = value; }

        }

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

        public string LastName
        {
            get { return _lastName; }
            set {
                if (String.IsNullOrEmpty(value))
                    _lastName = value; }
        }

        public double Salary
        {
            get { return _salary; }
            set { if (value < 0)
                    throw new ArgumentException("can be less than 0");
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
        public void PrintFullName()
        {
            Console.WriteLine($"{FirstName}, {MiddleName},{LastName}");
            if (string.IsNullOrEmpty(MiddleName)) Console.WriteLine($"{FirstName},{LastName}");
        }
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


