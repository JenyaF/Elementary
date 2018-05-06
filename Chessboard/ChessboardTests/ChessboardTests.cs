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

    /// <summary>
    /// Contains tests for class "Chessboard".
    /// </summary>
    [TestClass]
    public class ChessboardTests
    {
        /// <summary>
        /// Gets or sets context of data.
        /// </summary>
        public TestContext TestContext { get; set; }

        /// <summary>
        /// Tests method "GetField".
        /// </summary>
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "testData.xml",
            "Field",
            DataAccessMethod.Sequential)]
        public void GetFieldTest()
        {
            int height = Convert.ToInt32(TestContext.DataRow["height"]);
            int width = Convert.ToInt32(TestContext.DataRow["height"]);
            string expected = TestContext.DataRow["content"].ToString();
            Chessboard chessboard = new Chessboard(height, width);
             
            string result = chessboard.GetField();

            StringAssert.Equals(expected, result);
        }
    }
}