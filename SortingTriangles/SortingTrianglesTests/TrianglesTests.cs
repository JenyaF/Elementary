//---------------------------------------------
// <copyright file="TrianglesTests.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace SortingTriangles.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    /// <summary>
    /// Contains tests for class "Triangles".
    /// </summary>
    [TestClass]
    public class TrianglesTests
    {
        /// <summary>
        /// Tests method "AddTriangle".
        /// </summary>
        [TestMethod]
        public void AddTriangleTest()
        {
            Triangles triangles = new Triangles();
            Mock<ITriangle> mockTriangle = new Mock<ITriangle>();
            
            mockTriangle.Setup(x => x.IsTriangleExist()).Returns(true);
            triangles.AddTriangle(mockTriangle.Object);
            Assert.AreEqual(triangles.ListOfTriangle.Count, 1);
        }

        /// <summary>
        /// Tests method "AddTriangle" in a case of exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AddTriangleTest_Exception()
        {
            Triangles triangles = new Triangles();
            Mock<ITriangle> mockTriangle = new Mock<ITriangle>();

            mockTriangle.Setup(x => x.IsTriangleExist()).Returns(false);    
            triangles.AddTriangle(mockTriangle.Object);
        }
    }
}