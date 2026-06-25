using LogicBuilder.App.Spa.Forms.Parameters.Common;
using LogicBuilder.Forms.Parameters.Expressions;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class DropdownSelectorControlSettingsParametersTest
    {
        [Fact]
        public void Constructor_WithRequiredParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var textAndValueSelector = new SelectorLambdaOperatorParameters(null!, null!, null!);
            var requestDetails = new RequestDetailsParameters(
                "MyApp.Domain.Entities.Status",
                "MyApp.Data.Entities.Status",
                "System.Collections.Generic.IEnumerable`1",
                "System.Collections.Generic.IEnumerable`1"
            );
            var dropDownTemplate = new DropDownTemplateParameters(
                "dropDownTemplate",
                "Select...",
                "Name",
                "Id",
                textAndValueSelector,
                requestDetails
            );

            // Act
            var parameters = new DropdownSelectorControlSettingsParameters(
                field: "StatusId",
                domElementId: "statusId_id",
                title: "Status",
                placeHolder: "Select status",
                type: "numeric",
                dropDownTemplate: dropDownTemplate,
                modelType: "MyApp.Domain.Entities.Order"
            );

            // Assert
            Assert.Equal(AbstractControlType.DropdownSelectorControl, parameters.AbstractControlType);
            Assert.Equal("StatusId", parameters.Field);
            Assert.Equal("statusId_id", parameters.DomElementId);
            Assert.Equal("Status", parameters.Title);
            Assert.Equal("Select status", parameters.Placeholder);
            Assert.Equal("numeric", parameters.Type);
            Assert.Equal(dropDownTemplate, parameters.DropDownTemplate);
            Assert.Equal("MyApp.Domain.Entities.Order", parameters.ModelType);
            Assert.Null(parameters.ValidationSetting);
        }

        [Fact]
        public void Constructor_WithAllParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var textAndValueSelector = new SelectorLambdaOperatorParameters(null!, null!, null!);
            var requestDetails = new RequestDetailsParameters(
                "MyApp.Domain.Entities.Category",
                "MyApp.Data.Entities.Category",
                "System.Collections.Generic.List`1",
                "System.Collections.Generic.List`1"
            );
            var dropDownTemplate = new DropDownTemplateParameters(
                "categoryDropDown",
                "Choose...",
                "CategoryName",
                "CategoryId",
                textAndValueSelector,
                requestDetails
            );
            var validationSetting = new FormValidationSettingParameters(defaultValue: 1);

            // Act
            var parameters = new DropdownSelectorControlSettingsParameters(
                field: "CategoryId",
                domElementId: "categoryId_id",
                title: "Category",
                placeHolder: "Select category",
                type: "numeric",
                dropDownTemplate: dropDownTemplate,
                modelType: "MyApp.Domain.Entities.Product",
                validationSetting: validationSetting
            );

            // Assert
            Assert.Equal(AbstractControlType.DropdownSelectorControl, parameters.AbstractControlType);
            Assert.Equal("CategoryId", parameters.Field);
            Assert.Equal("categoryId_id", parameters.DomElementId);
            Assert.Equal("Category", parameters.Title);
            Assert.Equal("Select category", parameters.Placeholder);
            Assert.Equal("numeric", parameters.Type);
            Assert.Equal(dropDownTemplate, parameters.DropDownTemplate);
            Assert.Equal("MyApp.Domain.Entities.Product", parameters.ModelType);
            Assert.Equal(validationSetting, parameters.ValidationSetting);
        }
    }
}
