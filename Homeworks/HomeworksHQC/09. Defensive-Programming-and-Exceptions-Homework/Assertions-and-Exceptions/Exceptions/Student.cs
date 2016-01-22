using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

public class Student
{
    private string firstName;

    private string lastName;

    public Student(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public Student(string firstName, string lastName, IList<Exam> exams)
        : this(firstName, lastName)
    {
        this.Exams = exams;
    }

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
                throw new ArgumentNullException("First Name", "The first name cannot be null empty or whitespace");
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
                throw new ArgumentNullException("Last Name", "The last name cannot be null empty or whitespace");
            }

            this.lastName = value;
        }
    }

    public IList<Exam> Exams { get; set; }

    public IList<ExamResult> CheckExams()
    {
        this.ExamCountValidator();

        IList<ExamResult> results = new List<ExamResult>();
        for (int i = 0; i < this.Exams.Count; i++)
        {
            results.Add(this.Exams[i].Check());
        }

        return results;
    }

    public double CalcAverageExamResultInPercents()
    {
        this.ExamCountValidator();

        double[] examScore = new double[this.Exams.Count];
        IList<ExamResult> examResults = this.CheckExams();
        for (int i = 0; i < examResults.Count; i++)
        {
            examScore[i] = 
                ((double)examResults[i].Grade - examResults[i].MinGrade) / 
                (examResults[i].MaxGrade - examResults[i].MinGrade);
        }

        return examScore.Average();
    }

    private void ExamCountValidator()
    {
        Debug.Assert(this.Exams == null, "The set of exams cannot be null");
        Debug.Assert(this.Exams.Count == 0, "No exams added");
    }
}
