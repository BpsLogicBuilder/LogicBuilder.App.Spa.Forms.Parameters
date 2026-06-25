using LogicBuilder.App.Spa.Forms.Parameters.Common;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class CellListTemplateParametersTest
    {
        [Fact]
        public void Constructor_WithRequiredParameters_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var parameters = new CellListTemplateParameters(
                templateName: "cellTemplate",
                displayMember: "Name"
            );

            // Assert
            Assert.Equal("cellTemplate", parameters.TemplateName);
            Assert.Equal("Name", parameters.DisplayMember);
            Assert.Equal("<myApp>.Domain.Entities.<EntityName>", parameters.ModelType);
        }

        [Fact]
        public void Constructor_WithAllParameters_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var parameters = new CellListTemplateParameters(
                templateName: "customTemplate",
                displayMember: "FullName",
                modelType: "MyApp.Domain.Entities.Person"
            );

            // Assert
            Assert.Equal("customTemplate", parameters.TemplateName);
            Assert.Equal("FullName", parameters.DisplayMember);
            Assert.Equal("MyApp.Domain.Entities.Person", parameters.ModelType);
        }
    }
}
