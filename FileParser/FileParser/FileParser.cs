//---------------------------------------------
// <copyright file="FileParser.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace FileParser
{
    using System.IO;

    /// <summary>
    /// Contains basic logic for file parsing.
    /// </summary>
    public class FileParser
    {
        #region
        /// <summary>
        /// Text for processing.
        /// </summary>
        private WordProcessing wordProcessing;

        /// <summary>
        /// Old substring.
        /// </summary>
        private string substring;

        /// <summary>
        /// New substring.
        /// </summary>
        private string newSubstring;

        /// <summary>
        /// File path.
        /// </summary>
        private string path;
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="FileParser"/> class.
        /// </summary>
        /// <param name="path">Path for file.</param>
        /// <param name="substring">Substring for processing.</param>
        public FileParser(string path, string substring)
        {
            this.path = path;
            this.substring = substring;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileParser"/> class.
        /// </summary>
        /// <param name="path">Path for file.</param>
        /// <param name="oldSubstring">Substring for processing.</param>
        /// <param name="newSubstring">Substring for replacement.</param>
        public FileParser(string path, string oldSubstring, string newSubstring) 
            : this(path, oldSubstring)
        {
            this.newSubstring = newSubstring;
        }

        /// <summary>
        /// Gets count of occurrences substring in file.
        /// </summary>
        /// <returns>Count of occurrences substring in file.</returns>
        public int CountOfOccurrences()
        {
            if (File.Exists(this.path))
            {
                string text = File.ReadAllText(this.path);
                this.wordProcessing = new WordProcessing(text);
                return this.wordProcessing.CountOfOccurrences(this.substring);
            }

            return -1;
        }

        /// <summary>
        /// Replaces substring in file.
        /// </summary>
        /// <returns>If success.</returns>
        public bool ReplaseText()
        {           
            if (File.Exists(this.path))
            {
                string text = File.ReadAllText(this.path);
                this.wordProcessing = new WordProcessing(text);
                string newText = this.wordProcessing.ReplasedText(this.substring, this.newSubstring);
                File.WriteAllText(this.path, newText, System.Text.Encoding.UTF8);
                return true;
            }

            return false;
        }
    }
}
