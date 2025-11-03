using System;

public class Person
{
    // ✅ Giữ giá trị bất biến (immutable)
    public string Name { get; }

    public Person(string name)
    {
        Name = name;
    }

    // ❌ Đã loại bỏ setter — không thể đổi tên sau khi khởi tạo
}

public class Program
{
    static void Main(string[] args)
    {
        Person p = new Person("Alice");
        Console.WriteLine("Name: " + p.Name);

        // p.Name = "Bob"; ❌ Lỗi biên dịch: không thể gán giá trị cho thuộc tính chỉ đọc
    }
}