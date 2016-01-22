using System;

namespace Problem01Persons
{
    class Problem01Persons
    {
        static void Main()
        {
            
            Console.Write("Please enter a Person Name: ");
            string personName = Console.ReadLine();

            Console.Write("Please enter the ages of Person: ");
            int personAge = int.Parse(Console.ReadLine());
            
            Console.Write("Please enter the email of Person: ");
            string personEmail = Console.ReadLine();

            Person firstPerson = new Person(personName, personAge);
            Person secondPerson = new Person(personName, personAge, personEmail);

            Console.WriteLine(firstPerson.ToString());
            Console.WriteLine(secondPerson.ToString());

            
        }
    }
}
