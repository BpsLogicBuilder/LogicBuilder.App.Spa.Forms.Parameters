using LogicBuilder.App.Spa.Forms.Parameters.Common;
using System.Collections.Generic;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class DetailFieldSettingParametersTest
    {
        [Fact]
        public void Constructor_WithRequiredParameters_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var parameters = new DetailFieldSettingParameters(
                field: "FirstName",
                title: "First Name",
                type: "text",
                modelType: "MyApp.Domain.Entities.Student"
            );

            // Assert
            Assert.Equal(DetailItemType.Field, parameters.DetailType);
            Assert.Equal("FirstName", parameters.Field);
            Assert.Equal("First Name", parameters.Title);
            Assert.Equal("text", parameters.Type);
            Assert.Equal("MyApp.Domain.Entities.Student", parameters.ModelType);
            Assert.Null(parameters.FieldTemplate);
            Assert.Null(parameters.ValueTextTemplate);
        }

        [Fact]
        public void Constructor_WithAllParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var fieldTemplate = new DetailFieldTemplateParameters("customTemplate");

            // Act
            var parameters = new DetailFieldSettingParameters(
                field: "Status",
                title: "Current Status",
                type: "text",
                modelType: "MyApp.Domain.Entities.Order",
                fieldTemplate: fieldTemplate,
                valueTextTemplate: null
            );

            // Assert
            Assert.Equal(DetailItemType.Field, parameters.DetailType);
            Assert.Equal("Status", parameters.Field);
            Assert.Equal("Current Status", parameters.Title);
            Assert.Equal("text", parameters.Type);
            Assert.Equal("MyApp.Domain.Entities.Order", parameters.ModelType);
            Assert.Equal(fieldTemplate, parameters.FieldTemplate);
            Assert.Null(parameters.ValueTextTemplate);
        }
    }
}
