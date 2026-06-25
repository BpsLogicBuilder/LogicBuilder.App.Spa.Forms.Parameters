using LogicBuilder.App.Spa.Forms.Parameters.Common;
using System.Collections.Generic;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class DataRequestStateParametersTest
    {
        [Fact]
        public void Constructor_WithDefaultValues_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var parameters = new DataRequestStateParameters();

            // Assert
            Assert.Null(parameters.Skip);
            Assert.Null(parameters.Take);
            Assert.Null(parameters.Sort);
            Assert.Null(parameters.Group);
            Assert.Null(parameters.FilterGroup);
            Assert.Null(parameters.Aggregates);
        }

        [Fact]
        public void Constructor_WithAllParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var sort = new List<SortParameters> { new("Name", "asc") };
            var group = new List<GroupParameters> { new("Category", "asc", []) };
            var filterGroup = new FilterGroupParameters("and");
            var aggregates = new List<AggregateDefinitionParameters> { new("Count", "count") };

            // Act
            var parameters = new DataRequestStateParameters(
                skip: 10,
                take: 20,
                sort: sort,
                group: group,
                filterGroup: filterGroup,
                aggregates: aggregates
            );

            // Assert
            Assert.Equal(10, parameters.Skip);
            Assert.Equal(20, parameters.Take);
            Assert.Equal(sort, parameters.Sort);
            Assert.Equal(group, parameters.Group);
            Assert.Equal(filterGroup, parameters.FilterGroup);
            Assert.Equal(aggregates, parameters.Aggregates);
        }
    }
}
