using LogicBuilder.App.Spa.Forms.Parameters.Common;
using System.Collections.Generic;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class DetailGroupSettingsParametersTest
    {
        [Fact]
        public void Constructor_WithRequiredParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var groupTemplate = new DetailGroupTemplateParameters("groupTemplate");
            var fieldSettings = new List<IDetailItemParameters>();

            // Act
            var parameters = new DetailGroupSettingsParameters(
                field: "Address",
                title: "Address Information",
                groupTemplate: groupTemplate,
                fieldSettings: fieldSettings
            );

            // Assert
            Assert.Equal(DetailItemType.Group, parameters.DetailType);
            Assert.Equal("Address", parameters.Field);
            Assert.Equal("Address Information", parameters.Title);
            Assert.Equal(groupTemplate, parameters.GroupTemplate);
            Assert.Equal(fieldSettings, parameters.FieldSettings);
            Assert.Null(parameters.ModelType);
        }

        [Fact]
        public void Constructor_WithAllParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var groupTemplate = new DetailGroupTemplateParameters("customGroup");
            var fieldSettings = new List<IDetailItemParameters>
            {
                new DetailFieldSettingParameters("Street", "Street", "text", "MyApp.Domain.Entities.Address")
            };

            // Act
            var parameters = new DetailGroupSettingsParameters(
                field: "ShippingAddress",
                title: "Shipping Address",
                groupTemplate: groupTemplate,
                fieldSettings: fieldSettings,
                modelType: "MyApp.Domain.Entities.Order"
            );

            // Assert
            Assert.Equal(DetailItemType.Group, parameters.DetailType);
            Assert.Equal("ShippingAddress", parameters.Field);
            Assert.Equal("Shipping Address", parameters.Title);
            Assert.Equal(groupTemplate, parameters.GroupTemplate);
            Assert.Equal(fieldSettings, parameters.FieldSettings);
            Assert.Equal("MyApp.Domain.Entities.Order", parameters.ModelType);
        }
    }
}
