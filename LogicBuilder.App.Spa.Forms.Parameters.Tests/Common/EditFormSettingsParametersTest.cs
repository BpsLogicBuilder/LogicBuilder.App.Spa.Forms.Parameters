using LogicBuilder.App.Spa.Forms.Parameters.Common;
using System.Collections.Generic;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class EditFormSettingsParametersTest
    {
        [Fact]
        public void Constructor_WithRequiredParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var requestDetails = new FormRequestDetailsParameters(
                "/api/Student/Get",
                "/api/Student/Add",
                "/api/Student/Update",
                "/api/Student/Delete",
                "MyApp.Domain.Entities.Student",
                "MyApp.Data.Entities.Student"
            );
            var validationMessages = new List<ValidationMessageParameters>();
            var fieldSettings = new List<IFormItemSettingParameters>();

            // Act
            var parameters = new EditFormSettingsParameters(
                title: "Student Form",
                displayField: "FullName",
                requestDetails: requestDetails,
                validationMessages: validationMessages,
                fieldSettings: fieldSettings
            );

            // Assert
            Assert.Equal("Student Form", parameters.Title);
            Assert.Equal("FullName", parameters.DisplayField);
            Assert.Equal(requestDetails, parameters.RequestDetails);
            Assert.NotNull(parameters.ValidationMessages);
            Assert.Equal(fieldSettings, parameters.FieldSettings);
            Assert.NotNull(parameters.ConditionalDirectives);
            Assert.Equal("Contoso.Domain.Entities.XXXX , Contoso.Domain, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", parameters.ModelType);
        }

        [Fact]
        public void Constructor_WithAllParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var requestDetails = new FormRequestDetailsParameters(
                "/api/Order/Get",
                "/api/Order/Add",
                "/api/Order/Update",
                "/api/Order/Delete",
                "MyApp.Domain.Entities.Order",
                "MyApp.Data.Entities.Order"
            );
            var validationMessages = new List<ValidationMessageParameters>
            {
                new("Status",
                [
                    new ValidationMethodParameters("required", "Status is required") 
                ])
            };
            var fieldSettings = new List<IFormItemSettingParameters>();
            var conditionalDirectives = new List<VariableDirectivesParameters>
            {
                new("Status", [])
            };

            // Act
            var parameters = new EditFormSettingsParameters(
                title: "Order Form",
                displayField: "OrderNumber",
                requestDetails: requestDetails,
                validationMessages: validationMessages,
                fieldSettings: fieldSettings,
                conditionalDirectives: conditionalDirectives,
                modelType: "MyApp.Domain.Entities.Order, MyApp.Domain"
            );

            // Assert
            Assert.Equal("Order Form", parameters.Title);
            Assert.Equal("OrderNumber", parameters.DisplayField);
            Assert.Equal(requestDetails, parameters.RequestDetails);
            Assert.NotNull(parameters.ValidationMessages);
            Assert.Single(parameters.ValidationMessages);
            Assert.Equal(fieldSettings, parameters.FieldSettings);
            Assert.NotNull(parameters.ConditionalDirectives);
            Assert.Equal("MyApp.Domain.Entities.Order, MyApp.Domain", parameters.ModelType);
        }
    }
}
