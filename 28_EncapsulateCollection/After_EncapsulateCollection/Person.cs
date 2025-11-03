class Person
{
    private readonly HashSet<Course> _courses = new HashSet<Course>();

    // ✅ Chỉ cho phép đọc - không thể chỉnh sửa trực tiếp
    public IReadOnlyCollection<Course> GetCourses()
    {
        {
            return _courses;
    }

    // ✅ Thêm/xoá thông qua phương thức kiểm soát
    public void AddCourse(Course course)
    {
        _courses.Add(course);
    }

    public void RemoveCourse(Course course)
    {
        _courses.Remove(course);
    }
}
