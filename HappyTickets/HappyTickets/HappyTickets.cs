//---------------------------------------------
// <copyright file="HappyTickets.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace HappyTickets
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Contains basic logic for tickets.
    /// </summary>
    public class HappyTickets
    {
        /// <summary>
        /// List of tickets.
        /// </summary>
        private List<Ticket> tickets = new List<Ticket>();

        /// <summary>
        /// File for reading data.
        /// </summary>
        private File file;

        /// <summary>
        ///  Initializes a new instance of the <see cref="HappyTickets"/> class.
        /// </summary>
        /// <param name="path">Path of file.</param>
        public HappyTickets(string path)
        {
            this.file = new File(path);
            this.AddTicketsFromFile();
        }

        /// <summary>
        /// Converts string number to integer.
        /// </summary>
        /// <param name="text">String number.</param>
        /// <returns>number of ticket.</returns>
        public int[] GetNumberOfTicket(string text)
        {
            text = text.Trim();
            int number = Math.Abs(Convert.ToInt32(text));
            if (Ticket.CountOfDigits == text.Length)
            {
                int[] digits = new int[text.Length];
                for (var i = 0; i < Ticket.CountOfDigits; i++)
                {
                    digits[i] = Convert.ToInt32(text[i].ToString());
                }

                return digits;
            }

            throw new Exception($"Ticket contains only {Ticket.CountOfDigits} digits!");
        }

        /// <summary>
        /// add tickets from file.
        /// </summary>
        public void AddTicketsFromFile()
        {
            List<string> lines = this.file.Read();
            foreach (var line in lines)
            {
                try
                {
                    int[] numberOfTicket = this.GetNumberOfTicket(line);
                    Ticket ticket = new Ticket(numberOfTicket);
                    this.tickets.Add(ticket);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Incorrect data in  the line of file! The line will be ignored.");
                    continue;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + " The line will be ignored.");
                    continue;
                }
            }
        }

        /// <summary>
        /// count the number of happy ticket in one way.
        /// </summary>
        /// <returns> Number of happy ticket.</returns>
        public int CountOfHappyTicketsMoskow() => this.tickets.Count(ticket => ticket.IsHappyMoskow());

        /// <summary>
        /// count the number of happy ticket in one way.
        /// </summary>
        /// <returns> Number of happy ticket.</returns>
        public int CountOfHappyTicketsPiter() => this.tickets.Count(ticket => ticket.IsHappyPiter());
    }
}