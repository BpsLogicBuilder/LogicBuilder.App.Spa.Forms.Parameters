using LogicBuilder.App.Spa.Forms.Parameters.Common;
using System.Collections.Generic;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class ValidatorDescriptionParametersTest
    {
        [Fact]
        public void Constructor_WithRequiredParameters_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var parameters = new ValidatorDescriptionParameters(
                className: "Validators",
                functionName: "required"
            );

            // Assert
            Assert.Equal("Validators", parameters.ClassName);
            Assert.Equal("required", parameters.FunctionName);
            Assert.Null(parameters.Arguments);
        }

        [Fact]
        public void Constructor_WithArguments_SetsPropertiesCorrectly()
        {
            // Arrange
            var arguments = new List<ValidatorArgumentParameters>
            {
                new("min", 5),
                new("max", 100)
            };

            // Act
            var parameters = new ValidatorDescriptionParameters(
                className: "CustomValidators",
                functionName: "range",
                arguments: arguments
            );

            // Assert
            Assert.Equal("CustomValidators", parameters.ClassName);
            Assert.Equal("range", parameters.FunctionName);
            Assert.NotNull(parameters.Arguments);
            Assert.Equal(2, parameters.Arguments.Count);
            Assert.Equal(5, parameters.Arguments["min"]);
            Assert.Equal(100, parameters.Arguments["max"]);
        }
    }
}
