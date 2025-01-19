public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public static void Main(string[] args)
    {
        var instance1 = new ExampleClass(10);
        var instance2 = instance1;

        instance2.MyProperty = 20;

        Console.WriteLine(instance1.MyProperty); // Outputs 20
    }
}