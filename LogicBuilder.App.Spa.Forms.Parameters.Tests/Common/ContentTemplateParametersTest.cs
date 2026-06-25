using LogicBuilder.App.Spa.Forms.Parameters.Common;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class ContentTemplateParametersTest
    {
        [Fact]
        public void Constructor_WithParameters_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var parameters = new ContentTemplateParameters(
                title: "Page Title",
                templateName: "customTemplate"
            );

            // Assert
            Assert.Equal("Page Title", parameters.Title);
            Assert.Equal("customTemplate", parameters.TemplateName);
        }
    }
}
