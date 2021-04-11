using System;
using System.Collections.Generic;
using Xunit;

namespace PirateSpeak.Tests
{
    public class CheckIfInputIsPiratey
    {
        [Fact]
        public void this_is_the_list_of_words_that_can_be_made_from_ortsp()
        {
            //Arrange
            var pirateWord = "ortsp";
            var wordFinder = new PirateSpeakValidate();
            var wordsToCheck = new List<string>() { "sport", "parrot", "ports", "matey" };

            //Act
            var foundWords = wordFinder.ValidWords(pirateWord, wordsToCheck);

            //Assert
            Assert.Equal(new List<string>() { "sport", "ports" }, foundWords);
        }

        [Fact]
        public void this_is_the_list_of_words_that_can_be_made_from_twen()
        {
            //Arrange
            var pirateWord = "twen";
            var wordFinder = new PirateSpeakValidate();
            var wordsToCheck = new List<string>() { "teen", "went", "tent", "newt" };

            //Act
            var foundWords = wordFinder.ValidWords(pirateWord, wordsToCheck);

            //Assert
            Assert.Equal(new List<string>() { "went", "newt" }, foundWords);
        }
    }
}
