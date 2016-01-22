using System.Collections.Generic;
using System.Text;
using CompanyHierarchy.Interface;

namespace CompanyHierarchy.Classes
{
    public class SalesEmployee :Employee, ISalesEmployee
    {
        public SalesEmployee(string id, string fisrtName, string lastName, decimal salary, Department department, List<Sales> sales)
            :base(id, fisrtName, lastName, salary, department)
        {
            this.Sales = sales;
        }

        public List<Sales> Sales { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString());
            foreach (var sale in Sales)
            {
                result.AppendLine(sale.ToString());
            }
            return result.ToString();
        }

    }
}
