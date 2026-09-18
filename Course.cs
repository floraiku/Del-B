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
            Console.WriteLine($"{student.Name} går redan på {Name}."); return;
        }
        // regel 2: kapacitet får inte överskridas. Är kursen redan full säger vi ifrån sitället för att lägga till ännu en studerande.
        if (Students.Count >= MaxSeats)
        {
            Console.WriteLine($"kursen {Name} är full."); return;
        }
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
    public void RollCall()
    {
        Console.WriteLine($"Närvarolista för {Name}:");
        if (Students.Count == 0)
        {
            Console.WriteLine("  (inga studerande)");
            return;
        }
        foreach (var s in Students)
        {
            Console.WriteLine($"  - {s.Name}");
        }
    }
    // körs automatiskt när man t.ex skriver Console.WriteLine(matte). Man får till exempel att de står "matematik (2/5 platser)" som uppgiften ber om
    public override string ToString()
    {
        return $"{Name} ({Students.Count}/{MaxSeats} platser)";
    }
}