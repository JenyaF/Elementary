//---------------------------------------------
// <copyright file="FileParser.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace FileParser
{
    using System.IO;

    public class FileParser
    {
        private WordProcessing wordProcessing;
        private readonly string substring;
        private readonly string newSubstring;
        private readonly string path;

        public FileParser(string path, string substring)
        {
            this.path = path;
            this.substring = substring;
        }

        public FileParser(string path, string oldSubstring, string newSubstring) 
            : this(path, oldSubstring)
        {
            this.newSubstring = newSubstring;
        }

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

        public bool ReplaseText()
        {           
            if (File.Exists(this.path))
            {
                string text = File.ReadAllText(this.path);
                this.wordProcessing = new WordProcessing(text);
                string newText = this.wordProcessing.GetReplasedText(this.substring, this.newSubstring);
                File.WriteAllText(this.path, newText, System.Text.Encoding.UTF8);
                return true;
            }

            return false;
        }
    }
}
