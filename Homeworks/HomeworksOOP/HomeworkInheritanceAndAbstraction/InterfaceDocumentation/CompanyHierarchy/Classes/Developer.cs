using System.Collections.Generic;
using System.Text;
using CompanyHierarchy.Interface;

namespace CompanyHierarchy.Classes
{
    public class Developer: RegularEmployee, IDeveloper
    {
        

        public Developer(string id, string firstName, string lastName, decimal salary, Department department, List<Projects> projects)
            :base(id, firstName, lastName, salary, department)
        {
            this.ProjectsList = projects;
        }

        public List<Projects> ProjectsList { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString());
            foreach (var project in ProjectsList)
            {
                result.AppendLine(project.ToString());
            }
            return result.ToString();
        }
    }
}
