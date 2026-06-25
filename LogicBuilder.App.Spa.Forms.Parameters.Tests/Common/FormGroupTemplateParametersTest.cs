using LogicBuilder.App.Spa.Forms.Parameters.Common;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class FormGroupTemplateParametersTest
    {
        [Fact]
        public void Constructor_WithTemplateName_SetsPropertyCorrectly()
        {
            // Arrange & Act
            var parameters = new FormGroupTemplateParameters(templateName: "formGroupTemplate");

            // Assert
            Assert.Equal("formGroupTemplate", parameters.TemplateName);
        }
    }
}
