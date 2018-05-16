//---------------------------------------------
// <copyright file="HappyTicketsTests.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace HappyTickets.Tests
{
    using System;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class HappyTicketsTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Tickets.xml", "number", DataAccessMethod.Sequential)]
        public void IsHappyMoskowTest()
        {
            int[] number = TestContext.DataRow["content"].ToString().Select(x => Convert.ToInt32(x)).ToArray();
            HappyTickets tickets = new HappyTickets(Algorithm.Moskow);
            bool expected = Convert.ToBoolean(TestContext.DataRow["IsHappyMoskow"]);

            bool result = tickets.IsHappyMoskow(number);

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Tickets.xml", "number", DataAccessMethod.Sequential)]
        public void IsHappyPiterTest()
        {
            int[] number = TestContext.DataRow["content"].ToString().Select(x => Convert.ToInt32(x)).ToArray();
            HappyTickets tickets = new HappyTickets(Algorithm.Piter);
            bool expected = Convert.ToBoolean(TestContext.DataRow["IsHappyPiter"]);

            bool result = tickets.IsHappyPiter(number);

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void CountOfHappyTicketsTest_Moskow()
        {
            HappyTickets tickets = new HappyTickets(Algorithm.Moskow);
            int expected = 55252;

            int result = tickets.CountOfHappyTicket();

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void CountOfHappyTicketsTest_Piter()
        {
            HappyTickets tickets = new HappyTickets(Algorithm.Piter);
            int expected = 55252;

            int result = tickets.CountOfHappyTicket();

            Assert.AreEqual(result, expected);
        }
    }
}