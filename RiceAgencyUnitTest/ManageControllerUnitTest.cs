using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rice_Agency.Controllers;
using System.Web.Mvc;

namespace RiceAgencyUnitTest
{

    //[TestClass]
    public class ManageControllerTest
    {
        [TestMethod]
        public void AddPhoneNumber()
        {
            //Arrange
            ManageController Controller = new ManageController();

            //Act
            ViewResult result = Controller.AddPhoneNumber() as ViewResult;

            //Assert
            Assert.IsNotNull(result);

        }
        //[TestMethod]
        public void ChangePassword()
        {
            //Arrange
            ManageController Controller = new ManageController();

            //Act
            ViewResult result = Controller.ChangePassword() as ViewResult;

            //Assert
            Assert.IsNotNull(result);

        }
    }
}
