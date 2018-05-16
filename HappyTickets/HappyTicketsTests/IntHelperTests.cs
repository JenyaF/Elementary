//---------------------------------------------
// <copyright file="IntHelperTests.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace HappyTickets.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class IntHelperTests
    {
        [TestMethod]
        public void ConvertToArrayTest_123456()
        {
            int number = 123456;
            int[] expected = { 1, 2, 3, 4, 5, 6 };

            int[] result = number.ConvertToArray(6);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ConvertToArrayTest_000123()
        {
            int number = 123;
            int[] expected = { 0, 0, 0, 1, 2, 3 };

            int[] result = number.ConvertToArray(6);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ConvertToArrayTest_000000()
        {
            int number = 0;
            int[] expected = { 0, 0, 0, 0, 0, 0 };

            int[] result = number.ConvertToArray(6);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}