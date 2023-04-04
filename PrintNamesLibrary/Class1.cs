namespace PrintNamesLibrary
{
    public class Class1
    {
        public static void PrintNumbers(int UpperBound)
        {
            for (int i = 1; i <= UpperBound; i++)
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
}