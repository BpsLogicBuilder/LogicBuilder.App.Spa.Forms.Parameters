using LogicBuilder.App.Spa.Forms.Parameters.Common;
using LogicBuilder.Forms.Parameters.Expressions;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class FilterTemplateParametersTest
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

            // Act
            var parameters = new FilterTemplateParameters(
                templateName: "filterTemplate",
                isPrimitive: true,
                textField: "Name",
                valueField: "Id",
                textAndValueSelector: textAndValueSelector,
                requestDetails: requestDetails
            );

            // Assert
            Assert.Equal("filterTemplate", parameters.TemplateName);
            Assert.True(parameters.IsPrimitive);
            Assert.Equal("Name", parameters.TextField);
            Assert.Equal("Id", parameters.ValueField);
            Assert.Equal(textAndValueSelector, parameters.TextAndValueSelector);
            Assert.Equal(requestDetails, parameters.RequestDetails);
            Assert.Null(parameters.ModelType);
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

            // Act
            var parameters = new FilterTemplateParameters(
                templateName: "categoryFilter",
                isPrimitive: false,
                textField: "CategoryName",
                valueField: "CategoryId",
                textAndValueSelector: textAndValueSelector,
                requestDetails: requestDetails,
                modelType: "MyApp.Domain.Entities.Product"
            );

            // Assert
            Assert.Equal("categoryFilter", parameters.TemplateName);
            Assert.False(parameters.IsPrimitive);
            Assert.Equal("CategoryName", parameters.TextField);
            Assert.Equal("CategoryId", parameters.ValueField);
            Assert.Equal(textAndValueSelector, parameters.TextAndValueSelector);
            Assert.Equal(requestDetails, parameters.RequestDetails);
            Assert.Equal("MyApp.Domain.Entities.Product", parameters.ModelType);
        }
    }
}
