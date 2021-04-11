using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PirateSpeak
{
    public class PirateSpeakValidate
    {
        public List<string> ValidWords(string pirateWord, List<string> wordsToCheck)
        {
            //alphabetically sorted pirate word
            var sortedWord = string.Concat(pirateWord.OrderBy(c => c));

            //container of words that match the sorted word
            var validWords = new List<string>();

            //loops through list of words
            foreach (var word in wordsToCheck)
            {
                //alphabetically sorted word
                var newSortedWord = string.Concat(word.OrderBy(c => c));

                //if both alphabetically sorted words match, add to validWords list
                if (newSortedWord == sortedWord)
                {
                    validWords.Add(word);
                }
            }

            return validWords;
        }
    }
}
