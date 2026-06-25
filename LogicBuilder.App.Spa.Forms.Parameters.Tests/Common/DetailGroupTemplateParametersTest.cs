using LogicBuilder.App.Spa.Forms.Parameters.Common;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class DetailGroupTemplateParametersTest
    {
        [Fact]
        public void Constructor_WithTemplateName_SetsPropertyCorrectly()
        {
            // Arrange & Act
            var parameters = new DetailGroupTemplateParameters(templateName: "groupTemplate");

            // Assert
            Assert.Equal("groupTemplate", parameters.TemplateName);
        }
    }
}
