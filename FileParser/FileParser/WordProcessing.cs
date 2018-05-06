//---------------------------------------------
// <copyright file="WordProcessing.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace FileParser
{
    using System.Collections.Generic;

    /// <summary>
    /// Contains basic logic for working with text.
    /// </summary>
    public class WordProcessing
    {       
        /// <summary>
        /// Text for working.
        /// </summary>
        private string text;

        /// <summary>
        /// Initializes a new instance of the <see cref="WordProcessing"/> class.
        /// </summary>
        /// <param name="text">Text for processing.</param>
        public WordProcessing(string text)
        {
            this.text = text;
        }

        /// <summary>
        /// Gets count of occurrences of given substring in text.
        /// </summary>
        /// <param name="substring">Substring for count.</param>
        /// <returns>Count of occurrences of given substring in text.</returns>
        public int CountOfOccurrences(string substring) => this.IndexesOf(substring).Count;

        /// <summary>
        /// Gets replaced text.
        /// </summary>
        /// <param name="oldSubstring">Old substring.</param>
        /// <param name="newSubstring">New substring.</param>
        /// <returns>Replaced text.</returns>
        public string ReplasedText(string oldSubstring, string newSubstring)
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

        /// <summary>
        /// Find indexes of occurrence substring in text.
        /// </summary>
        /// <param name="substring">substring for searching</param>
        /// <returns>List of indexes.</returns>
        private List<int> IndexesOf(string substring)
        {
            string lowerSubstring = substring.ToLower();
            string lowerText = this.text.ToLower();
            List<int> listOfIndexes = new List<int>();
            for (var i = 0; i < lowerText.Length; i++)
            {
                if (lowerText[i] == lowerSubstring[0])
                {
                    if (lowerText.Substring(i, lowerSubstring.Length) == lowerSubstring)
                    {
                        listOfIndexes.Add(i);
                    }
                }
            }

            return listOfIndexes;
        }
    }
}
