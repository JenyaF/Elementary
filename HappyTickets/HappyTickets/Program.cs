//---------------------------------------------
// <copyright file="Program.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace HappyTickets
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
            string path = args[0];
            File file = new File(path);            
            HappyTickets happyTickets = new HappyTickets(file.GetAlgorithm());
            Console.WriteLine($"Count of happy tickets = {happyTickets.CountOfHappyTicket()}");
        }
    }
}
