namespace Methods
{
    using System;

    public class Student
    {
        private string firstName;

        private string lastName;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("First Name", "The First name cannot be null, empty or whitespace");
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
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Last Name", "The First name cannot be null, empty or whitespace");
                }

                this.lastName = value;
            }
        }

        public string OtherInfo { get; set; }

        public bool IsOlderThan(Student other)
        {
            try
            {
                DateTime firstDate =
                DateTime.Parse(this.OtherInfo.Substring(this.OtherInfo.Length - 10));
                DateTime secondDate =
                    DateTime.Parse(other.OtherInfo.Substring(other.OtherInfo.Length - 10));

                return firstDate > secondDate;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return false;
        }
    }
}
