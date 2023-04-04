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

        public static void PrintNumbers(List<NumberNamePair> pairs, int UpperBound)
        {
            for (int i = 1; i <= UpperBound; i++)
            {
                string PrintString = "";
                foreach(NumberNamePair pair in pairs)
                {
                    if (i % pair.Number == 0)
                    {
                        //if the current line number matches, add the appropriate name and a space
                        PrintString += pair.Name + " ";
                    }
                }

                if (PrintString == "")
                {
                    //Only print the line number if there are no matching number/name pairs for this line
                    PrintString = i.ToString();
                }
                Console.WriteLine(PrintString);
            }
        }
    }
}