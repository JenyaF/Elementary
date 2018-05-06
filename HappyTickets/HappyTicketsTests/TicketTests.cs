//---------------------------------------------
// <copyright file="TicketTests.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace HappyTickets.Tests
{
    using System;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Contains tests for class "Ticket".
    /// </summary>
    [TestClass]
    public class TicketTests
    {
        /// <summary>
        /// Gets or sets context of data.
        /// </summary>
        public TestContext TestContext { get; set; }

        /// <summary>
        /// Tests method "IsHappy".
        /// </summary>
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Tickets.xml", "number", DataAccessMethod.Sequential)]
        public void IsHappyMoskowTest()
        {
            int[] number = TestContext.DataRow["content"].ToString().Select(x => Convert.ToInt32(x)).ToArray();
            Ticket ticket = new Ticket(number);
            bool expected = Convert.ToBoolean(TestContext.DataRow["IsHappyMoskow"]);

            bool result = ticket.IsHappyMoskow();
           
            Assert.AreEqual(result, expected);
        }

        /// <summary>
        /// Tests method "IsHappy".
        /// </summary>
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Tickets.xml", "number", DataAccessMethod.Sequential)]
        public void IsHappyPiterTest()
        {
            int[] number = TestContext.DataRow["content"].ToString().Select(x => Convert.ToInt32(x)).ToArray();
            Ticket ticket = new Ticket(number);
            bool expected = Convert.ToBoolean(TestContext.DataRow["IsHappyPiter"]);

            bool result = ticket.IsHappyPiter();

            Assert.AreEqual(result, expected);
        }
    }
}