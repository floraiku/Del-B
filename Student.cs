using System;
using System.Collections.Generic;
// student representerar en studerande. Den känner till vilka kurser den går via listan Courses.
public class Student
{
    public string Name { get; }
    public List<Course> Courses { get; } = new List<Course>();
    public Student(string name)
    {
        Name = name;
    }
    // Går med i en kurs. Enroll så samma regler gäller oavsett håll.
    public void Join(Course course)
    {
        course.Enroll(this);
    }
    // samma ide som join fast för att lämna en kurs
    public void Leave(Course course)
    {
        course.Remove(this);
    }
    // detta skriver ut vilka kurser studerande går i.
    public void Schedule()
    {
        Console.WriteLine($"{Name} går på");
        if (Courses.Count == 0)
        {
            Console.WriteLine(" (inga kurser)");
            return;
        }
        foreach (var c in Courses)
        {
            Console.WriteLine($"  - {c.Name}");
        }
    }

    public override string ToString()
    {
        return Name;
    }

    // internal betyder att metoden bara kan anropas från kod i samma projekt(i praktiken; bara av Course). Det är medvetet - ingen utomstående kod ska kunna lägga till en kurs i en studerandes lista utan att gå via Course.
    internal void AddCourse(Course course)
    {
        // detta är extra skydd mot dubletter, ifall något annat än Course.Enroll någon gång skulle anropa denna.
        if (!Courses.Contains(course))
        {
            Courses.Add(course);
        }
    }

    internal void RemoveCourse(Course course)
    {
        Courses.Remove(course);
    }
}