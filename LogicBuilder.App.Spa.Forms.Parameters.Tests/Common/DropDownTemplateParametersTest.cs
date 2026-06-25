using LogicBuilder.App.Spa.Forms.Parameters.Common;
using LogicBuilder.Forms.Parameters.Expressions;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class DropDownTemplateParametersTest
    {
        [Fact]
        public void Constructor_WithRequiredParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var textAndValueSelector = new SelectorLambdaOperatorParameters(null!, null!, null!);
            var requestDetails = new RequestDetailsParameters(
                "MyApp.Domain.Entities.Category",
                "MyApp.Data.Entities.Category",
                "System.Collections.Generic.IEnumerable`1",
                "System.Collections.Generic.IEnumerable`1"
            );

            // Act
            var parameters = new DropDownTemplateParameters(
                templateName: "dropDownTemplate",
                placeHolderText: "Select One...",
                textField: "Name",
                valueField: "Id",
                textAndValueSelector: textAndValueSelector,
                requestDetails: requestDetails
            );

            // Assert
            Assert.Equal("dropDownTemplate", parameters.TemplateName);
            Assert.Equal("Select One...", parameters.PlaceHolderText);
            Assert.Equal("Name", parameters.TextField);
            Assert.Equal("Id", parameters.ValueField);
            Assert.Equal(textAndValueSelector, parameters.TextAndValueSelector);
            Assert.Equal(requestDetails, parameters.RequestDetails);
            Assert.Null(parameters.ReloadItemsFlowName);
            Assert.Equal("<myApp>.Domain.Entities.<EntityName>", parameters.ModelType);
        }

        [Fact]
        public void Constructor_WithAllParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var textAndValueSelector = new SelectorLambdaOperatorParameters(null!, null!, null!);
            var requestDetails = new RequestDetailsParameters(
                "MyApp.Domain.Entities.Product",
                "MyApp.Data.Entities.Product",
                "System.Collections.Generic.List`1",
                "System.Collections.Generic.List`1"
            );

            // Act
            var parameters = new DropDownTemplateParameters(
                templateName: "productDropDown",
                placeHolderText: "Choose Product...",
                textField: "ProductName",
                valueField: "ProductId",
                textAndValueSelector: textAndValueSelector,
                requestDetails: requestDetails,
                reloadItemsFlowName: "ReloadProductsFlow",
                modelType: "MyApp.Domain.Entities.Product"
            );

            // Assert
            Assert.Equal("productDropDown", parameters.TemplateName);
            Assert.Equal("Choose Product...", parameters.PlaceHolderText);
            Assert.Equal("ProductName", parameters.TextField);
            Assert.Equal("ProductId", parameters.ValueField);
            Assert.Equal(textAndValueSelector, parameters.TextAndValueSelector);
            Assert.Equal(requestDetails, parameters.RequestDetails);
            Assert.Equal("ReloadProductsFlow", parameters.ReloadItemsFlowName);
            Assert.Equal("MyApp.Domain.Entities.Product", parameters.ModelType);
        }
    }
}
