using PrintNamesLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        //We are assuming here that the client does not need to manipulate the results, but just wants them printed.
        //Client related that testing for an UpperBound that is negative is not within the scope of this project.
        PrintNumber.PrintNumbers(100);

        Console.WriteLine();
        Console.WriteLine("Test Two");
        Console.WriteLine();

        List<NumberNamePair> pairs = new List<NumberNamePair>();
        pairs.Add(new NumberNamePair(4, "Lisa"));
        PrintNumber.PrintNumbers(pairs, 100);
    }
}