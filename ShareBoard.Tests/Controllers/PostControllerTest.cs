﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            IEnumerable<PostItem> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
//            Assert.AreEqual("value1", result.ElementAt(0));
//            Assert.AreEqual("value2", result.ElementAt(1));
        }

        [TestMethod]
        public void Post()
        {
            // Arrange
            PostController controller = new PostController();

            // Act
//            controller.Post("value");

            // Assert
        }
    }
}
