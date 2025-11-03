class Program
{
    static void Main()
    {
        Person person = new Person();

        Course math = new Course("Mathematics");
        Course physics = new Course("Physics");

        person.AddCourse(math);
        person.AddCourse(physics);

        Console.WriteLine("Courses:");
        foreach (var c in person.GetCourses())
            Console.WriteLine($"- {c.Name}");

        person.RemoveCourse(math);
        Console.WriteLine("\nAfter removing Math:");
        foreach (var c in person.GetCourses())
            Console.WriteLine($"- {c.Name}");
    }
}
