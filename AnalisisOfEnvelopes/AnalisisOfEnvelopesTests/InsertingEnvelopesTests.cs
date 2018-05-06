//---------------------------------------------
// <copyright file="InsertingEnvelopesTests.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace AnalisisOfEnvelopes.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Contains tests for class "InsertingEnvelopes".
    /// </summary>
    [TestClass]
    public class InsertingEnvelopesTests
    {
        /// <summary>
        /// Gets or sets context of test.
        /// </summary>
        public TestContext TestContext { get; set; }

        /// <summary>
        /// Tests method "Envelope2IsInsertedToEnvelope1".
        /// </summary>
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "Envelopes.xml",
            "envelopes2",
            DataAccessMethod.Sequential)]
        public void Envelope2IsInsertedToEnvelope1Test()
        {
            double a = Convert.ToDouble(TestContext.DataRow["a"]);
            double b = Convert.ToDouble(TestContext.DataRow["b"]);
            double c = Convert.ToDouble(TestContext.DataRow["c"]);
            double d = Convert.ToDouble(TestContext.DataRow["d"]);
            InsertingEnvelopes insertingEnvelopes = new InsertingEnvelopes(a, b, c, d);
            bool expected = Convert.ToBoolean(TestContext.DataRow["Envelope2IsInsertedToEnvelope1"]);

            bool result = insertingEnvelopes.Envelope2IsInsertedToEnvelope1(new Envelope(a, b), new Envelope(c, d));

            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Tests method "Envelope1IsInsertedToEnvelope2".
        /// </summary>
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "Envelopes.xml",
            "envelopes2",
            DataAccessMethod.Sequential)]
        public void Envelope1IsInsertedToEnvelope2Test()
        {
            double a = Convert.ToDouble(TestContext.DataRow["a"]);
            double b = Convert.ToDouble(TestContext.DataRow["b"]);
            double c = Convert.ToDouble(TestContext.DataRow["c"]);
            double d = Convert.ToDouble(TestContext.DataRow["d"]);
            InsertingEnvelopes insertingEnvelopes = new InsertingEnvelopes(a, b, c, d);
            bool expected = Convert.ToBoolean(TestContext.DataRow["Envelope1IsInsertedToEnvelope2"]);

            bool result = insertingEnvelopes.Envelope2IsInsertedToEnvelope1(new Envelope(c, d), new Envelope(a, b));

            Assert.AreEqual(expected, result);
        }
    }
}