using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp;

namespace David.Tests
{
    [TestClass]
    public class WrapperTests
    {
        [TestMethod]
        public void AnEmptyStringReturnsAnEmptyString()
        {
            var wrapper = new Wrapper();
            var theText = "";
            var columnWidth = 10;
            var expectedResult = "";

            var actualResult = wrapper.WrapText(theText, columnWidth);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AStringShorterThanTheColumnWidthIsReturnedUnaltered()
        {
            var wrapper = new Wrapper();
            var theText = "Hello";
            var columnWidth = 30;
            var expectedResult = "Hello";

            var actualResult = wrapper.WrapText(theText, columnWidth);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ASingleLongWordIsChoppedAtTheColumnWidth()
        {
            var wrapper = new Wrapper();
            var theText = "Hello";
            var columnWidth = 3;
            var expectedResult = "Hel\nlo";

            var actualResult = wrapper.WrapText(theText, columnWidth);

            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void ASingleVeryLongWordIsChoppedAtTheColumnWidths()
        {
            var wrapper = new Wrapper();
            var theText = "HelloWorld";
            var columnWidth = 3;
            var expectedResult = "Hel\nloW\norl\nd";

            var actualResult = wrapper.WrapText(theText, columnWidth);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TwoWordsAreChoppedOnTheSpaceRatherThanOnTheColumnWidth()
        {
            var wrapper = new Wrapper();
            var theText = "Hello World";
            var columnWidth = 7;
            var expectedResult = "Hello \nWorld";

            var actualResult = wrapper.WrapText(theText, columnWidth);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ThreeWordsAreChoppedOnTheSpacesRatherThanOnTheColumnWidth()
        {
            var wrapper = new Wrapper();
            var theText = "York Code Dojo";
            var columnWidth = 6;
            var expectedResult = "York \nCode \nDojo";

            var actualResult = wrapper.WrapText(theText, columnWidth);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ASingleLongWordIsChoppedAtAHyphen()
        {
            var wrapper = new Wrapper();
            var theText = "York-Code-Dojo";
            var columnWidth = 10;
            var expectedResult = "York-Code\n-Dojo";

            var actualResult = wrapper.WrapText(theText, columnWidth);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
