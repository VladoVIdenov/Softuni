using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Interface;
namespace CompanyHierarchy
{
    public class Projects: IProjects
    {
        private const string state = "Open";
        private string name;
        private DateTime startDate;
        private string details;

        public string State { get; private set; }
        

        public Projects(string name, DateTime startDate, string details , string state)
        {
            this.State = state;
            this.Name = name;
            this.StartDate = startDate;
            this.Details = details;
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The name cannot be null or empty");
                }
                this.name = value;
            }
        }

        public DateTime StartDate
        {
            get { return this.startDate; }
            set
            {
                if (value.Year < 1960)
                {
                    throw new ArgumentOutOfRangeException("The date cannot be under 1960");
                }
                this.startDate = value;
            }
        }

        public string Details
        {
            get { return this.details; }

            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("There must be some details about the project");
                }
                this.details = value;
            }
        }

        public void CloseProject()
        {
            this.State = "Closed";
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Project name: {0} \nStart date: {1:dd.MM.yyyy} \nDetails: {2} \nProject state: {3}\n\n",
                this.Name, this.StartDate.Date, this.Details, this.State);
            return result.ToString();
        }
    }
}
