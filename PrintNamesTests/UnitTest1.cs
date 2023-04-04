using PrintNamesLibrary;

namespace PrintNamesTests
{
    public class UnitTest1
    {
        [Fact]
        public void BasicTest5()
        {
            //Arrange
            int UpperBound = 5;
            string expectedOutput = "1\r\n2\r\nRicky \r\n4\r\nBobby \r\n";
            using StringWriter writer = new();
            Console.SetOut(writer);

            //Act
            PrintNumber.PrintNumbers(UpperBound);

            //Assert
            string actualOutput = writer.ToString();
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void BasicTest100()
        {
            //Arrange
            int UpperBound = 100;
            string expectedOutput = "1\r\n2\r\nRicky \r\n4\r\nBobby \r\nRicky \r\n7\r\n8\r\nRicky \r\nBobby \r\n11\r\nRicky \r\n13\r\n14\r\nRicky Bobby \r\n16\r\n17\r\nRicky \r\n19\r\nBobby \r\nRicky \r\n22\r\n23\r\nRicky \r\nBobby \r\n26\r\nRicky \r\n28\r\n29\r\nRicky Bobby \r\n31\r\n32\r\nRicky \r\n34\r\nBobby \r\nRicky \r\n37\r\n38\r\nRicky \r\nBobby \r\n41\r\nRicky \r\n43\r\n44\r\nRicky Bobby \r\n46\r\n47\r\nRicky \r\n49\r\nBobby \r\nRicky \r\n52\r\n53\r\nRicky \r\nBobby \r\n56\r\nRicky \r\n58\r\n59\r\nRicky Bobby \r\n61\r\n62\r\nRicky \r\n64\r\nBobby \r\nRicky \r\n67\r\n68\r\nRicky \r\nBobby \r\n71\r\nRicky \r\n73\r\n74\r\nRicky Bobby \r\n76\r\n77\r\nRicky \r\n79\r\nBobby \r\nRicky \r\n82\r\n83\r\nRicky \r\nBobby \r\n86\r\nRicky \r\n88\r\n89\r\nRicky Bobby \r\n91\r\n92\r\nRicky \r\n94\r\nBobby \r\nRicky \r\n97\r\n98\r\nRicky \r\nBobby \r\n";
            using StringWriter writer = new();
            Console.SetOut(writer);

            //Act
            PrintNumber.PrintNumbers(UpperBound);

            //Assert
            string actualOutput = writer.ToString();
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void BasicTest500000()
        {
            //Arrange
            int UpperBound = 500000;
            //Load the expected output from a file, because Visual Studio doesn't like a single line of code that long.
            string expectedOutput = string.Join(Environment.NewLine, File.ReadAllLines("500000.txt"));
            using StringWriter writer = new();
            Console.SetOut(writer);

            //Act
            PrintNumber.PrintNumbers(UpperBound);

            //Assert
            string actualOutput = writer.ToString();
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void BasicTest32000000()
        {
            //Arrange
            int UpperBound = 32000000;
            //Load the expected output from a file, because Visual Studio doesn't like a single line of code that long.
            string expectedOutput = string.Join(Environment.NewLine, File.ReadAllLines("32000000.txt"));
            using StringWriter writer = new();
            Console.SetOut(writer);

            //Act
            PrintNumber.PrintNumbers(UpperBound);

            //Assert
            string actualOutput = writer.ToString();
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void LisaTest1()
        {
            //Arrange
            int UpperBound = 100;
            List<NumberNamePair> pairs = new List<NumberNamePair>();
            pairs.Add(new NumberNamePair(4, "Lisa"));
            string expectedOutput = "1\r\n2\r\n3\r\nLisa \r\n5\r\n6\r\n7\r\nLisa \r\n9\r\n10\r\n11\r\nLisa \r\n13\r\n14\r\n15\r\nLisa \r\n17\r\n18\r\n19\r\nLisa \r\n21\r\n22\r\n23\r\nLisa \r\n25\r\n26\r\n27\r\nLisa \r\n29\r\n30\r\n31\r\nLisa \r\n33\r\n34\r\n35\r\nLisa \r\n37\r\n38\r\n39\r\nLisa \r\n41\r\n42\r\n43\r\nLisa \r\n45\r\n46\r\n47\r\nLisa \r\n49\r\n50\r\n51\r\nLisa \r\n53\r\n54\r\n55\r\nLisa \r\n57\r\n58\r\n59\r\nLisa \r\n61\r\n62\r\n63\r\nLisa \r\n65\r\n66\r\n67\r\nLisa \r\n69\r\n70\r\n71\r\nLisa \r\n73\r\n74\r\n75\r\nLisa \r\n77\r\n78\r\n79\r\nLisa \r\n81\r\n82\r\n83\r\nLisa \r\n85\r\n86\r\n87\r\nLisa \r\n89\r\n90\r\n91\r\nLisa \r\n93\r\n94\r\n95\r\nLisa \r\n97\r\n98\r\n99\r\nLisa \r\n";
            using StringWriter writer = new();
            Console.SetOut(writer);

            //Act
            PrintNumber.PrintNumbers(pairs, UpperBound);

            //Assert
            string actualOutput = writer.ToString();
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void FrankTest1()
        {
            //Arrange
            int UpperBound = 10;
            List<NumberNamePair> pairs = new List<NumberNamePair>();
            pairs.Add(new NumberNamePair(2, "Frank"));
            string expectedOutput = "1\r\nFrank \r\n3\r\nFrank \r\n5\r\nFrank \r\n7\r\nFrank \r\n9\r\nFrank \r\n";
            using StringWriter writer = new();
            Console.SetOut(writer);

            //Act
            PrintNumber.PrintNumbers(pairs, UpperBound);

            //Assert
            string actualOutput = writer.ToString();
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void LisaBobbyTest1()
        {
            //Arrange
            int UpperBound = 24;
            List<NumberNamePair> pairs = new List<NumberNamePair>();
            pairs.Add(new NumberNamePair(4, "Lisa"));
            pairs.Add(new NumberNamePair(5, "Bobby"));
            string expectedOutput = "1\r\n2\r\n3\r\nLisa \r\nBobby \r\n6\r\n7\r\nLisa \r\n9\r\nBobby \r\n11\r\nLisa \r\n13\r\n14\r\nBobby \r\nLisa \r\n17\r\n18\r\n19\r\nLisa Bobby \r\n21\r\n22\r\n23\r\nLisa \r\n";
            using StringWriter writer = new();
            Console.SetOut(writer);

            //Act
            PrintNumber.PrintNumbers(pairs, UpperBound);

            //Assert
            string actualOutput = writer.ToString();
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void NoPairsTest101()
        {
            //Arrange
            int UpperBound = 101;
            List<NumberNamePair> pairs = new List<NumberNamePair>();
            //Do not add any pairs to the test case.
            string expectedOutput = "1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n7\r\n8\r\n9\r\n10\r\n11\r\n12\r\n13\r\n14\r\n15\r\n16\r\n17\r\n18\r\n19\r\n20\r\n21\r\n22\r\n23\r\n24\r\n25\r\n26\r\n27\r\n28\r\n29\r\n30\r\n31\r\n32\r\n33\r\n34\r\n35\r\n36\r\n37\r\n38\r\n39\r\n40\r\n41\r\n42\r\n43\r\n44\r\n45\r\n46\r\n47\r\n48\r\n49\r\n50\r\n51\r\n52\r\n53\r\n54\r\n55\r\n56\r\n57\r\n58\r\n59\r\n60\r\n61\r\n62\r\n63\r\n64\r\n65\r\n66\r\n67\r\n68\r\n69\r\n70\r\n71\r\n72\r\n73\r\n74\r\n75\r\n76\r\n77\r\n78\r\n79\r\n80\r\n81\r\n82\r\n83\r\n84\r\n85\r\n86\r\n87\r\n88\r\n89\r\n90\r\n91\r\n92\r\n93\r\n94\r\n95\r\n96\r\n97\r\n98\r\n99\r\n100\r\n101\r\n";
            using StringWriter writer = new();
            Console.SetOut(writer);

            //Act
            PrintNumber.PrintNumbers(pairs, UpperBound);

            //Assert
            string actualOutput = writer.ToString();
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void NoPairsTest103()
        {
            //Arrange
            int UpperBound = 103;
            List<NumberNamePair> pairs = new List<NumberNamePair>();
            //Do not add any pairs to the test case.
            string expectedOutput = "1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n7\r\n8\r\n9\r\n10\r\n11\r\n12\r\n13\r\n14\r\n15\r\n16\r\n17\r\n18\r\n19\r\n20\r\n21\r\n22\r\n23\r\n24\r\n25\r\n26\r\n27\r\n28\r\n29\r\n30\r\n31\r\n32\r\n33\r\n34\r\n35\r\n36\r\n37\r\n38\r\n39\r\n40\r\n41\r\n42\r\n43\r\n44\r\n45\r\n46\r\n47\r\n48\r\n49\r\n50\r\n51\r\n52\r\n53\r\n54\r\n55\r\n56\r\n57\r\n58\r\n59\r\n60\r\n61\r\n62\r\n63\r\n64\r\n65\r\n66\r\n67\r\n68\r\n69\r\n70\r\n71\r\n72\r\n73\r\n74\r\n75\r\n76\r\n77\r\n78\r\n79\r\n80\r\n81\r\n82\r\n83\r\n84\r\n85\r\n86\r\n87\r\n88\r\n89\r\n90\r\n91\r\n92\r\n93\r\n94\r\n95\r\n96\r\n97\r\n98\r\n99\r\n100\r\n101\r\n102\r\n103\r\n";
            using StringWriter writer = new();
            Console.SetOut(writer);

            //Act
            PrintNumber.PrintNumbers(pairs, UpperBound);

            //Assert
            string actualOutput = writer.ToString();
            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}