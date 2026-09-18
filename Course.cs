using System;
using System.Collections.Generic;

public class Course
{
    public string Name { get; } // detta gör så att varje kurs har ett eget namn
    public int MaxSeats { get; } // att det finns ett maxantal platser
    public List<Student> Students { get; } = new List<Student>();

    public Course(string name, int maxSeats)
    {
        Name = name;
        MaxSeats = maxSeats;
    }
    public void Enroll(Student student)
    {
        // Regel: inga dubletter
        if (Students.Contains(student))
        {
            Console.WriteLine($"{student.name}går redan på {Name}."); return;
        }
    }
    // regel: kapacitet får inte överskridas.