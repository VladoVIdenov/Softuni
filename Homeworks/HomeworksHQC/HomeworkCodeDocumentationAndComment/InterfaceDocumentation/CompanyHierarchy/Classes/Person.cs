namespace CompanyHierarchy.Classes
{
    using System;
    using System.Text;
    using CompanyHierarchy.Interface;

    public abstract class Person : IPerson
    {
        private string id;
        private string firstName;
        private string lastName;

        public Person(string id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string Id
        {
            get
            {
                return this.id;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The ID cannot be null or empty");
                }

                this.id = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The first name cannot be null or empty");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The last name cannot be null or empty");
                }

                this.lastName = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Id: {0} \nName: {1} {2} \n", this.Id, this.FirstName, this.LastName);
            return result.ToString();
        }
    }
}
