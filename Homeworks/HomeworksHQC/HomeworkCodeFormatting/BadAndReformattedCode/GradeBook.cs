using System;
using System.Collections.Generic;
using System.IO;


namespace BadAndReformattedCode
{
   

    class GradeBook
    {
        private List<float> grades; private string name;
        public event NamedChangedDelegate NameChanged;

        public GradeBook(
            string name = "There is no name")
        {
            this.Name = name;
            grades = 
                            new List<float>();
        }
        //properties
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
                    throw new ArgumentNullException(
                        "Name", "The name cannot be null, empty or whitespace.");
                }
                if (this.name != value) {
                    var oldValue = this.name;
                    this.name = value;
                    if (NameChanged 
                        != null)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args
                            .OldValue = oldValue; args
                            .NewValue = value;
                        NameChanged(this, args);} }
            }
        }


        public void   WriteGrades  (TextWriter textWriter)
        {
            for (int i = 0; i< grades.Count; i++)
            {
                textWriter.WriteLine(grades[i]);
            }
            textWriter.WriteLine("***********************"); }



        //Methods
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }
        public GradeStatistics ComputeStatistic()
        {
            GradeStatistics stats = new GradeStatistics();
            float sum = 0f;

            foreach (float grade in grades)
            {
                stats.HigherGrade = Math.Max(grade, stats.HigherGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;
            return stats;
        }
    }
}
