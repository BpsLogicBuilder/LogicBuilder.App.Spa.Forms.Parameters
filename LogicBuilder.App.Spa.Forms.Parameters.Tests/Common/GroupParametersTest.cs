using LogicBuilder.App.Spa.Forms.Parameters.Common;
using System.Collections.Generic;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class GroupParametersTest
    {
        [Fact]
        public void Constructor_WithRequiredParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var aggregates = new List<AggregateDefinitionParameters>();

            // Act
            var parameters = new GroupParameters(
                field: "Category",
                dir: "asc",
                aggregates: aggregates
            );

            // Assert
            Assert.Equal("Category", parameters.Field);
            Assert.Equal("asc", parameters.Dir);
            Assert.Equal(aggregates, parameters.Aggregates);
            Assert.Null(parameters.ModelType);
        }

        [Fact]
        public void Constructor_WithAllParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var aggregates = new List<AggregateDefinitionParameters>
            {
                new("Count", "count")
            };

            // Act
            var parameters = new GroupParameters(
                field: "Status",
                dir: "desc",
                aggregates: aggregates,
                modelType: "MyApp.Domain.Entities.Order"
            );

            // Assert
            Assert.Equal("Status", parameters.Field);
            Assert.Equal("desc", parameters.Dir);
            Assert.Equal(aggregates, parameters.Aggregates);
            Assert.Equal("MyApp.Domain.Entities.Order", parameters.ModelType);
        }
    }
}
