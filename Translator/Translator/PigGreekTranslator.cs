using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Translator
{
    // I really really really hate string manipulation and parsing.
    public class PigGreekTranslator : ITranslator
    {
        public string Translate(string toTranslate)
        {
            // Splits the entire string into an array using a space delimitter.
            string[] words = toTranslate.Split(' ');
            for(int i = 0; i < words.Length; i++)
            {
                // Word starts with a vowel
                string word = words[i];
                int firstVowelIndex = ContainsVowel(word);
                if (firstVowelIndex == 0) // Word starts with vowel
                {
                    words[i] = AddToString(word, "way");
                }
                else // Word starts with a consonant
                {
                    string yCheck = word.Substring(1);
                    if (yCheck.IndexOf("Y", StringComparison.OrdinalIgnoreCase) != -1) // if the word contains a y not at the start. Y should be treated as a vowel
                    {
                        int vowelIndex = word.IndexOf("Y", StringComparison.OrdinalIgnoreCase);
                        if (ContainsVowel(word) != -1 && ContainsVowel(word) < vowelIndex) // There is a y not at the start, but there is also a vowel before the y
                        {
                            vowelIndex = ContainsVowel(word);
                        }
                        string consBeforeVowel = word.Substring(0, vowelIndex);
                        string consAfterVowelWIncludedVowel = word.Substring(vowelIndex);
                        if (char.IsUpper(consBeforeVowel.First()))
                        {
                            consBeforeVowel = consBeforeVowel.ToLower();
                            char firstLetter = consAfterVowelWIncludedVowel.First();
                            string firstLetterStr = firstLetter.ToString().ToUpper();
                            consAfterVowelWIncludedVowel = firstLetterStr + consAfterVowelWIncludedVowel.Substring(1);
                        }
                        string full = consAfterVowelWIncludedVowel + consBeforeVowel;
                        string added = "";
                        if (char.IsUpper(full, 1)) // Assume the whole word is an uppercase if the second letter is
                        {
                            added = AddToString(full, "AY");
                            added = added.ToUpper();
                        }
                        else
                        {
                            added = AddToString(full, "ay");
                        }
                        if (full == added) { continue; } // Word did not pass the check to be altered
                        else { words[i] = added; }
                    }
                    else if (ContainsVowel(word) == -1) // Word does not have a vowel anywhere
                    {
                        words[i] = AddToString(word, "ay");
                        continue; // continue to the next word
                    }
                    else // The word doesn't start with a vowel, but contains one
                    {
                        int vowelIndex = ContainsVowel(word);
                        string consBeforeVowel = word.Substring(0, vowelIndex);
                        string consAfterVowelWIncludedVowel = word.Substring(vowelIndex);
                        if (char.IsUpper(consBeforeVowel.First()))
                        {
                            consBeforeVowel = consBeforeVowel.ToLower();
                            char firstLetter = consAfterVowelWIncludedVowel.First();
                            string firstLetterStr = firstLetter.ToString().ToUpper();
                            consAfterVowelWIncludedVowel = firstLetterStr + consAfterVowelWIncludedVowel.Substring(1);
                        }
                        string full = consAfterVowelWIncludedVowel + consBeforeVowel;
                        string added = "";
                        if(char.IsUpper(full, 1)) // Assume the whole word is an uppercase if the second letter is
                        {
                            added = AddToString(full, "AY");
                            added = added.ToUpper();
                        }
                        else
                        {
                            added = AddToString(full, "ay");
                        }
                        if (full == added) { continue; } // Word did not pass the check to be altered
                        else { words[i] = added; }
                    }
                }
            }
            return string.Join(" ", words);
        }
        // A method for dealing with strings containing periods at the (end.) 
        // Only one parameter string should ever in period. (NOT BOTH)
        // Does not Add anything to strings with numbers in them
        private string AddToString(string str, string addition)
        {
            bool valid = new Regex(@"^[a-zA-Z,.']*$").IsMatch(str); // Matches if str contains letters , . or '
            if(!valid) { return str; } // Returns the str unchanged

            if (addition.Contains("."))
            {
                addition = addition.Replace(".", string.Empty);
                if (char.IsUpper(str.Last())) { addition = addition.ToUpper(); }
                str += addition += '.';
                return str;
            }
            else if(str.Contains("."))
            {
                str = str.Replace(".", string.Empty);
                if (char.IsUpper(str.Last())) { addition = addition.ToUpper(); }
                str += addition += '.';
                return str;
            }
            else 
            {
                if (char.IsUpper(str.Last())) { addition = addition.ToUpper(); }
                str += addition; return str; 
            }
        }
        // Returns the index of the first vowel in a string... -1 for no vowels 
        private int ContainsVowel(string str)
        {
            string vowels = "aeiou";
            for(int i = 0; i < str.Length; i++)
            {
                char letter = str[i];
                if(vowels.IndexOf(letter.ToString(), StringComparison.CurrentCultureIgnoreCase) >= 0) { return i; }
            }
            return -1;
        }
    }
}
