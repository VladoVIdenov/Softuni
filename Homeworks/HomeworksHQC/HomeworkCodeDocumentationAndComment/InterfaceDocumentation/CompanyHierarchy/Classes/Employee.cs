using System;
using System.Text;
using CompanyHierarchy.Interface;

namespace CompanyHierarchy.Classes
{
    public class Employee : Person, IEmployee
    {
        public decimal salary;
        public string department;
        public Employee(string id, string firstName, string lastName, decimal salary, Department department)
            :base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }
        public Department Department { get; }
        

        public decimal Salary
        {
            get { return this.salary; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The Salary cannot be negative");
                }
                this.salary = value;
            }

        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine();
            result.Append(base.ToString());
            result.AppendFormat("Salary: {0} \nDepartment: {1} \n\n", this.Salary, this.Department);
            return result.ToString();
        }
    }
}
