namespace StringProcessor;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

public static class StringProcessor
{
    public static string InputString()
    {
        Console.Write("Enter a string: ");
        return Console.ReadLine();
    }
}