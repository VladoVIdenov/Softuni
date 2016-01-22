using System;

namespace Problem01Persons
{
    public class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person(string name, int age, string email)
            : this(name, age)
        {
            
            this.Email = email;
            
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The Name can't be null");
                }
                value = value.Trim();

                if (value == "")
                {
                    throw new ArgumentException("The Name can't be null or empty ");
                }

                this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Please enter a valid number of ages in range [ 1 ... 100] ");
                }

                this.age = value;

            }
        }
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("no email");
                }
                else if (!value.Contains("@") )
                {
                    throw new Exception("Please enter a valid Email");
                }
                this.email = value;
            }
        }

        public override string ToString()
        {
            string outputString = "The Person's name is " + this.name + ", age " + this.age;
            if (!string.IsNullOrWhiteSpace(this.email))
            {
                outputString += "and email: " + this.email;
            }
            return outputString;

        }
    }
}
