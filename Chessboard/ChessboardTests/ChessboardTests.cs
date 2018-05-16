//---------------------------------------------
// <copyright file="ChessboardTests.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------
namespace Chessboard.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;   

    [TestClass]
    public class ChessboardTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "testData.xml",
            "Field",
            DataAccessMethod.Sequential)]
        public void GetFieldTest()
        {
            var height = Convert.ToInt32(TestContext.DataRow["height"]);
            var width = Convert.ToInt32(TestContext.DataRow["height"]);
            var expected = TestContext.DataRow["content"].ToString();
            var chessboard = new Chessboard(height, width);
             
            string result = chessboard.GetField();

            StringAssert.Equals(expected, result);
        }
    }
}