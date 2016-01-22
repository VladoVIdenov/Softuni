namespace BadAndReformattedCode
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class GradeBook_reformatted
    {
        private List<float> grades;
        private string name;

        public GradeBook_reformatted(string name = "There is no name")
        {
            this.Name = name;
            this.grades = new List<float>();
        }

        public event NamedChangedDelegate NameChanged;

        /// <summary>
        /// Properties
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name", "The name cannot be null, empty or whitespace.");
                }

                if (this.name != value)
                {
                    var oldValue = this.name;
                    this.name = value;
                    if (this.NameChanged != null)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.OldValue = oldValue;
                        args.NewValue = value;
                        this.NameChanged(this, args);
                    }
                }
            }
        }

        public void WriteGrades(TextWriter textWriter)
        {
            for (int i = 0; i < this.grades.Count; i++)
            {
                textWriter.WriteLine(this.grades[i]);
            }

            textWriter.WriteLine("***********************");
        }

        // Methods
        public void AddGrade(float grade)
        {
            this.grades.Add(grade);
        }

        public GradeStatistics ComputeStatistic()
        {
            GradeStatistics stats = new GradeStatistics();
            float sum = 0f;

            foreach (float grade in this.grades)
            {
                stats.HigherGrade = Math.Max(grade, stats.HigherGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }

            stats.AverageGrade = sum / this.grades.Count;
            return stats;
        }
    }
}
