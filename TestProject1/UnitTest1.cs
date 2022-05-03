using Xunit;
using AssignmentExemplar_Code;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CommercialPropertyToStringTest1()
        {
            //Arrange
            Commercial propertyToTest;

            //Act
            propertyToTest = new Commercial("Street Name", "City Name", "Address", enums.CommercialType.OFFICE, 100, "Business Name");
            var TestString = propertyToTest.ToString();

            //Assert
            Assert.Equal("Street Name City Name Address OFFICE 100 Business Name", TestString);
        }
    }
}