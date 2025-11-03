using System.Collections.Generic;
class Person
{
    private HashSet<Course> courses = new HashSet<Course>();

    public HashSet<Course> GetCourses()
    {
        return courses;
    }

    public void SetCourses(HashSet<Course> newCourses)
    {
        courses = newCourses;
    }
}

internal class Course
{
}