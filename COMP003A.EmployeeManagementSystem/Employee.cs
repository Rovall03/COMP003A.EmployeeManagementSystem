

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
            set { if (String.IsNullOrEmpty(value))
                    _firstName = value; }

        }

        public string MiddleName
        {
            get { return _middleName; }
            set { _middleName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public double Salary
        {
            get { return _salary; }
            set { if (value < 0)
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
        public void Displayinfo()
            {
            Console.WriteLine($"{EmployeeId} {FirstName}{MiddleName}{LastName}{Salary}");
            }
      
    }
}


