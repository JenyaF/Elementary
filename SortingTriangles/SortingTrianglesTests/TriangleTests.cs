//---------------------------------------------
// <copyright file="TriangleTests.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace SortingTriangles.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Contains tests for class "Triangle".
    /// </summary>
    [TestClass]
    public class TriangleTests
    {
        /// <summary>
        /// Gets or sets context of data.
        /// </summary>
        public TestContext TestContext { get; set; }

        /// <summary>
        /// Tests method "Area".
        /// </summary>
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "Triangles.xml",
            "triangle",
            DataAccessMethod.Sequential)]
        public void AreaTest()
        {
            double a = Convert.ToDouble(TestContext.DataRow["a"]);
            double b = Convert.ToDouble(TestContext.DataRow["b"]);
            double c = Convert.ToDouble(TestContext.DataRow["c"]);
            Triangle triangle = new Triangle("triangle", a, b, c);
            double expected = Convert.ToDouble(TestContext.DataRow["area"]);

            double result = triangle.Area();

            Assert.AreEqual(expected, result, 0.01);
        }
    }
}