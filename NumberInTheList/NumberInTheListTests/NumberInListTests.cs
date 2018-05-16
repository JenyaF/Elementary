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
  
    [TestClass]
     public class NumberInListTests
     {
         public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "Digits.xml",
            "number",
            DataAccessMethod.Sequential)]
         [TestMethod]
         public void GetStringNumberTest()
         {
            var numberInList = new NumberInList(Convert.ToInt32(TestContext.DataRow["digits"]));
            var expected = Convert.ToString(TestContext.DataRow["stringDigits"]);

            string actual = numberInList.GetStringNumber();
                        
            StringAssert.Equals(expected, actual);
         }
     }
}