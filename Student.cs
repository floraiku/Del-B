using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
// student representerar en studerande. Den känner till vilka kurser den går via listan Courses.
public class Student
{
    public string Name; { get; }
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
    }
}
