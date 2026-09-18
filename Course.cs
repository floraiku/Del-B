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
    // regel 2: kapacitet får inte överskridas. Är kursen redan full säger vi ifrån sitället för att lägga till ännu en studerande.
    {
        Console.WriteLine($"kursen {Name} är full."); return"
    }
// o
// Lägger till studerande i kursens Lista.
Students.Add(student);
// Ser till att kopplingen syns åt andra hållet också så detta dyker upp i studerandens egen lista.

student.AddCourse(this);
}

public void Remove(Student student)
{
    // Regel 3: ingen krasch om studerande inte var anmäld.
    if (!Students.Contains(student))
    {
        Console.WriteLine($"{student.Name} är inte anmäld till {Name}."); return;
    }
    Students.Remove(student);
    // iden är att den ska vara som Enroll det vill sägas håll båda listorna i synk.
    student.RemoveCourse(this);
}
// detta skriver ut alla studerande i kursen.
public void Rollcall()
{
    Console.WriteLine($"Närvarolista för {Name}:");
    if (Students.count == 0)

    {

        Console.WriteLine("  ( inga studerande)");
        return;
    }
    foreach (var s in Students)
    {
        Console.WriteLine($"  - {s.Name}");
    }
}