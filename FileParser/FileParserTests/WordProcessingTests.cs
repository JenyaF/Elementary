//---------------------------------------------
// <copyright file="WordProcessingTests.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace FileParser.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class WordProcessingTests
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "Texts.xml",
            "text",
            DataAccessMethod.Sequential)]
        [TestMethod]
        public void CountOfOccurrencesTest()
        {           
            var text = TestContext.DataRow["currentText"].ToString();
            var wordProcessing = new WordProcessing(text);
            var oldSubstring = TestContext.DataRow["oldSubstring"].ToString();
            var expected = Convert.ToInt32(TestContext.DataRow["countOfOccurrences"]);

            int result = wordProcessing.CountOfOccurrences(oldSubstring);

            Assert.AreEqual(expected, result);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "Texts.xml",
            "text",
            DataAccessMethod.Sequential)]
        [TestMethod]
        public void GetReplasedTextTest()
        {
            var text = TestContext.DataRow["currentText"].ToString();
            var wordProcessing = new WordProcessing(text);
            var oldSubstring = TestContext.DataRow["oldSubstring"].ToString();
            var newSubstring = TestContext.DataRow["newSubstring"].ToString();
            var expected = TestContext.DataRow["replacedText"].ToString();

            string result = wordProcessing.GetReplasedText(oldSubstring, newSubstring);

            Assert.AreEqual(expected, result);
        }
    }
}