using LogicBuilder.App.Spa.Forms.Parameters.Common;
using System.Collections.Generic;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class DirectiveDescriptionParametersTest
    {
        [Fact]
        public void Constructor_WithRequiredParameters_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var parameters = new DirectiveDescriptionParameters(
                className: "Directives",
                functionName: "hideIf"
            );

            // Assert
            Assert.Equal("Directives", parameters.ClassName);
            Assert.Equal("hideIf", parameters.FunctionName);
            Assert.Null(parameters.Arguments);
        }

        [Fact]
        public void Constructor_WithArguments_SetsPropertiesCorrectly()
        {
            // Arrange
            var arguments = new List<DirectiveArgumentParameters>
            {
                new("arg1", "value1"),
                new("arg2", 42)
            };

            // Act
            var parameters = new DirectiveDescriptionParameters(
                className: "CustomDirectives",
                functionName: "validateIf",
                arguments: arguments
            );

            // Assert
            Assert.Equal("CustomDirectives", parameters.ClassName);
            Assert.Equal("validateIf", parameters.FunctionName);
            Assert.NotNull(parameters.Arguments);
            Assert.Equal(2, parameters.Arguments.Count);
            Assert.Equal("value1", parameters.Arguments["arg1"]);
            Assert.Equal(42, parameters.Arguments["arg2"]);
        }
    }
}
