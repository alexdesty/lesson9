namespace Lesson9;

internal class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student("Jack", 20, 9.2);
        StudentRegistry.AddStudent(student1);
        Student student2 = new Student("Ivan", 21, 8.2);
        StudentRegistry.AddStudent(student2);
        Student student3 = new Student("Michael", 22, 7.5);
        StudentRegistry.AddStudent(student3);
        StudentRegistry.SortedListByGpaDesc();
        StudentRegistry.YoungestStudentInfo();
    }
}

