public class Class1
{
    private Class2 class2;

    public Class1(Class2 c2)
    {
        class2 = c2;
    }

    // Xóa hoặc chuyển hướng sang Class2
    public void AMethod()
    {
        class2.AMethod();
    }
}

public class Class2
{
    public void AMethod()
    {
        Console.WriteLine("This method now lives in Class2");
        DoSomething();
    }

    public void DoSomething()
    {
        Console.WriteLine("Doing something...");
    }
}
