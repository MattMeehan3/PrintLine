using PrintNamesLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        foreach(string line in Class1.PrintNumbers(int.MaxValue))
        {
            Console.WriteLine(line);
        }
    }
}