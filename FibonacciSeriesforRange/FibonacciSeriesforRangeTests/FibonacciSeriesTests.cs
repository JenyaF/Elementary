//---------------------------------------------
// <copyright file="FibonacciSeriesTests.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace FibonacciSeriesforRange.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;   

    /// <summary>
    /// Contains tests for class "FibonacciSeries".
    /// </summary>
    [TestClass]
    public class FibonacciSeriesTests
    {
        /// <summary>
        /// Gets or sets context of data.
        /// </summary>
        public TestContext TestContext { get; set; }

        /// <summary>
        /// Tests method "GetStringSeries".
        /// </summary>
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "Numbers.xml",
            "number",
            DataAccessMethod.Sequential)]
        public void GetStringSeriesTest()
        {
            int lowerBound = Convert.ToInt32(TestContext.DataRow["lowerBound"]);
            int upperBound = Convert.ToInt32(TestContext.DataRow["upperBound"]);
            FibonacciSeries fibonacciSeries = new FibonacciSeries(lowerBound, upperBound);
            string expected = TestContext.DataRow["range"].ToString();

            string result = fibonacciSeries.GetStringSeries();

            StringAssert.Equals(expected, result);
        }
    }
}