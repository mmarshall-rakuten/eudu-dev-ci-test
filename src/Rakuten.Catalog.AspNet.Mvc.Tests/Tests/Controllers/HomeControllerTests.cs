
namespace Rakuten.Catalog.AspNet.Mvc.Tests.Tests.Controllers
{
    using System.Web.Mvc;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Rakuten.Catalog.AspNet.Mvc.Controllers;

    /// <summary>
    /// The suite of tests for the <see cref="HomeController"/> class.
    /// </summary>
    [TestClass]
    public class HomeControllerTests
    {
        /// <summary>
        /// Ensures that a non null result is returned when the Index method is invoked.
        /// </summary>
        [TestMethod]
        public void HomeControllerIndexReturnsANonNullView()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var view = controller.Index();

            // Assert
            Assert.IsNotNull(view);
        }

        /// <summary>
        /// Ensures that a <see cref="ViewResult"/> instance is returned from the Index method.
        /// </summary>
        [TestMethod]
        public void HomeControllerIndexReturnsAViewResult()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var view = controller.Index();

            // Assert
            Assert.IsInstanceOfType(view, typeof(ViewResult));
        }
    }
}
