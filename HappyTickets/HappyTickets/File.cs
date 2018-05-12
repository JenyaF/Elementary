//---------------------------------------------
// <copyright file="File.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------
namespace HappyTickets
{
    using System;
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
        /// Gets algorithm for select happy ticket.
        /// </summary>
        /// <returns>Algorithm for select happy ticket.</returns>
        public Algorithm GetAlgorithm()
        {
            string text;
            using (StreamReader sr = new StreamReader(this.path, Encoding.Default))
            {
                text = sr.ReadLine().Trim();
                if (Algorithm.Moskow.ToString() == text)
                {
                    return Algorithm.Moskow;
                }

                if (Algorithm.Piter.ToString() == text)
                {
                    return Algorithm.Piter;
                }

                throw new Exception("Incorrect data!");
            }
        }
    }
}