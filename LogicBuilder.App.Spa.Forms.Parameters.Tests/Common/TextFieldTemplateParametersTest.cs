using LogicBuilder.App.Spa.Forms.Parameters.Common;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class TextFieldTemplateParametersTest
    {
        [Fact]
        public void Constructor_WithTemplateName_SetsPropertyCorrectly()
        {
            // Arrange & Act
            var parameters = new TextFieldTemplateParameters(templateName: "textTemplate");

            // Assert
            Assert.Equal("textTemplate", parameters.TemplateName);
        }
    }
}
