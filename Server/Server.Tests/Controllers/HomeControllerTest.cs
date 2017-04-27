using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Server;
using Server.Controllers;

namespace Server.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        

        //bandomas testas nr.1
        [TestMethod]
        public void WhatIsViewTest()
        {
            // Arrange
            var  controller = new HomeController();

            // Act
            var result = controller.WhatIsViewTest() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
