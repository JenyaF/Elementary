//---------------------------------------------
// <copyright file="Program.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace FileParser
{
    using System;

    /// <summary>
    /// Class for starting program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Starts program.
        /// </summary>
        /// <param name="args">Arguments that are passed at startup.</param>
        public static void Main(string[] args)
        {
            FileParser fileParser;
            string path = args[0];
            string substring = args[1];
            if (args.Length == 2)
            {
                fileParser = new FileParser(path, substring);
                Console.WriteLine($"Count of occurence = {fileParser.CountOfOccurrences()}.");
            }
            else
            {
                string newSubstring = args[2];
                fileParser = new FileParser(path, substring, newSubstring);
                fileParser.ReplaseText();
                Console.WriteLine("Done.");
            }
        }
    }
}