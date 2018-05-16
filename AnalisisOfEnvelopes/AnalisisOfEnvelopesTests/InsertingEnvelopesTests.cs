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

    [TestClass]
    public class InsertingEnvelopesTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "Envelopes.xml",
            "envelopes2",
            DataAccessMethod.Sequential)]
        public void Envelope2IsInsertedToEnvelope1Test()
        {
            var a = Convert.ToDouble(TestContext.DataRow["a"]);
            var b = Convert.ToDouble(TestContext.DataRow["b"]);
            var c = Convert.ToDouble(TestContext.DataRow["c"]);
            var d = Convert.ToDouble(TestContext.DataRow["d"]);
            var insertingEnvelopes = new InsertingEnvelopes(a, b, c, d);
            var expected = Convert.ToBoolean(TestContext.DataRow["Envelope2IsInsertedToEnvelope1"]);

            bool result = insertingEnvelopes.Envelope2IsInsertedToEnvelope1(new Envelope(a, b), new Envelope(c, d));

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "Envelopes.xml",
            "envelopes2",
            DataAccessMethod.Sequential)]
        public void Envelope1IsInsertedToEnvelope2Test()
        {
            var a = Convert.ToDouble(TestContext.DataRow["a"]);
            var b = Convert.ToDouble(TestContext.DataRow["b"]);
            var c = Convert.ToDouble(TestContext.DataRow["c"]);
            var d = Convert.ToDouble(TestContext.DataRow["d"]);
            var insertingEnvelopes = new InsertingEnvelopes(a, b, c, d);
            var expected = Convert.ToBoolean(TestContext.DataRow["Envelope1IsInsertedToEnvelope2"]);

            bool result = insertingEnvelopes.Envelope2IsInsertedToEnvelope1(new Envelope(c, d), new Envelope(a, b));

            Assert.AreEqual(expected, result);
        }
    }
}