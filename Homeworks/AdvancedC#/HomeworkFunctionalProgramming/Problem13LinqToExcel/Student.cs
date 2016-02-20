namespace Problem13LinqToExcel
{
    using System.Text;

    public class Student
    {
        public Student(
            int id, 
            string firstName,
            string latsName, 
            string email, 
            string gender,
            string studentType, 
            int examResult, 
            int homeworkSent,
            int homeworkEvaluated, 
            double teamworkScore, 
            int attendances,
            double bonus)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = latsName;
            this.Email = email;
            this.Gender = gender;
            this.StudentType = studentType;
            this.ExamResults = examResult;
            this.HomeworkSent = homeworkSent;
            this.HomeworkEvaluated = homeworkEvaluated;
            this.TeamworkScore = teamworkScore;
            this.Attendances = attendances;
            this.Bonus = bonus;
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Gender { get; set; }

        public string StudentType { get; set; }

        public int ExamResults { get; set; }

        public int HomeworkSent { get; set; }

        public int HomeworkEvaluated { get; set; }

        public double TeamworkScore { get; set; }

        public int Attendances { get; set; }

        public double Bonus { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat(
                "{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11}",
                this.Id,
                this.FirstName,
                this.LastName,
                this.Email,
                this.Gender,
                this.StudentType,
                this.ExamResults,
                this.HomeworkSent,
                this.HomeworkEvaluated,
                this.TeamworkScore,
                this.Attendances,
                this.Bonus);
            return result.ToString();
        }
    }
}
