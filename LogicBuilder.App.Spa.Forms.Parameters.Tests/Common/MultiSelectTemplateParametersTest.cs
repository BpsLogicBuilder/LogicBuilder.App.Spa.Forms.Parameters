using LogicBuilder.App.Spa.Forms.Parameters.Common;
using LogicBuilder.Forms.Parameters.Expressions;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class MultiSelectTemplateParametersTest
    {
        [Fact]
        public void Constructor_WithRequiredParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var textAndValueSelector = new SelectorLambdaOperatorParameters(null!, null!, null!);
            var requestDetails = new RequestDetailsParameters(
                "MyApp.Domain.Entities.Role",
                "MyApp.Data.Entities.Role",
                "System.Collections.Generic.IEnumerable`1",
                "System.Collections.Generic.IEnumerable`1"
            );

            // Act
            var parameters = new MultiSelectTemplateParameters(
                templateName: "multiSelectTemplate",
                placeHolderText: "Select roles...",
                textField: "RoleName",
                valueField: "RoleId",
                textAndValueSelector: textAndValueSelector,
                requestDetails: requestDetails
            );

            // Assert
            Assert.Equal("multiSelectTemplate", parameters.TemplateName);
            Assert.Equal("Select roles...", parameters.PlaceHolderText);
            Assert.Equal("RoleName", parameters.TextField);
            Assert.Equal("RoleId", parameters.ValueField);
            Assert.Equal(textAndValueSelector, parameters.TextAndValueSelector);
            Assert.Equal(requestDetails, parameters.RequestDetails);
            Assert.Equal("<myApp>.Domain.Entities.<EntityName>", parameters.ModelType);
        }

        [Fact]
        public void Constructor_WithAllParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var textAndValueSelector = new SelectorLambdaOperatorParameters(null!, null!, null!);
            var requestDetails = new RequestDetailsParameters(
                "MyApp.Domain.Entities.Permission",
                "MyApp.Data.Entities.Permission",
                "System.Collections.Generic.List`1",
                "System.Collections.Generic.List`1"
            );

            // Act
            var parameters = new MultiSelectTemplateParameters(
                templateName: "permissionMultiSelect",
                placeHolderText: "Choose permissions...",
                textField: "PermissionName",
                valueField: "PermissionId",
                textAndValueSelector: textAndValueSelector,
                requestDetails: requestDetails,
                modelType: "MyApp.Domain.Entities.User"
            );

            // Assert
            Assert.Equal("permissionMultiSelect", parameters.TemplateName);
            Assert.Equal("Choose permissions...", parameters.PlaceHolderText);
            Assert.Equal("PermissionName", parameters.TextField);
            Assert.Equal("PermissionId", parameters.ValueField);
            Assert.Equal(textAndValueSelector, parameters.TextAndValueSelector);
            Assert.Equal(requestDetails, parameters.RequestDetails);
            Assert.Equal("MyApp.Domain.Entities.User", parameters.ModelType);
        }
    }
}
