using LogicBuilder.App.Spa.Forms.Parameters.Common;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class CommandColumnParametersTest
    {
        [Fact]
        public void Constructor_WithParameters_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var parameters = new CommandColumnParameters(
                title: "Actions",
                width: 150
            );

            // Assert
            Assert.Equal("Actions", parameters.Title);
            Assert.Equal(150, parameters.Width);
        }

        [Fact]
        public void Constructor_WithNullWidth_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var parameters = new CommandColumnParameters(
                title: "Commands",
                width: null
            );

            // Assert
            Assert.Equal("Commands", parameters.Title);
            Assert.Null(parameters.Width);
        }
    }
}
