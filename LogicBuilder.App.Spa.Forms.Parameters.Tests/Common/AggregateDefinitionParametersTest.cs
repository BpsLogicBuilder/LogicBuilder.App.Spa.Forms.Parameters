using LogicBuilder.App.Spa.Forms.Parameters.Common;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class AggregateDefinitionParametersTest
    {
        [Fact]
        public void Constructor_WithRequiredParameters_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var parameters = new AggregateDefinitionParameters(
                field: "TestField",
                aggregate: "sum"
            );

            // Assert
            Assert.Equal("TestField", parameters.Field);
            Assert.Equal("sum", parameters.Aggregate);
            Assert.Null(parameters.ModelType);
        }

        [Fact]
        public void Constructor_WithAllParameters_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var parameters = new AggregateDefinitionParameters(
                field: "TestField",
                aggregate: "average",
                modelType: "MyApp.Domain.Entities.TestEntity"
            );

            // Assert
            Assert.Equal("TestField", parameters.Field);
            Assert.Equal("average", parameters.Aggregate);
            Assert.Equal("MyApp.Domain.Entities.TestEntity", parameters.ModelType);
        }
    }
}
