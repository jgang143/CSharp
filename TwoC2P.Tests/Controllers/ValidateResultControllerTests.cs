using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoC2P.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Results;
using TwoC2P.Models;

namespace TwoC2P.Controllers.Tests
{
    [TestClass()]
    public class ValidateResultControllerTests
    {
        [TestMethod()]
        public void IsVisaValid()
        {
            // Arrange
            var controller = new ValidateResultController();

            // Act
            var result = controller.GetResult("4134567890123456", "112020") as OkNegotiatedContentResult<ValidateCard_Result>;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Visa", result.Content.CardType);
            Assert.AreEqual("Valid", result.Content.Result);          
        }

        [TestMethod()]
        public void IsMasterCardValid()
        {
            // Arrange
            var controller = new ValidateResultController();

            // Act
            var result = controller.GetResult("4134567890123456", "112021") as OkNegotiatedContentResult<ValidateCard_Result>;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("MasterCard", result.Content.CardType);
            Assert.AreEqual("Valid", result.Content.Result);
        }

        [TestMethod()]
        public void IsAmexValid()
        {
            // Arrange
            var controller = new ValidateResultController();

            // Act
            var result = controller.GetResult("343456789012345", "112020") as OkNegotiatedContentResult<ValidateCard_Result>;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Amex", result.Content.CardType);
            Assert.AreEqual("Valid", result.Content.Result);
        }

        [TestMethod()]
        public void IsJCBValid()
        {
            // Arrange
            var controller = new ValidateResultController();

            // Act
            var result = controller.GetResult("3528678901234534", "112020") as OkNegotiatedContentResult<ValidateCard_Result>;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("JCB", result.Content.CardType);
            Assert.AreEqual("Valid", result.Content.Result);
        }

        [TestMethod()]
        public void IsVisaInValid()
        {
            // Arrange
            var controller = new ValidateResultController();

            // Act
            var result = controller.GetResult("4134567890123456", "112019") as OkNegotiatedContentResult<ValidateCard_Result>;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Visa", result.Content.CardType);
            Assert.AreEqual("InValid", result.Content.Result);
        }

        [TestMethod()]
        public void IsMasterCardInValid()
        {
            // Arrange
            var controller = new ValidateResultController();

            // Act
            var result = controller.GetResult("4134567890123456", "112020") as OkNegotiatedContentResult<ValidateCard_Result>;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("MasterCard", result.Content.CardType);
            Assert.AreEqual("InValid", result.Content.Result);
        }

        [TestMethod()]
        public void IsAmexInValid()
        {
            // Arrange
            var controller = new ValidateResultController();

            // Act
            var result = controller.GetResult("34345645", "112020") as OkNegotiatedContentResult<ValidateCard_Result>;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Amex", result.Content.CardType);
            Assert.AreEqual("InValid", result.Content.Result);
        }

        [TestMethod()]
        public void IsJCBInValid()
        {
            // Arrange
            var controller = new ValidateResultController();

            // Act
            var result = controller.GetResult("3528678901", "112020") as OkNegotiatedContentResult<ValidateCard_Result>;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("JCB", result.Content.CardType);
            Assert.AreEqual("InValid", result.Content.Result);
        }

    }
}