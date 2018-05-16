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

    [TestClass]
    public class FibonacciSeriesTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "Numbers.xml",
            "number",
            DataAccessMethod.Sequential)]
        public void GetStringSeriesTest()
        {
            var lowerBound = Convert.ToInt32(TestContext.DataRow["lowerBound"]);
            var upperBound = Convert.ToInt32(TestContext.DataRow["upperBound"]);
            var fibonacciSeries = new FibonacciSeries(lowerBound, upperBound);
            var expected = TestContext.DataRow["range"].ToString();

            string result = fibonacciSeries.GetStringSeries();

            StringAssert.Equals(expected, result);
        }
    }
}