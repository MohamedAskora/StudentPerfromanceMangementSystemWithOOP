namespace Task_11;

public enum GradeCategry
{
    A,
    B,
    C,
    D,
    F
}

public enum PerformanceStatus
{
    Excellent,
    Good,
    NeedsImprovement,
    Fail
}
public class Student
{
    private int count = 0;
    public string Name { get; set; }
    public int Id { get; set; }
    public Subject[] Subjects = new Subject[10];
    public double AttendancePercentage { get; set; }
    public GradeCategry FinalGrade  { get; set; }
    public PerformanceStatus Performance { get; set; }

    public Student(string name, int id)
    {
        Name = name;
        Id = id;
    }

    public void EnrollInSubject(Subject subject)
    {
        if (count == Subjects.Length)
        {
            Console.WriteLine($"{Name} Can't enroll in more subjects");
            return;
        }
        Subjects[count++] = subject;
    }

    public void CalculateFinalGrade()
    {
        if (count == 0) 
        {
            FinalGrade = GradeCategry.F;
            return;
        }
    
        double totalAverage = 0;
        for (int i = 0; i < count; i++)
        {
            totalAverage += Subjects[i].AvarageExamScore();
        }
    
        double finalAverage = totalAverage / count; // أهم سطر!

        if (finalAverage >= 90)
        {
            FinalGrade = GradeCategry.A;
        }
        else if (finalAverage >= 80)
        {
            FinalGrade = GradeCategry.B;
        }
        else if (finalAverage >= 70)
        {
            FinalGrade = GradeCategry.C;
        }
        else if (finalAverage >= 60)
        {
            FinalGrade = GradeCategry.D;
        }
        else
        {
            FinalGrade = GradeCategry.F;
        }
    }

    public void CalculatePerformance()
    {
        if (FinalGrade == GradeCategry.F || AttendancePercentage < 50)
        {
            Performance = PerformanceStatus.Fail;
        }
        else if (FinalGrade == GradeCategry.A && AttendancePercentage >= 90)
        {
            Performance = PerformanceStatus.Excellent;
        }
        else if (FinalGrade == GradeCategry.B && AttendancePercentage >= 75)
        {
            Performance = PerformanceStatus.Good;
        }
        else
        {
            Performance = PerformanceStatus.NeedsImprovement;
        }
    }

    public void StudentSubjects()
    {
        Console.WriteLine($"This student enrolled in {count}  subjects");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"Subject number {i+1}: {Subjects[i].Name}");
            Subjects[i].PrintExams();
            
        }
    }
    public void PrintReport()
    {
        Console.WriteLine("================Student Report================");
        Console.WriteLine($"Student Name: {Name}");
        Console.WriteLine($"Student ID: {Id}");
        Console.WriteLine($"=============================================");
        Console.WriteLine($"Student Subjects:");
        StudentSubjects();
        Console.WriteLine($"=============================================");
        Console.WriteLine($"Final Grade: {FinalGrade}");
        Console.WriteLine($"=============================================");
        Console.WriteLine($"Attendance Percentage: {AttendancePercentage}");
        Console.WriteLine($"=============================================");
        Console.WriteLine($"Performance Status: {Performance}");
    }
}