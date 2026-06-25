using LogicBuilder.App.Spa.Forms.Parameters.Common;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class HtmlPageSettingsParametersTest
    {
        [Fact]
        public void Constructor_WithDefaultValues_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var parameters = new HtmlPageSettingsParameters();

            // Assert
            Assert.Null(parameters.ContentTemplate);
            Assert.Null(parameters.MessageTemplate);
        }

        [Fact]
        public void Constructor_WithContentTemplate_SetsPropertiesCorrectly()
        {
            // Arrange
            var contentTemplate = new ContentTemplateParameters("Title", "template");

            // Act
            var parameters = new HtmlPageSettingsParameters(
                contentTemplate: contentTemplate
            );

            // Assert
            Assert.Equal(contentTemplate, parameters.ContentTemplate);
            Assert.Null(parameters.MessageTemplate);
        }

        [Fact]
        public void Constructor_WithMessageTemplate_SetsPropertiesCorrectly()
        {
            // Arrange
            var messageTemplate = new MessageTemplateParameters("Caption", "Message", "template");

            // Act
            var parameters = new HtmlPageSettingsParameters(
                messageTemplate: messageTemplate
            );

            // Assert
            Assert.Null(parameters.ContentTemplate);
            Assert.Equal(messageTemplate, parameters.MessageTemplate);
        }
    }
}
