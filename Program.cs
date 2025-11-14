namespace Task_11;

class Program
{
    static void Main(string[] args)
    {
            Student student1 = new Student("Ahmed Mohamed", 1001);
            Student student2 = new Student("Sarah Ali", 1002);
            Student student3 = new Student("Omar Hassan", 1003);
            Student student4 = new Student("Lina Mahmoud", 1004);

            student1.AttendancePercentage = 92;
            student2.AttendancePercentage = 78;
            student3.AttendancePercentage = 45;
            student4.AttendancePercentage = 65;

            Subject math1 = new Subject("Mathematics");
            math1.AddExam(new Exam("Quiz 1", 18, 20));
            math1.AddExam(new Exam("Midterm", 45, 50));
            math1.AddExam(new Exam("Final", 88, 100));

            Subject physics1 = new Subject("Physics");
            physics1.AddExam(new Exam("Lab Report", 28, 30));
            physics1.AddExam(new Exam("Theory Exam", 68, 70));

            Subject chemistry1 = new Subject("Chemistry");
            chemistry1.AddExam(new Exam("Practical", 24, 25));
            chemistry1.AddExam(new Exam("Written", 47, 50));

            student1.EnrollInSubject(math1);
            student1.EnrollInSubject(physics1);
            student1.EnrollInSubject(chemistry1);

            Subject math2 = new Subject("Mathematics");
            math2.AddExam(new Exam("Quiz 1", 15, 20));
            math2.AddExam(new Exam("Midterm", 40, 50));
            math2.AddExam(new Exam("Final", 75, 100));

            Subject physics2 = new Subject("Physics");
            physics2.AddExam(new Exam("Lab Report", 25, 30));
            physics2.AddExam(new Exam("Theory Exam", 60, 70));

            student2.EnrollInSubject(math2);
            student2.EnrollInSubject(physics2);

            Subject math3 = new Subject("Mathematics");
            math3.AddExam(new Exam("Quiz 1", 8, 20));
            math3.AddExam(new Exam("Midterm", 25, 50));

            student3.EnrollInSubject(math3);

            Subject math4 = new Subject("Mathematics");
            math4.AddExam(new Exam("Quiz 1", 12, 20));
            math4.AddExam(new Exam("Midterm", 35, 50));
            math4.AddExam(new Exam("Final", 60, 100));

            student4.EnrollInSubject(math4);

            student1.CalculateFinalGrade();
            student1.CalculatePerformance();

            student2.CalculateFinalGrade();
            student2.CalculatePerformance();

            student3.CalculateFinalGrade();
            student3.CalculatePerformance();

            student4.CalculateFinalGrade();
            student4.CalculatePerformance();

            student1.PrintReport();

            student2.PrintReport();

            student3.PrintReport();

            student4.PrintReport();
    }
}