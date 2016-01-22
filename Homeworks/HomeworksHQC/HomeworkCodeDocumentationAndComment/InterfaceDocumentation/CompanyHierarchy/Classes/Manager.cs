using System.Collections.Generic;
using System.Text;
using CompanyHierarchy.Interface;

namespace CompanyHierarchy.Classes
{
    public class Manager : Employee, IManager
    {
        public Manager(string id, string firstName, string lastName, decimal salary, Department department, List<Employee> employees)
            : base(id, firstName, lastName, salary, department)
        {
            this.Employees = employees;
        }

        public List<Employee> Employees { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString());
            foreach (var employ in this.Employees)
            {
                result.AppendLine(employ.ToString());
            }
            return result.ToString();
        }
    }
}
