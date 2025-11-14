namespace Task_11;

public class Exam
{
    public string Name { get; set; }
    public double StudentScore { get; set; }
    public double SubjectScore { get; set; }

    public Exam(string name, double studentScore, double subjectScore)
    {
        Name = name;
        StudentScore = studentScore;
        SubjectScore = subjectScore;
    }
    
}