using LogicBuilder.App.Spa.Forms.Parameters.Common;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class MessageTemplateParametersTest
    {
        [Fact]
        public void Constructor_WithParameters_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var parameters = new MessageTemplateParameters(
                caption: "Warning",
                message: "Are you sure?",
                templateName: "confirmTemplate"
            );

            // Assert
            Assert.Equal("Warning", parameters.Caption);
            Assert.Equal("Are you sure?", parameters.Message);
            Assert.Equal("confirmTemplate", parameters.TemplateName);
        }
    }
}
