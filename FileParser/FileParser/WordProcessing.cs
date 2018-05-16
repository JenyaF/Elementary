//---------------------------------------------
// <copyright file="WordProcessing.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace FileParser
{
    using System.Collections.Generic;

    public class WordProcessing 
    {       
        private string text;

        public WordProcessing(string text)
        {
            this.text = text;
        }

        public int CountOfOccurrences(string substring) => this.IndexesOf(substring).Count;

        public string GetReplasedText(string oldSubstring, string newSubstring)
        {
            string replasedText = this.text;
            List<int> indexes = this.IndexesOf(oldSubstring);

            int currentIndex = 0;
            int step = 0;
            foreach (var index in indexes)
            {
                currentIndex = index + (step * (newSubstring.Length - oldSubstring.Length));
                replasedText = replasedText.Remove(currentIndex, oldSubstring.Length).Insert(currentIndex, newSubstring);
                step++;
            }

            return replasedText;
        }

        private List<int> IndexesOf(string substring)
        {
            List<int> listOfIndexes = new List<int>();
            var index = 0;
            while (index < this.text.Length)
            {
                 index = this.text.IndexOf(substring, index, System.StringComparison.CurrentCultureIgnoreCase);
                if (index == -1)
                {
                    break;
                }

                listOfIndexes.Add(index);
                index += substring.Length;
            }          

            return listOfIndexes;
        }
    }
}
