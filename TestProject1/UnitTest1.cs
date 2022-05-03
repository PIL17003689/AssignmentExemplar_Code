using xunit;
using AssignmentExemplar_Code;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CommercialPropertyToStringTest1()
        {
            //Arrange
            Commercial propertyToTest1;

            //Act
            propertyToTest1 = new Commercial("Street Name", "City Name", "Address", enums.CommercialType.OFFICE, 100, "Business Name");
            var TestString = propertyToTest1.ToString();

            //Assert
            Assert.Equal("Street Name City Name Address OFFICE 100 Business Name", TestString);
        }

        public void IssueToStringTest1()
        {
            //Arrange
            MinorIssue propertyToTest2;

            //Act
            propertyToTest2 = new MinorIssue(2001-01-01, "Description", "Progress", enums.IssueSeverity.LOW);

            //Assert
            Assert.Equal("2001-01-01 Description Progress LOW");
        }
    }
}