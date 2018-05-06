//---------------------------------------------
// <copyright file="NumberInListTests.cs" company="SoftServe">
//  Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace NumberInTheList.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
  
    /// <summary>
    /// Test method in class " NumberInListTests".
    /// </summary>
    [TestClass]
     public class NumberInListTests
     {
        /// <summary>
        /// Gets or sets context of test.
        /// </summary>
         public TestContext TestContext { get; set; }

        /// <summary>
        /// Tests method "GetStringNumber".
        /// </summary>
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "Digits.xml",
            "number",
            DataAccessMethod.Sequential)]
         [TestMethod]
         public void GetStringNumberTest()
         {
            NumberInList numberInList = new NumberInList(Convert.ToInt32(TestContext.DataRow["digits"]));
            string expected = Convert.ToString(TestContext.DataRow["stringDigits"]).Trim();

            string actual = numberInList.GetStringNumber().Trim();
                        
            StringAssert.Equals(expected, actual);
         }
     }
}