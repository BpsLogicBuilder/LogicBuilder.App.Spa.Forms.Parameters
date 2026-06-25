using LogicBuilder.App.Spa.Forms.Parameters.Common;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class InputFieldControlSettingsParametersTest
    {
        [Fact]
        public void Constructor_WithRequiredParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var textTemplate = new TextFieldTemplateParameters("textTemplate");

            // Act
            var parameters = new InputFieldControlSettingsParameters(
                field: "FirstName",
                domElementId: "firstName_id",
                title: "First Name",
                placeHolder: "Enter first name",
                type: "text",
                textTemplate: textTemplate,
                modelType: "MyApp.Domain.Entities.Student"
            );

            // Assert
            Assert.Equal(AbstractControlType.InputFieldControl, parameters.AbstractControlType);
            Assert.Equal("FirstName", parameters.Field);
            Assert.Equal("firstName_id", parameters.DomElementId);
            Assert.Equal("First Name", parameters.Title);
            Assert.Equal("Enter first name", parameters.Placeholder);
            Assert.Equal("text", parameters.Type);
            Assert.Equal(textTemplate, parameters.TextTemplate);
            Assert.Equal("MyApp.Domain.Entities.Student", parameters.ModelType);
            Assert.Null(parameters.ValidationSetting);
        }

        [Fact]
        public void Constructor_WithAllParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var textTemplate = new TextFieldTemplateParameters("customTemplate");
            var validationSetting = new FormValidationSettingParameters(defaultValue: "Default");

            // Act
            var parameters = new InputFieldControlSettingsParameters(
                field: "Email",
                domElementId: "email_id",
                title: "Email Address",
                placeHolder: "Enter email",
                type: "email",
                textTemplate: textTemplate,
                modelType: "MyApp.Domain.Entities.Contact",
                validationSetting: validationSetting
            );

            // Assert
            Assert.Equal(AbstractControlType.InputFieldControl, parameters.AbstractControlType);
            Assert.Equal("Email", parameters.Field);
            Assert.Equal("email_id", parameters.DomElementId);
            Assert.Equal("Email Address", parameters.Title);
            Assert.Equal("Enter email", parameters.Placeholder);
            Assert.Equal("email", parameters.Type);
            Assert.Equal(textTemplate, parameters.TextTemplate);
            Assert.Equal("MyApp.Domain.Entities.Contact", parameters.ModelType);
            Assert.Equal(validationSetting, parameters.ValidationSetting);
        }
    }
}
