using Microsoft.VisualStudio.TestTools.UnitTesting;
using PictureManager.BLL;
using System.IO;

namespace PircuteManager.Tetsts
{
    [TestClass]
    public class PictureTests
    {
        [TestMethod]
        public void Picture_GetFileTypeByExtension_PASS()
        {
            // Arrange

            // Act
            var picture = new Picture("c:\\image.jpg");
            // Assert
            Assert.AreEqual(FileType.JPG, picture.FileType);
        }

        [TestMethod]
        public void Picture_GetFileTypeByExtension_ReturnsUNDEFINED()
        {
            // Arrange

            // Act
            var picture = new Picture("c:\\image.bla");
            // Assert
            Assert.AreEqual(FileType.UNDEFINED, picture.FileType);
        }

        [TestMethod]
        public void Picture_GetFileNameWithoutExtension_Pass()
        {
            // Arrange

            // Act
            var picture = new Picture("c:\\image.jpg");
            // Assert
            Assert.AreEqual("img1", picture.Name);
        }

        [TestMethod]
        public void Picture_GetFileNameWithoutExtension_ShouldThrowFileNotFoundExtension()
        {
            // Arrange

            // Act
            var picture = new Picture("c:\\image.jpg");
            // Assert
            Assert.AreEqual("img1", picture.Name);
        }
    }
}
