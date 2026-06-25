using LogicBuilder.App.Spa.Forms.Parameters.Common;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class DetailListTemplateParametersTest
    {
        [Fact]
        public void Constructor_WithTemplateName_SetsPropertyCorrectly()
        {
            // Arrange & Act
            var parameters = new DetailListTemplateParameters(templateName: "listTemplate");

            // Assert
            Assert.Equal("listTemplate", parameters.TemplateName);
        }
    }
}
