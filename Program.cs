namespace Assignment_7_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Assignment 7.1.2
             * 
             * You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, 
             * starting with word1. If a string is longer than the other, append the additional letters onto the 
             * end of the merged string. Return the merged string.
             */

            string word1 = "aceg";
            string word2 = "bdf";
            string newString = "";
            string shortWord = "";
            string longWord = "";

            if (word1.Length > word2.Length)
            {
                longWord = word1;
                shortWord = word2;
            }
            else
            {
                longWord = word2;
                shortWord = word1;
            }

            // Iterate as many times as the number of characters within the longest word
            for (int i = 0; i < longWord.Length; i++)
            {
                // While the iteration is within the length of the shorter word take a character from both words
                // If the iteration has passed the length of the shorter word, then only take characters fro mthe longer word
                if (i <= shortWord.Length - 1)
                    newString += word1[i].ToString() + word2[i].ToString();
                else newString += longWord[i].ToString();
            }
            
            Console.WriteLine(newString);
        }
    }
}
