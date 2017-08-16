using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Tracker.Controllers;
using Tracker.Models;
using Xunit;
using Moq;
using System.Linq;
using Tracker.Test.Models;

namespace Tracker.Tests
{
    public class AssociateControllerTest
    {
            Mock<IAssociateRepository> mock = new Mock<IAssociateRepository>();
            EFAssociateRepository db = new EFAssociateRepository(new TestDbContext());

        private void DbSetup()
        {
            mock.Setup(m => m.Associates).Returns(new Associate[]
            {
                new Associate {Id = 1, Name = "joe", SalesTotal = "2" },
                new Associate {Id = 2, Name = "paul", SalesTotal = "2200"},
                new Associate {Id = 3, Name = "steve", SalesTotal = "2200"}
            }.AsQueryable());
        }
        [Fact]
        public void Mock_GetViewResultIndex_Test() //Confirms route returns view
        {
            //Arrange
            DbSetup();
            AssociateController controller = new AssociateController(mock.Object);

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Mock_IndexListOfItems_Test() //Confirms model as list of items
        {
            // Arrange
            DbSetup();
            ViewResult indexView = new AssociateController(mock.Object).Index() as ViewResult;

            // Act
            var result = indexView.ViewData.Model;

            // Assert
            Assert.IsType<List<Associate>>(result);
        }
        [Fact]
        public void Mock_ConfirmEntry_Test() //Confirms presence of known entry
        {
            // Arrange
            DbSetup();
            AssociateController controller = new AssociateController(mock.Object);
            Associate testAssociate = new Associate();
            testAssociate.Name = "joe";
            testAssociate.Id = 1;
            testAssociate.SalesTotal = "2";

            // Act
            ViewResult indexView = controller.Index() as ViewResult;
            var collection = indexView.ViewData.Model as IEnumerable<Associate>;

            // Assert
            Assert.Contains<Associate>(testAssociate, collection);
        }
        [Fact]
        public void DB_CreateNewEntry_Test()
        {
            // Arrange
            AssociateController controller = new AssociateController(db);
            Associate testAssociate = new Associate();
            testAssociate.Name = "TestDb Item";

            // Act
            controller.Create(testAssociate);
            var collection = (controller.Index() as ViewResult).ViewData.Model as IEnumerable<Associate>;

            // Assert
            Assert.Contains<Associate>(testAssociate, collection);
        }
    }
}
