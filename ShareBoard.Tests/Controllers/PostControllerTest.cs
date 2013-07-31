using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShareBoard;
using ShareBoard.Controllers;
using ShareBoard.Models;

namespace ShareBoard.Tests.Controllers
{
    [TestClass]
    public class PostControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            PostController controller = new PostController();

            // Act
            IEnumerable<Post> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
//            Assert.AreEqual("value1", result.ElementAt(0));
//            Assert.AreEqual("value2", result.ElementAt(1));
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            PostController controller = new PostController();

            // Act
            string result = controller.Get(5);

            // Assert
            Assert.AreEqual("value", result);
        }

        [TestMethod]
        public void Post()
        {
            // Arrange
            PostController controller = new PostController();

            // Act
            controller.Post("value");

            // Assert
        }

        [TestMethod]
        public void Put()
        {
            // Arrange
            PostController controller = new PostController();

            // Act
            controller.Put(5, "value");

            // Assert
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            PostController controller = new PostController();

            // Act
            controller.Delete(5);

            // Assert
        }
    }
}
