using LogicBuilder.App.Spa.Forms.Parameters.Common;
using System.Collections.Generic;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class ValidationMessageParametersTest
    {
        [Fact]
        public void Constructor_WithRequiredParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var methods = new List<ValidationMethodParameters>
            {
                new("required", "Field is required")
            };

            // Act
            var parameters = new ValidationMessageParameters(
                field: "FirstName",
                methods: methods
            );

            // Assert
            Assert.Equal("FirstName", parameters.Field);
            Assert.NotNull(parameters.Methods);
            Assert.Single(parameters.Methods);
            Assert.Equal("Field is required", parameters.Methods["required"]);
            Assert.Null(parameters.ModelType);
        }

        [Fact]
        public void Constructor_WithAllParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var methods = new List<ValidationMethodParameters>
            {
                new("required", "Name is required"),
                new("maxLength", "Name is too long")
            };

            // Act
            var parameters = new ValidationMessageParameters(
                field: "LastName",
                methods: methods,
                modelType: "MyApp.Domain.Entities.Person"
            );

            // Assert
            Assert.Equal("LastName", parameters.Field);
            Assert.Equal(2, parameters.Methods.Count);
            Assert.Equal("Name is required", parameters.Methods["required"]);
            Assert.Equal("Name is too long", parameters.Methods["maxLength"]);
            Assert.Equal("MyApp.Domain.Entities.Person", parameters.ModelType);
        }
    }
}
