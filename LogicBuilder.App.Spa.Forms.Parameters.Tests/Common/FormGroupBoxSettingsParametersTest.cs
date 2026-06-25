using LogicBuilder.App.Spa.Forms.Parameters.Common;
using System.Collections.Generic;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class FormGroupBoxSettingsParametersTest
    {
        [Fact]
        public void Constructor_WithRequiredParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var formGroupTemplate = new FormGroupTemplateParameters("boxTemplate");
            var fieldSettings = new List<IFormItemSettingParameters>();

            // Act
            var parameters = new FormGroupBoxSettingsParameters(
                formGroupTemplate: formGroupTemplate,
                fieldSettings: fieldSettings,
                title: "Contact Information"
            );

            // Assert
            Assert.Equal(AbstractControlType.GroupBox, parameters.AbstractControlType);
            Assert.Equal(formGroupTemplate, parameters.FormGroupTemplate);
            Assert.Equal(fieldSettings, parameters.FieldSettings);
            Assert.Equal("Contact Information", parameters.Title);
            Assert.True(parameters.ShowTitle);
        }

        [Fact]
        public void Constructor_WithAllParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var formGroupTemplate = new FormGroupTemplateParameters("customBox");
            var fieldSettings = new List<IFormItemSettingParameters>();

            // Act
            var parameters = new FormGroupBoxSettingsParameters(
                formGroupTemplate: formGroupTemplate,
                fieldSettings: fieldSettings,
                title: "Address Details",
                showTitle: false
            );

            // Assert
            Assert.Equal(AbstractControlType.GroupBox, parameters.AbstractControlType);
            Assert.Equal(formGroupTemplate, parameters.FormGroupTemplate);
            Assert.Equal(fieldSettings, parameters.FieldSettings);
            Assert.Equal("Address Details", parameters.Title);
            Assert.False(parameters.ShowTitle);
        }
    }
}
