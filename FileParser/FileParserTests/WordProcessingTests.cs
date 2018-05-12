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

    /// <summary>
    /// Contains tests for class "WordProcessing".
    /// </summary>
    [TestClass]
    public class WordProcessingTests
    {
        /// <summary>
        /// Gets or sets context of data.
        /// </summary>
        public TestContext TestContext { get; set; }

        /// <summary>
        /// Tests method "CountOfOccurrences".
        /// </summary>
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "Texts.xml",
            "text",
            DataAccessMethod.Sequential)]
        [TestMethod]
        public void CountOfOccurrencesTest()
        {           
            string text = TestContext.DataRow["currentText"].ToString();
            WordProcessing wordProcessing = new WordProcessing(text);
            string oldSubstring = TestContext.DataRow["oldSubstring"].ToString();
            int expected = Convert.ToInt32(TestContext.DataRow["countOfOccurrences"]);

            int result = wordProcessing.CountOfOccurrences(oldSubstring);

            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Tests method "ReplacedText".
        /// </summary>
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "Texts.xml",
            "text",
            DataAccessMethod.Sequential)]
        [TestMethod]
        public void ReplasedTextTest()
        {
            string text = TestContext.DataRow["currentText"].ToString();
            WordProcessing wordProcessing = new WordProcessing(text);
            string oldSubstring = TestContext.DataRow["oldSubstring"].ToString();
            string newSubstring = TestContext.DataRow["newSubstring"].ToString();
            string expected = TestContext.DataRow["replacedText"].ToString();

            string result = wordProcessing.ReplasedText(oldSubstring, newSubstring);

            Assert.AreEqual(expected, result);
        }
    }
}