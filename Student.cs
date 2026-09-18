public class Student
{
    public string Name;
    public List<Course> Courses;
    public Student(string name)
    {
        Name = name;
        Courses = new List<Course>();
    }
    // Går med i en kurs

}