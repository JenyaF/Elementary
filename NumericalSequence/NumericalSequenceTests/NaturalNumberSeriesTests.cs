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
   
    [TestClass]
    public class NaturalNumberSeriesTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "Numbers.xml",
            "number",
            DataAccessMethod.Sequential)]
        public void StringSquaresNumberLessThenNTest()
        {
            var n = Convert.ToInt32(TestContext.DataRow["n"]);
            var naturalNumberSeries = new NaturalNumberSeries(n);
            var expected = TestContext.DataRow["lessNumbers"].ToString();
            bool isFinish;

            var result = naturalNumberSeries.FoundSquaresNumberLessThenN(out isFinish).ToString();

            Assert.AreEqual(expected, result);
        }
    }
}