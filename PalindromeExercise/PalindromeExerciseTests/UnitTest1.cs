using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("dad", true)]
        [InlineData("Hannah", true)]
        [InlineData(" ", true)]
        [InlineData("never odd or even ", true)]

        public void PalindromTestTakesInString_OutputsBoolIfPalindrome(string word, bool expected)
        {
            //Arrange

            var wordSmith = new WordSmith();

            //Act

            var answer = wordSmith.IsAPalindrome(word);

            //Assert

            Assert.Equal(expected,answer);

        }
    }
}
