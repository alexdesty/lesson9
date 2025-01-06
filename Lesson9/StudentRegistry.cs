namespace Lesson9;

internal static class StudentRegistry
{
    static List<Student> listOfStudents = new List<Student>();

    public static void AddStudent(Student student)
    {
        listOfStudents.Add(student);
    }

    public static void ShowInfo(Student student)
    {
        Console.WriteLine($"Student's name: {student.Name}");
        Console.WriteLine($"Student's age: {student.Age}");
        Console.WriteLine($"Student's GPA: {student.Gpa}\n");
    }

    public static void SortedListByGpaDesc()
    {
        listOfStudents = listOfStudents.OrderByDescending(_ => _.Gpa).ToList();
        Console.WriteLine("List of student ordered by GPA descending:\n");
        foreach (Student student in listOfStudents)
        {
            ShowInfo(student);
        }
    }

    public static void YoungestStudentInfo()
    {
        var youngestStudent = listOfStudents[0];
        for (int i = 1; i < listOfStudents.Count; i++)
        {
            if (youngestStudent.Age > listOfStudents[i].Age)
            {
                youngestStudent = listOfStudents[i];
            }
        }
        Console.WriteLine("Youngest student's information:\n");
        ShowInfo(youngestStudent);
    }
}

