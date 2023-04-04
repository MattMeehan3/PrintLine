using PrintNamesLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        //We are assuming here that the client does not need to manipulate the results, but just wants them printed.
        Class1.PrintNumbers(int.MaxValue);
    }
}