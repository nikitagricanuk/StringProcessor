namespace StringProcessor;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(StringProcessor.ReplaceDWithT(StringProcessor.InputString()));
    }
}

public static class StringProcessor
{
    public static string InputString()
    {
        Console.Write("Enter a string: ");
        return Console.ReadLine();
    }

    public static string ReplaceDWithT(string input)
    {
        string[] words = input.Split(' ');
        string result = "";
        foreach (var word in words)
        {
            if (word.Length % 2 != 0)
            {
                result += word.Replace('d', 't') + ' ' + word.Replace('d', 't') + ' ';
            }
        }

        return result;
    }
}