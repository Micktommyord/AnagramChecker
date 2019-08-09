using NUnit.Framework;
using System.Collections.Generic;

namespace AnagramChecker.Library.Tests
{
    [TestFixture]
    public class AnagramCheckerTests
    {
        [Test]
        public void AnagramChecker_String_Length_Equal_Returns_True()
        {
            // Arrange
            string input = "a a";
            string[] inputs = input.Split(" ");

            // Act
            bool result = AnagramChecker.CheckLengthEqual(inputs[0], inputs[1]);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void CalculateFrequency_Returns_Letter_Counts()
        {
            // Arrange
            string input = "abba";
            Dictionary<char, int> inputFrequency = new Dictionary<char, int>();
            inputFrequency.Add('a', 2);
            inputFrequency.Add('b', 2);

            // Act
            Dictionary<char, int> frequency = AnagramChecker.CalculateFrequency(input);

            // Assert
            Assert.AreEqual(inputFrequency, frequency);
        }

        [Test]
        public void String_Can_Split_Into_Two_Words()
        {
            // Arrange
            string input = "Test String";

            // Act
            bool countResult = AnagramChecker.StringSplitIntoTwoWords(input);

            // Assert
            Assert.IsTrue(countResult);
        }

        [Test]
        public void AnagramChecker_Returns_True_For_Identical_Words()
        {
            // Arrange
            string input = "abba abba";

            //Act
            bool testResult = AnagramChecker.IsAnagram(input);

            // Assert
            Assert.IsTrue(testResult);
        }

        [Test]
        public void AnagramChecker_Returns_False_For_Non_Anagram_Words()
        {
            // Arrange
            string input = "abba sole";

            //Act
            bool testResult = AnagramChecker.IsAnagram(input);

            // Assert
            Assert.IsFalse(testResult);
        }

        [Test]
        public void AnagramChecker_Returns_True_For_Real_Anagram_Words()
        {
            // Arrange
            string input = "pots stop";

            //Act
            bool testResult = AnagramChecker.IsAnagram(input);

            // Assert
            Assert.IsTrue(testResult);
        }
    }
}