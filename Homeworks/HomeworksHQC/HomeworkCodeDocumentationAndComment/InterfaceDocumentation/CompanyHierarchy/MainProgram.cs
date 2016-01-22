using System;
using System.Collections.Generic;
using CompanyHierarchy.Classes;

namespace CompanyHierarchy
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Projects firstProject = new Projects("Financial calculator", DateTime.Parse("25.01.2014"), "Have no idea", "Open");
            Projects secondProject = new Projects("Financial calculator2", DateTime.Parse("25.01.2014"), "Still have no idea", "Open");
            Projects thirdProject = new Projects("Financial calculator3", DateTime.Parse("25.01.2014"), "And still have no idea", "Open");

            firstProject.CloseProject();
            secondProject.CloseProject();

            Manager theLittleBoss = new Manager("445aa", "Ivan", "Ddragichev", 5000m, Department.Sales, new List<Employee>
            {
                 new Employee("123ab", "Andrei", "Ivanov", 1500m, Department.Production),
                 new Employee("123ab", "Sasho", "Milikin", 1500m, Department.Accoiunting),
                 new Employee("123ab", "Dimitur", "Grigorov", 1500m, Department.Marketing),
            });
            Developer firstDeveleoper = new Developer("123ab", "Andrei", "Ivanov", 1500m, Department.Accoiunting, new List<Projects>
            {
                firstProject,
                secondProject,
                thirdProject,
            });
            Sales firstSale = new Sales("Banichka", 0.85m, DateTime.Parse("05.11.2015"));
            Sales secondSale = new Sales("Boza", 1m, DateTime.Parse("05.11.2015"));
            Sales thirdSale = new Sales("Mineralna Voda", 1.5m, DateTime.Parse(DateTime.Now.ToString()));

            SalesEmployee SaleExpertOne = new SalesEmployee("123ab", "Andrei", "Ivanov", 1500m, Department.Production, new List<Sales>
            {
                firstSale,
                secondSale,
                thirdSale
            });
            SalesEmployee SalerOne = new SalesEmployee("123ab", "Dimitur", "Grigorov", 1500m, Department.Marketing, new List<Sales>
            {
                new Sales("Military Software", 60000000000m, DateTime.Parse("12.09.2015")) ,
                new Sales("Security Software", 80055.99m, DateTime.Parse("12.09.2015")) ,
                new Sales("Decoding Software", 9999.99m, DateTime.Parse("01.04.2005")) ,
            });
            List<Employee> employees = new List<Employee>();
            employees.Add(theLittleBoss);
            employees.Add(firstDeveleoper);
            employees.Add(SaleExpertOne);
            employees.Add(SalerOne);

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }

            Customer Hero = new Customer("1111aa", "Hero", "Geroichev");
            
            Hero.AddToPurchaseAmount(firstSale.Price);
            Hero.AddToPurchaseAmount(secondSale.Price);
            Console.WriteLine(Hero.ToString());
        }    
    }
}
