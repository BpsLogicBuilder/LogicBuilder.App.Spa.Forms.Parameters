using LogicBuilder.App.Spa.Forms.Parameters.Common;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class FilterDefinitionParametersTest
    {
        [Fact]
        public void Constructor_WithRequiredParameters_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var parameters = new FilterDefinitionParameters(
                field: "Name",
                oper: "eq"
            );

            // Assert
            Assert.Equal("Name", parameters.Field);
            Assert.Equal("eq", parameters.Operator);
            Assert.Null(parameters.Value);
            Assert.Null(parameters.IgnoreCase);
            Assert.Equal("", parameters.ValueSourceMember);
            Assert.Null(parameters.ModelType);
        }

        [Fact]
        public void Constructor_WithAllParameters_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var parameters = new FilterDefinitionParameters(
                field: "LastName",
                oper: "contains",
                value: "Smith",
                ignoreCase: true,
                valueSourceMember: "SearchValue",
                modelType: "MyApp.Domain.Entities.Person"
            );

            // Assert
            Assert.Equal("LastName", parameters.Field);
            Assert.Equal("contains", parameters.Operator);
            Assert.Equal("Smith", parameters.Value);
            Assert.True(parameters.IgnoreCase);
            Assert.Equal("SearchValue", parameters.ValueSourceMember);
            Assert.Equal("MyApp.Domain.Entities.Person", parameters.ModelType);
        }
    }
}
