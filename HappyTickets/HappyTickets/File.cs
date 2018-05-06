//---------------------------------------------
// <copyright file="File.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------
namespace HappyTickets
{
    using System.Collections.Generic;
    using System.IO;
    using System.Text; 

    /// <summary>
    /// Contains basic logic for file.
    /// </summary>
    public class File
    {
        /// <summary>
        /// File path.
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
        /// Read lines from file.
        /// </summary>
        /// <returns>List of lines.</returns>
        public List<string> Read()
        {
            List<string> lines = new List<string>();
            using (StreamReader sr = new StreamReader(this.path, Encoding.Default))
            {               
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    lines.Add(line.Trim());
                }
            }

            return lines;
        }
    }
}