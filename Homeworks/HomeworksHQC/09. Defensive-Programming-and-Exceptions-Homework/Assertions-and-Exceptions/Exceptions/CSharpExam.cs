using System;

public class CSharpExam : Exam
{
    private const int MinExamResult = 0;

    private const int MaxExamResult = 100;

    private int score;

    public CSharpExam(int score)
    {
        this.Score = score;
    }

    public int Score
    {
        get
        {
            return this.score;
        }

        set
        {
            if (value < MinExamResult || value > MaxExamResult)
            {
                throw new ArgumentOutOfRangeException("Invalid Score", "The score must be in range [ 0 ... 100 ]");
            }

            this.score = value;
        }
    }

    public override ExamResult Check()
    {
        ExamResult examResult = new ExamResult(this.Score, MinExamResult, MaxExamResult, "Exam results calculated by score.");
        return examResult;
    }
}
