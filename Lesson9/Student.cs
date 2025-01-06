namespace Lesson9;
internal class Student
{
    private string _name;

    private int _age;

    private double _gpa;

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }

    public int Age
    {
        get
        {
            return _age;
        }
        set
        {
            _age = value;
        }
    }

    public double Gpa
    {
        get
        {
            return _gpa;
        }
        set
        {
            _gpa = value;
        }
    }

    public Student(string name, int age, double gpa)
    {
        _name = name;
        _age = age;
        _gpa = gpa;
    }
}

