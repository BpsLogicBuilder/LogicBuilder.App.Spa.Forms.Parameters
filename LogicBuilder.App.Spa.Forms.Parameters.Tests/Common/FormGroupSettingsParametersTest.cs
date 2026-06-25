using LogicBuilder.App.Spa.Forms.Parameters.Common;
using System.Collections.Generic;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class FormGroupSettingsParametersTest
    {
        [Fact]
        public void Constructor_WithRequiredParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var formGroupTemplate = new FormGroupTemplateParameters("groupTemplate");
            var fieldSettings = new List<IFormItemSettingParameters>();
            var validationMessages = new List<ValidationMessageParameters>();

            // Act
            var parameters = new FormGroupSettingsParameters(
                field: "Address",
                formGroupTemplate: formGroupTemplate,
                fieldSettings: fieldSettings,
                validationMessages: validationMessages,
                title: "Address Information",
                showTitle: true,
                modelType: "MyApp.Domain.Entities.Customer"
            );

            // Assert
            Assert.Equal(AbstractControlType.FormGroup, parameters.AbstractControlType);
            Assert.Equal("Address", parameters.Field);
            Assert.Equal(formGroupTemplate, parameters.FormGroupTemplate);
            Assert.Equal(fieldSettings, parameters.FieldSettings);
            Assert.NotNull(parameters.ValidationMessages);
            Assert.NotNull(parameters.ConditionalDirectives);
            Assert.Equal("Address Information", parameters.Title);
            Assert.True(parameters.ShowTitle);
            Assert.Equal("MyApp.Domain.Entities.Customer", parameters.ModelType);
        }

        [Fact]
        public void Constructor_WithAllParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var formGroupTemplate = new FormGroupTemplateParameters("contactTemplate");
            var fieldSettings = new List<IFormItemSettingParameters>();
            var validationMessages = new List<ValidationMessageParameters>
            {
                new("Email",
                [
                    new ValidationMethodParameters("email", "Invalid email format") 
                ])
            };
            var conditionalDirectives = new List<VariableDirectivesParameters>
            {
                new("Phone", [])
            };

            // Act
            var parameters = new FormGroupSettingsParameters(
                field: "ContactInfo",
                formGroupTemplate: formGroupTemplate,
                fieldSettings: fieldSettings,
                validationMessages: validationMessages,
                title: "Contact Details",
                showTitle: false,
                modelType: "MyApp.Domain.Entities.Person",
                conditionalDirectives: conditionalDirectives
            );

            // Assert
            Assert.Equal(AbstractControlType.FormGroup, parameters.AbstractControlType);
            Assert.Equal("ContactInfo", parameters.Field);
            Assert.Equal(formGroupTemplate, parameters.FormGroupTemplate);
            Assert.Equal(fieldSettings, parameters.FieldSettings);
            Assert.NotNull(parameters.ValidationMessages);
            Assert.NotNull(parameters.ConditionalDirectives);
            Assert.Equal("Contact Details", parameters.Title);
            Assert.False(parameters.ShowTitle);
            Assert.Equal("MyApp.Domain.Entities.Person", parameters.ModelType);
        }
    }
}
