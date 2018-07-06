using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCountersControllerTest
    {
      [TestMethod]
        public void Index_ReturnsCorrectView_True()
        {
            //Arrange
            WordCountersController controller = new WordCountersController();

            //Act
            ActionResult indexView = controller.Index();

            //Assert
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }
        [TestMethod]
        public void Index_HasCorrectModelType_ItemList()
        {
            //Arrange
            ViewResult indexView = new WordCountersController().Index() as ViewResult;

            //Act
            var result = indexView.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(List<RepeatCounter>));
        }
        [TestMethod]
          public void CreateForm_ReturnsCorrectView_True()
          {
              //Arrange
              WordCountersController controller = new WordCountersController();

              //Act
              ActionResult indexView = controller.CreateForm();

              //Assert
              Assert.IsInstanceOfType(indexView, typeof(ViewResult));
          }
    }
}
