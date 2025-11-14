namespace Task_11;

public class Subject
{
    private int examCount = 0; 
    public string Name { get; set; }
    public Exam[]  Exams =  new Exam[7];

    public Subject(string name)
    {
        Name = name;
    }

    public void AddExam(Exam exam)
    {
        if (examCount == Exams.Length)
        {
            Console.WriteLine($"{Name} Can't have more exams");
            return;
        }
        Exams[examCount++] = exam;
    }
    private double StudentScore()
    {
        double sum = 0;
        for (int i = 0; i < examCount; i++)
        {
            sum += Exams[i].StudentScore;
        }
        return sum;
    }

    private double SubjectScore()
    {
        double sum = 0;
        for (int i = 0; i < examCount; i++)
        {
            sum += Exams[i].SubjectScore;
        }
        return sum;
    }

    public double AvarageExamScore()
    {
        return (StudentScore()/SubjectScore()) * 100;
    }

    public void PrintExams()
    {
        Console.WriteLine($"This subject has {examCount} exams");
        for (int i = 0; i < examCount; i++)
        {
            Console.WriteLine($"- Exam {i+1}: {Exams[i].Name}");
            Console.WriteLine($"  Score: {Exams[i].StudentScore}/{Exams[i].SubjectScore}");
        }
        Console.WriteLine($"  Subject Average: {AvarageExamScore()}%");
    }
}