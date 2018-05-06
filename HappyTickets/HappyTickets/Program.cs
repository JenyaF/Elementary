//---------------------------------------------
// <copyright file="Program.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace HappyTickets
{
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
            HappyTickets happyTickets = new HappyTickets(path);
            System.Console.WriteLine($"Count of Moskow happy tickets = {happyTickets.CountOfHappyTicketsMoskow()}");
            System.Console.WriteLine($"Count of Piter happy tickets = {happyTickets.CountOfHappyTicketsPiter()}");
        }
    }
}
