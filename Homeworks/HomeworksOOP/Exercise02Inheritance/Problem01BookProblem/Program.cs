using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01BookProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Book firstBook = new Book("Pod Igoto", "Ivan Vazov",10.00);
            Console.WriteLine(firstBook.Price);

            GoldEditionBook GoldEdition = new GoldEditionBook("Tutun", "Dimitur Dimov", 10.00);
            Console.WriteLine(GoldEdition.Price);
        }
    }
}
