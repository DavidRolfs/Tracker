using Tracker.Models;
using Xunit;

namespace Tracker.Tests
{
    public class AssociateTest
    {
        [Fact]
        public void GetDescriptionTest()
        {
            //Arrange
            var Associate = new Associate();
            Associate.Name = "Joe";
            //Act
            var result = Associate.Name;

            //Assert
            Assert.Equal("Joe", result);
        }
    }
}
