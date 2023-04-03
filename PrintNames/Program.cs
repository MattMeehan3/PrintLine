internal class Program
{
    private static void Main(string[] args)
    {
        for (int i = 1; i <= 100; i++)
        {
            string PrintString = "";
            if (i % 3 == 0)
            {
                PrintString += "Ricky";
            }
            if (i % 5 == 0)
            {
                PrintString += "Bobby";
            }

            if (PrintString == "")
            {
                PrintString = i.ToString();
            }

            Console.WriteLine(PrintString);
        }
    }

}