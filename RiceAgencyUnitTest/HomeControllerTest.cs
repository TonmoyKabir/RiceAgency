using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rice_Agency.DAL;
using Rice_Agency.Models;
using Rice_Agency.Models.Home;
using Rice_Agency.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rice_Agency.Controllers;
using Rice_Agency.Views.Home;

namespace RiceAgencyUnitTest
{
    [TestClass]
    public class ControllerTest
    {
        [TestMethod]
        public void Checkout()
        {
            //Arrange
            HomeController Controller = new HomeController();

            //Act
            ViewResult result = Controller.Checkout() as ViewResult;

            //Assert
            Assert.IsNotNull(result);

        }
        [TestMethod]
        public void RemoveFromCart()
        {
            //Arrange
            HomeController Controller = new HomeController();

            //Act
            ViewResult result = Controller.RemoveFromCart() as ViewResult;

            //Assert
            Assert.IsNotNull(result);

        }

    }
}
