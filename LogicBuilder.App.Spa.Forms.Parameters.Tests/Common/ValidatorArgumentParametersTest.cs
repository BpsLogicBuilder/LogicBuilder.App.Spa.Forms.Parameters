using LogicBuilder.App.Spa.Forms.Parameters.Common;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class ValidatorArgumentParametersTest
    {
        [Fact]
        public void Constructor_WithParameters_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var parameters = new ValidatorArgumentParameters(
                name: "maxLength",
                value: 100
            );

            // Assert
            Assert.Equal("maxLength", parameters.Name);
            Assert.Equal(100, parameters.Value);
        }

        [Fact]
        public void Constructor_WithStringValue_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var parameters = new ValidatorArgumentParameters(
                name: "pattern",
                value: "^[A-Za-z]+$"
            );

            // Assert
            Assert.Equal("pattern", parameters.Name);
            Assert.Equal("^[A-Za-z]+$", parameters.Value);
        }
    }
}
