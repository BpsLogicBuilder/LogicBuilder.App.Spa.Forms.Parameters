using LogicBuilder.App.Spa.Forms.Parameters.Common;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class CellTemplateParametersTest
    {
        [Fact]
        public void Constructor_WithTemplateName_SetsPropertyCorrectly()
        {
            // Arrange & Act
            var parameters = new CellTemplateParameters(templateName: "myTemplate");

            // Assert
            Assert.Equal("myTemplate", parameters.TemplateName);
        }
    }
}
