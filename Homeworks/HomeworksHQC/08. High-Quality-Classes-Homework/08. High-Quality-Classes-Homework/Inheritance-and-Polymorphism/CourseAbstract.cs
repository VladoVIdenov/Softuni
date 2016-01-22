namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Interfaces;

    public abstract class CourseAbstract : IStudentGettable
    {
        private string courseName;

        private string teacherName;

        private IList<string> students;

        public CourseAbstract(string courseName)
        {
            this.CourseName = courseName;
        }

        public CourseAbstract(string courseName, string teacherName)
            : this(courseName)
        {
            this.TeacherName = teacherName;
        }

        public CourseAbstract(string courseName, string teacherName, IList<string> students)
            : this(courseName, teacherName)
        {
            this.Students = new List<string>();
        }

        public string CourseName
        {
            get
            {
                return this.courseName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Course Name", "The Course name cannot be null empty or whitespace");
                }

                this.courseName = value;
            }
        }

        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Teacher's Name", "The Teacher's name cannot be null empty or whitespace");
                }

                this.teacherName = value;
            }
        }

        public IList<string> Students { get; set; }

        public string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ No Students }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(this.GetType().Name);
            result.Append(" { Name = ");
            result.Append(this.CourseName);
            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());

            return result.ToString();
        }
    }
}
