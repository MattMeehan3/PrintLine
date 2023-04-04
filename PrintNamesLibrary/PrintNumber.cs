namespace PrintNamesLibrary
{
    public class PrintNumber
    {
        public static void PrintNumbers(int UpperBound)
        {
            //If a list of number pairs are not supplied, use the default 3/Ricky and 5/Bobby
            List<NumberNamePair> pairs = new List<NumberNamePair>();
            pairs.Add(new NumberNamePair(3, "Ricky"));
            pairs.Add(new NumberNamePair(5, "Bobby"));
            PrintNumbers(pairs, UpperBound);
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