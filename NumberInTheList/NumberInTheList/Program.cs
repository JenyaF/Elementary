//---------------------------------------------
// <copyright file="Program.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------
namespace NumberInTheList
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
            int number = Convert.ToInt32(args[0]);
            NumberInList numberInList = new NumberInList(number);
            Console.WriteLine(numberInList.GetStringNumber());
        }
    }
}
