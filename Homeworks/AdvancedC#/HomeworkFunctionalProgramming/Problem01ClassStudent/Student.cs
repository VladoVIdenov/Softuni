namespace Problem01ClassStudent
{
    using System.Collections.Generic;
    using System.Text;

    public class Student
    {
        private string groupName;
        public Student(
            string firstName,
            string lastName,
            int age,
            int facultyNumber,
            string phone,
            string email,
            List<int> marks,
            int groupNumber,
            string groupName = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
            this.GroupName = groupName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public int FacultyNumber { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public List<int> Marks { get; set; }

        public int GroupNumber { get; set; }

        public string GroupName { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            string marks = string.Join(" ", this.Marks);
            result.AppendFormat(
                "Student: {0} {1}, age: {2}. \nFckNumber: {3}, Phone: {4}, Email: {5}\nMarks: {6} \nGroup Number {7}",
                this.FirstName,
                this.LastName,
                this.Age,
                this.FacultyNumber,
                this.Phone,
                this.Email,
                marks,
                this.GroupNumber);
            return result.ToString();
        }
    }
}
