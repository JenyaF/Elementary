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

    [TestClass]
    public class TriangleTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "Triangles.xml",
            "triangle",
            DataAccessMethod.Sequential)]
        public void GetAreaTest()
        {           
            var a = Convert.ToDouble(TestContext.DataRow["a"]);
            var b = Convert.ToDouble(TestContext.DataRow["b"]);
            var c = Convert.ToDouble(TestContext.DataRow["c"]);
            var triangle = new Triangle("triangle", a, b, c);
            var expected = Convert.ToDouble(TestContext.DataRow["area"]);

            double result = triangle.GetArea();

            Assert.AreEqual(expected, result, 0.01);
        }
    }
}