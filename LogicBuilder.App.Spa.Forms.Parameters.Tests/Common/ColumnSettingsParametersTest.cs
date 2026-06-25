using LogicBuilder.App.Spa.Forms.Parameters.Common;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class ColumnSettingsParametersTest
    {
        [Fact]
        public void Constructor_WithRequiredParameters_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var parameters = new ColumnSettingsParameters(
                field: "Name",
                title: "Full Name",
                type: "text"
            );

            // Assert
            Assert.Equal("Name", parameters.Field);
            Assert.Equal("Full Name", parameters.Title);
            Assert.Equal("text", parameters.Type);
            Assert.Null(parameters.Groupable);
            Assert.Null(parameters.Width);
            Assert.Null(parameters.Format);
            Assert.Null(parameters.Filter);
            Assert.Null(parameters.CellTemplate);
            Assert.Null(parameters.CellListTemplate);
            Assert.Null(parameters.FilterRowTemplate);
            Assert.Null(parameters.FilterMenuTemplate);
            Assert.Null(parameters.GroupHeaderTemplate);
            Assert.Null(parameters.GroupFooterTemplate);
            Assert.Null(parameters.GridFooterTemplate);
            Assert.Null(parameters.ModelType);
        }

        [Fact]
        public void Constructor_WithAllParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var cellTemplate = new CellTemplateParameters("customCell");
            var cellListTemplate = new CellListTemplateParameters("listTemplate", "DisplayName");

            // Act
            var parameters = new ColumnSettingsParameters(
                field: "Status",
                title: "Order Status",
                type: "text",
                groupable: true,
                width: 200,
                format: "{0:C}",
                filter: "text",
                cellTemplate: cellTemplate,
                cellListTemplate: cellListTemplate,
                filterRowTemplate: null,
                filterMenuTemplate: null,
                groupHeaderTemplate: null,
                groupFooterTemplate: null,
                gridFooterTemplate: null,
                modelType: "MyApp.Domain.Entities.Order"
            );

            // Assert
            Assert.Equal("Status", parameters.Field);
            Assert.Equal("Order Status", parameters.Title);
            Assert.Equal("text", parameters.Type);
            Assert.True(parameters.Groupable);
            Assert.Equal(200, parameters.Width);
            Assert.Equal("{0:C}", parameters.Format);
            Assert.Equal("text", parameters.Filter);
            Assert.Equal(cellTemplate, parameters.CellTemplate);
            Assert.Equal(cellListTemplate, parameters.CellListTemplate);
            Assert.Equal("MyApp.Domain.Entities.Order", parameters.ModelType);
        }
    }
}
