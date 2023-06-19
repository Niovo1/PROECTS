using System;

public class Student : IComparable<Student>
{
    public string Name { get; set; }
    public int Marks { get; set; }

    public int CompareTo(Student other)
    {
        // Compare students based on marks
        return Marks.CompareTo(other.Marks);
    }
}

class Program
{
    static void Main()
    {
        Student[] students = new Student[10]
        {
            new Student { Name = "Ken", Marks = 73 },
            new Student { Name = "Matthew", Marks = 86 },
            new Student { Name = "Charles", Marks = 61 },
            new Student {Name = "James", Marks = 70},
            new Student {Name = "Jerry", Marks = 80},
            new Student {Name = "Jeremiah", Marks = 90},
            new Student {Name = "Jacob", Marks = 76},
            new Student {Name = "Jamie", Marks = 73},
            new Student {Name = "Jane", Marks = 79},
            new Student {Name = "John", Marks = 78}

        };

        Array.Sort(students);
        

        foreach (Student student in students)
        {
            Console.WriteLine($"Name: {student.Name}, Marks: {student.Marks}");
        }
    }
}
