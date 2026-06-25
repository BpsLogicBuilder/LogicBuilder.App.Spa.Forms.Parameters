using LogicBuilder.App.Spa.Forms.Parameters.Common;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class DirectiveArgumentParametersTest
    {
        [Fact]
        public void Constructor_WithParameters_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var parameters = new DirectiveArgumentParameters(
                name: "argName",
                value: "argValue"
            );

            // Assert
            Assert.Equal("argName", parameters.Name);
            Assert.Equal("argValue", parameters.Value);
        }

        [Fact]
        public void Constructor_WithObjectValue_SetsPropertiesCorrectly()
        {
            // Arrange
            var complexValue = new { Property1 = "Value1", Property2 = 42 };

            // Act
            var parameters = new DirectiveArgumentParameters(
                name: "complexArg",
                value: complexValue
            );

            // Assert
            Assert.Equal("complexArg", parameters.Name);
            Assert.Equal(complexValue, parameters.Value);
        }
    }
}
