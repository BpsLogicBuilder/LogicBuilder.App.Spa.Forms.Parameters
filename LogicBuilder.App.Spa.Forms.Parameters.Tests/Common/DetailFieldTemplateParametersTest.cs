using LogicBuilder.App.Spa.Forms.Parameters.Common;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class DetailFieldTemplateParametersTest
    {
        [Fact]
        public void Constructor_WithTemplateName_SetsPropertyCorrectly()
        {
            // Arrange & Act
            var parameters = new DetailFieldTemplateParameters(templateName: "detailTemplate");

            // Assert
            Assert.Equal("detailTemplate", parameters.TemplateName);
        }
    }
}
