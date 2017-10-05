using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace WorksheetBuilder.CommonTests
{
    [TestClass]
    public class OptionListTests
    {
        [TestMethod]
        public void Sort_LastListElement_IsOther()
        {
            // Arrange
            var testOptions = new OptionList(new List<string> { "Other", "Option 1", "Option 2" });

            // Act
            testOptions.Sort();

            // Assert
            Assert.AreEqual(testOptions.Options[2], "Other");
        }
    }
}
