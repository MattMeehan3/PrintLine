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
    }
}