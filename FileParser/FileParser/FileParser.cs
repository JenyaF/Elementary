//---------------------------------------------
// <copyright file="FileParser.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace FileParser
{
    /// <summary>
    /// Contains basic logic for file parsing.
    /// </summary>
    public class FileParser
    {
        #region
        /// <summary>
        /// File for processing.
        /// </summary>
        private File file;

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
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="FileParser"/> class.
        /// </summary>
        /// <param name="path">Path for file.</param>
        /// <param name="substring">Substring for processing.</param>
        public FileParser(string path, string substring)
        {
            this.file = new File(path);
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
            this.wordProcessing = this.CreateWordProcessing();
            return this.wordProcessing.CountOfOccurrences(this.substring);
        }

        /// <summary>
        /// Replaces substring in file.
        /// </summary>
        public void ReplaseText()
        {
            this.wordProcessing = this.CreateWordProcessing();
            string newText = this.wordProcessing.ReplasedText(this.substring, this.newSubstring);
            this.file.Write(newText);
        }

        /// <summary>
        /// Creates a new instance of the "WordProcessing" class.
        /// </summary>
        /// <returns>New instance of the "WordProcessing" class.</returns>
        private WordProcessing CreateWordProcessing()
        {
            string text = this.file.Read();
            return new WordProcessing(text);
        }
    }
}
