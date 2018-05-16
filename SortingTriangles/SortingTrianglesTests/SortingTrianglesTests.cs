//---------------------------------------------
// <copyright file="SortingTrianglesTests.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace SortingTriangles.Tests
{
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SortingTrianglesTests
    {
        [TestMethod]
        public void SortByDescendingTest()
        {
            var sortingTriangles = new SortingTriangles();
            var triangle1 = new Triangle("t1", 1, 1, 1);
            var triangle2 = new Triangle("t2", 5, 5, 5);
            var triangle3 = new Triangle("t3", 3, 3, 3);
            var triangle4 = new Triangle("t4", 2, 2, 2);
            var triangles = new List<Triangle>() { triangle1, triangle2, triangle3, triangle4 };
            sortingTriangles.ListOfTriangles.AddRange(triangles);
            List<Triangle> expected = new List<Triangle>() { triangle2, triangle3, triangle4, triangle1 };

            sortingTriangles.SortByAreaByDescending();

            CollectionAssert.AreEqual(sortingTriangles.ListOfTriangles, expected);
        }
    }
}