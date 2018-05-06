//---------------------------------------------
// <copyright file="NaturalNumberSeriesTests.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace NumericalSequence.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
   
    /// <summary>
    /// Class for test class "NaturalNumberSeries".
    /// </summary>
    [TestClass]
    public class NaturalNumberSeriesTests
    {
        /// <summary>
        /// Gets or sets context of data.
        /// </summary>
        public TestContext TestContext { get; set; }

        /// <summary>
        /// Tests method "StringSquaresNumberLessThenN".
        /// </summary>
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Numbers.xml", "number", DataAccessMethod.Sequential)]
        public void StringSquaresNumberLessThenNTest()
        {
            int n = Convert.ToInt32(TestContext.DataRow["n"]);
            NaturalNumberSeries naturalNumberSeries = new NaturalNumberSeries(n);
            string expected = TestContext.DataRow["lessNumbers"].ToString();

            string result = naturalNumberSeries.StringSquaresNumberLessThenN();

            StringAssert.Equals(expected, result);
        }
    }
}