using LogicBuilder.App.Spa.Forms.Parameters.Common;
using LogicBuilder.Forms.Parameters.Expressions;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class DetailDropDownTemplateParametersTest
    {
        [Fact]
        public void Constructor_WithRequiredParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var textAndValueSelector = new SelectorLambdaOperatorParameters(null!, null!, null!);
            var requestDetails = new RequestDetailsParameters(
                "MyApp.Domain.Entities.Student",
                "MyApp.Data.Entities.Student",
                "System.Collections.Generic.IEnumerable`1",
                "System.Collections.Generic.IEnumerable`1"
            );

            // Act
            var parameters = new DetailDropDownTemplateParameters(
                templateName: "dropDownTemplate",
                placeHolderText: "Select...",
                textField: "Name",
                valueField: "Id",
                textAndValueSelector: textAndValueSelector,
                requestDetails: requestDetails
            );

            // Assert
            Assert.Equal("dropDownTemplate", parameters.TemplateName);
            Assert.Equal("Select...", parameters.PlaceHolderText);
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
                "MyApp.Domain.Entities.Order",
                "MyApp.Data.Entities.Order",
                "System.Collections.Generic.List`1",
                "System.Collections.Generic.List`1"
            );

            // Act
            var parameters = new DetailDropDownTemplateParameters(
                templateName: "customDropDown",
                placeHolderText: "Choose...",
                textField: "FullName",
                valueField: "OrderId",
                textAndValueSelector: textAndValueSelector,
                requestDetails: requestDetails,
                reloadItemsFlowName: "ReloadOrdersFlow",
                modelType: "MyApp.Domain.Entities.Customer"
            );

            // Assert
            Assert.Equal("customDropDown", parameters.TemplateName);
            Assert.Equal("Choose...", parameters.PlaceHolderText);
            Assert.Equal("FullName", parameters.TextField);
            Assert.Equal("OrderId", parameters.ValueField);
            Assert.Equal(textAndValueSelector, parameters.TextAndValueSelector);
            Assert.Equal(requestDetails, parameters.RequestDetails);
            Assert.Equal("ReloadOrdersFlow", parameters.ReloadItemsFlowName);
            Assert.Equal("MyApp.Domain.Entities.Customer", parameters.ModelType);
        }
    }
}
