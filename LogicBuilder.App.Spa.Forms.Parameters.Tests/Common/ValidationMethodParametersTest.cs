using LogicBuilder.App.Spa.Forms.Parameters.Common;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class ValidationMethodParametersTest
    {
        [Fact]
        public void Constructor_WithParameters_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var parameters = new ValidationMethodParameters(
                method: "required",
                message: "This field is required"
            );

            // Assert
            Assert.Equal("required", parameters.Method);
            Assert.Equal("This field is required", parameters.Message);
        }
    }
}
