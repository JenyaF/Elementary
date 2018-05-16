//---------------------------------------------
// <copyright file="Program.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace FileParser
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            FileParser fileParser;
            string path = args[0];
            string substring = args[1];
            if (args.Length == 2)
            {
                fileParser = new FileParser(path, substring);
                int countOfOccurrences = fileParser.CountOfOccurrences();
                if (countOfOccurrences != -1)
                {
                    Console.WriteLine($"Count of occurence = {countOfOccurrences}.");
                }
                else
                {
                    Console.WriteLine("File doesn't exist!");
                }
            }
            else
            {
                string newSubstring = args[2];
                fileParser = new FileParser(path, substring, newSubstring);
                bool result = fileParser.ReplaseText();
                if (result)
                {
                     Console.WriteLine("Done.");
                }
                else
                {
                    Console.WriteLine("File doesn't exist!");
                }              
            }
        }
    }
}