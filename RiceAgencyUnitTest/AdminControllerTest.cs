using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rice_Agency.Controllers;
using Rice_Agency.DAL;
using Rice_Agency.Models.Home;
using Rice_Agency.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;


namespace RiceAgencyUnitTest
{

    [TestClass]
    public class AdminControllerTest
    {
        [TestMethod]
        public void Dashboard()
        {
            //Arrange
            AdminController Controller = new AdminController();

            //Act
            ViewResult result = Controller.Dashboard() as ViewResult;

            //Assert
             Assert.IsNotNull(result);

        }
        [TestMethod]
        public void ProductAdd()
        {
            //Arrange
            AdminController Controller = new AdminController();

            //Act
            ViewResult result = Controller.ProductAdd(2) as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Product()
        {
            //Arrange
            AdminController Controller = new AdminController();

            //Act
            ViewResult result = Controller.Product() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }
    }
}

