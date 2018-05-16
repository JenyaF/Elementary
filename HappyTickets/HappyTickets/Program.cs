//---------------------------------------------
// <copyright file="Program.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace HappyTickets
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            string path = args[0];
            File file = new File(path);            
            HappyTickets happyTickets = new HappyTickets(file.GetAlgorithm());
            Console.WriteLine($"Count of happy tickets = {happyTickets.CountOfHappyTicket()}");
        }
    }
}
