using GenericSortNS;
using System.Security.Principal;

namespace GenericSortTests
{
    [TestClass]
    public class GenericSortTests
    {
        [TestMethod]
        public void TestInsertionSort_WithIntArray()
        {
            // Arrange
            int[] numbers = {3, 1, 2};
            int[] sortedNumbers = { 1, 2, 3, };

            // Act
            Program.InsertionSort(numbers);

            // Assert
            bool areEqual = (numbers[0] == sortedNumbers[0]) && (numbers[1] == sortedNumbers[1]) && (numbers[2] == sortedNumbers[2]);
            Assert.IsTrue(areEqual);
        }

        [TestMethod]
        public void TestInsertionSort_WithStringArray()
        {
            // Arrange
            string[] words = {"cup", "cat", "ant"};
            string[] sortedWords = {"ant", "cat", "cup"};

            // Act
            Program.InsertionSort(words);

            // Assert
            bool areEqual = (words[0] == sortedWords[0]) && (words[1] == sortedWords[1]) && (words[2] == sortedWords[2]);
            Assert.IsTrue(areEqual);
        }


        [TestMethod]
        public void TestInsertionSort_WithDoubleArray()
        {
            // Arrange
            double[] doubles = { 1.3, 1.1, 1.2 };
            double[] sortedDoubles = { 1.1, 1.2, 1.3 };

            // Act
            Program.InsertionSort(doubles);

            // Assert
            bool areEqual = (doubles[0] == sortedDoubles[0]) && (doubles[1] == sortedDoubles[1]) && (doubles[2] == sortedDoubles[2]);
            Assert.IsTrue(areEqual);
        }
    }
}