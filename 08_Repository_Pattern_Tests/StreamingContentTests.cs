using System;
using _08_Repository_Pattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_Repository_Pattern_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void StreamingContent_SetTitle_ShouldBeCorrectString()
        {
            //--Arrange
            StreamingContent content = new StreamingContent();
            content.Title = "Bolt";

            //--Act
            var actual = content.Title;
            var expected = "Bolt";

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StreamingContent_SetIsMatureBoolean_ShouldReturnTrue()
        {
            //--Arrange
            StreamingContent content = new StreamingContent();
            content.IsMature = true;

            //--Act
            var actual = content.IsMature;
            var expected = true;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StreamingContent_Constructor_ShouldHoldCorrectValues()
        {
            //--Arrange
            StreamingContent content = new StreamingContent("Star Wars", "Space Adventure", 5, false);

            //--Act
            var actual = content.Title;
            var expected = "Star Wars";

            var actualTwo = content.IsMature;
            var expectedTwo = false;

            //--Assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedTwo, actualTwo);

        }
    }
}
