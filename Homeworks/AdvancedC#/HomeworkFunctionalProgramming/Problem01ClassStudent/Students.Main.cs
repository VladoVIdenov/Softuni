namespace Problem01ClassStudent
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Student pesho = new Student(
                "Asen",
                "Antrov",
                23,
                111114,
                "02-955-888",
                "Peshko@abv.bg",
                new List<int>() { 2, 3, 4, 5, 4, 3 },
                1,
                "Chereshka");
            Student gosho = new Student(
                "Gosho",
                "Goshov",
                65,
                213115,
                "+3592-999-999",
                "Goshko@gmail.com",
                new List<int>() { 3, 4, 4, 6, 5, 5 },
                1,
                "GoT");
            Student john = new Student(
                "John",
                "Snow",
                18,
                111115,
                "+359 2 955 777",
                "JohnSnow@gmail.com",
                new List<int>() { 3, 2, 4, 3, 5, 2 },
                2,
                "GoT");
            Student asq = new Student(
                "Asq",
                "Petrova",
                10,
                213114,
                "0900-143-143",
                "asq@abv.bg",
                new List<int>() { 6, 5, 6, 6, 4, 6 },
                2,
                "Chereshka");

            List<Student> students = new List<Student>() { pesho, gosho, john, asq };
            var studentsGroupTwo = from student in students
                                   where student.GroupNumber == 2
                                   orderby student.FirstName
                                   select student;

            Console.WriteLine("Problem 02: Print Group 2 students ordered by Firstname:\n");

            foreach (var student in studentsGroupTwo)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }

            Console.WriteLine(
                "Problem 03: Print all students whose first name is before their last name alphabetically.\n");

            var sortAlphabeticaly = from student in students
                                    where student.FirstName.CompareTo(student.LastName) < 0
                                    select student;

            foreach (var student in sortAlphabeticaly)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }

            Console.WriteLine(
                "Problem 4: Finds the first name and last name of all students with age between 18 and 24\n");

            var sortByAge = from student in students where student.Age >= 18 && student.Age <= 24 select student;

            foreach (var student in sortByAge)
            {
                Console.WriteLine();
                Console.WriteLine("{0} {1}, Age {2}", student.FirstName, student.LastName, student.Age);
            }

            Console.WriteLine("Problem 05: Sort the students by first name and last name in descending order\n");
            Console.WriteLine("With Lambda expressions\n");
            var sortedWithLambda = students.OrderByDescending(fn => fn.FirstName).ThenByDescending(ln => ln.LastName);

            foreach (var student in sortedWithLambda)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }

            Console.WriteLine("With Query\n");
            var sortWithQuery = from student in students
                                orderby student.FirstName descending, student.LastName descending
                                select student;

            foreach (var student in sortWithQuery)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }

            Console.WriteLine("Problem 06 : Print all students that have email @abv.bg.\n");

            var containAbvEmail = students.Where(s => s.Email.Contains("@abv.bg"));

            foreach (var student in containAbvEmail)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }

            Console.WriteLine(
                "Problem 07 Print all students with phones in Sofia (starting with 02 / +3592 / +359 2).\n");

            var sortByPhone =
                students.Where(
                    s => s.Phone.StartsWith("02") || s.Phone.StartsWith("+3592") || s.Phone.StartsWith("+359 2"));

            foreach (var student in sortByPhone)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }

            Console.WriteLine("Problem 08: Print all students that have at least one mark Excellent (6).\n");

            var excelentStudents = from student in students
                                   where student.Marks.Contains(6)
                                   select new { FirsName = student.FirstName, Mark = student.Marks };

            foreach (var student in excelentStudents)
            {
                Console.WriteLine("{0} {1}", student.FirsName, string.Join(", ", student.Mark));
                Console.WriteLine();
            }

            Console.WriteLine("Extract the students with exactly two marks 2.\n");

            var weakStudents = students.Where(s => s.Marks.Count(m => m == 2) == 2);

            foreach (var student in weakStudents)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }

            Console.WriteLine("Extract and print the Marks of the students that enrolled in 2014\n");

            var enrolled2014 = students.Where(s => s.FacultyNumber.ToString().EndsWith("14"));

            foreach (var student in enrolled2014)
            {
                Console.WriteLine(
                    "{0} {1} Faculty Number {2}\nMarks:{3}",
                    student.FirstName,
                    student.LastName,
                    student.FacultyNumber,
                    string.Join(", ", student.Marks));
                Console.WriteLine();
            }

            Console.WriteLine("Print all group names along with the students in each group\n");

            var sortByGroupName = from student in students
                                  group student by student.GroupName
                                  into g
                                  orderby g.Key
                                  select g;

            foreach (IGrouping<string, Student> groupKeys in sortByGroupName)
            {
                foreach (var student in groupKeys)
                {
                    Console.WriteLine(student.GroupName);
                    Console.WriteLine(student);
                    Console.WriteLine();
                }
            }

            var studSpec = new List<StudentSpecialty>()
                               {
                                   new StudentSpecialty("WordPress", 111114),
                                   new StudentSpecialty("PHP Developer", 213115),
                                   new StudentSpecialty("Java Developer", 111115),
                                   new StudentSpecialty("Web Developer", 213114)
                               };
            var joined = students.Join(
                studSpec,
                stud => stud.FacultyNumber,
                spec => spec.FacultyNumber,
                (stud, spec) =>
                new
                    {
                        Name = stud.FirstName + " " + stud.LastName,
                        Specialty = spec.SpecialtyName,
                        FacultyNm = stud.FacultyNumber
                    });

            foreach (var spec in joined)
            {
                Console.WriteLine("{0} --- {1} --- {2} ", spec.Name, spec.FacultyNm, spec.Specialty);
            }
        }
    }
}
