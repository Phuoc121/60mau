public class Class1
{
    private Class2 class2;

    public Class1(Class2 c2)
    {
        class2 = c2;
    }

    // Phương thức này được Class2 dùng nhiều hơn
    public void AMethod()
    {
        Console.WriteLine("This method does something related to Class2");
        class2.DoSomething();
    }
}

public class Class2
{
    public void UseClass1(Class1 c1)
    {
        // Class2 thường xuyên gọi AMethod()
        c1.AMethod();
    }

    public void DoSomething()
    {
        Console.WriteLine("Doing something...");
    }
}
