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

    public class File
    {
        private string path;

        public File(string path)
        {
            this.path = path;
        }

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