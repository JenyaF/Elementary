//---------------------------------------------
// <copyright file="File.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace FileParser
{
    using System.IO;

    /// <summary>
    /// Contains basic logic for working with file.
    /// </summary>
    public class File
    {
        /// <summary>
        /// File path
        /// </summary>
        private string path;

        /// <summary>
        /// Initializes a new instance of the <see cref="File"/> class.
        /// </summary>
        /// <param name="path">File path.</param>
        public File(string path)
        {
            this.path = path;
        }

        /// <summary>
        /// Read text from file.
        /// </summary>
        /// <returns>Text from file.</returns>
        public string Read()
        {
            string text;
            using (StreamReader sr = new StreamReader(this.path, System.Text.Encoding.Default))
            {
                text = sr.ReadToEnd();
            }

            return text;
        }

        /// <summary>
        /// Write text to file.
        /// </summary>
        /// <param name="text">text for writing to file.</param>
        public void Write(string text)
        {
            using (StreamWriter sw = new StreamWriter(this.path, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(text);
            }
        }
    }
}
