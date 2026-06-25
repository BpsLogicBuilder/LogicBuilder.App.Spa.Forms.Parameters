using LogicBuilder.App.Spa.Forms.Parameters.Common;
using System.Collections.Generic;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class FormGroupArraySettingsParametersTest
    {
        [Fact]
        public void Constructor_WithRequiredParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var formGroupTemplate = new FormGroupTemplateParameters("arrayTemplate");
            var fieldSettings = new List<IFormItemSettingParameters>();
            var keyFields = new List<string> { "Id" };
            var validationMessages = new List<ValidationMessageParameters>();

            // Act
            var parameters = new FormGroupArraySettingsParameters(
                field: "Enrollments",
                formGroupTemplate: formGroupTemplate,
                fieldSettings: fieldSettings,
                keyFields: keyFields,
                validationMessages: validationMessages,
                title: "Student Enrollments",
                showTitle: true
            );

            // Assert
            Assert.Equal(AbstractControlType.FormGroupArray, parameters.AbstractControlType);
            Assert.Equal("Enrollments", parameters.Field);
            Assert.Equal(formGroupTemplate, parameters.FormGroupTemplate);
            Assert.Equal(fieldSettings, parameters.FieldSettings);
            Assert.NotNull(parameters.ValidationMessages);
            Assert.Equal(keyFields, parameters.KeyFields);
            Assert.NotNull(parameters.ConditionalDirectives);
            Assert.Equal("Student Enrollments", parameters.Title);
            Assert.True(parameters.ShowTitle);
            Assert.Equal("<myApp>.Domain.Entities.<EntityName>", parameters.ArrayElementType);
        }

        [Fact]
        public void Constructor_WithAllParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var formGroupTemplate = new FormGroupTemplateParameters("orderItemsTemplate");
            var fieldSettings = new List<IFormItemSettingParameters>();
            var keyFields = new List<string> { "OrderItemId" };
            var validationMessages = new List<ValidationMessageParameters>
            {
                new("Quantity",
                [
                    new ValidationMethodParameters("required", "Quantity is required") 
                ])
            };
            var conditionalDirectives = new List<VariableDirectivesParameters>();

            // Act
            var parameters = new FormGroupArraySettingsParameters(
                field: "OrderItems",
                formGroupTemplate: formGroupTemplate,
                fieldSettings: fieldSettings,
                keyFields: keyFields,
                validationMessages: validationMessages,
                title: "Order Items",
                showTitle: false,
                arrayElementType: "MyApp.Domain.Entities.OrderItem",
                conditionalDirectives: conditionalDirectives
            );

            // Assert
            Assert.Equal(AbstractControlType.FormGroupArray, parameters.AbstractControlType);
            Assert.Equal("OrderItems", parameters.Field);
            Assert.Equal(formGroupTemplate, parameters.FormGroupTemplate);
            Assert.Equal(fieldSettings, parameters.FieldSettings);
            Assert.NotNull(parameters.ValidationMessages);
            Assert.Equal(keyFields, parameters.KeyFields);
            Assert.NotNull(parameters.ConditionalDirectives);
            Assert.Equal("Order Items", parameters.Title);
            Assert.False(parameters.ShowTitle);
            Assert.Equal("MyApp.Domain.Entities.OrderItem", parameters.ArrayElementType);
        }
    }
}
