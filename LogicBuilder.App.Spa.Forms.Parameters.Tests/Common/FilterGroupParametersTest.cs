using LogicBuilder.App.Spa.Forms.Parameters.Common;
using System.Collections.Generic;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class FilterGroupParametersTest
    {
        [Fact]
        public void Constructor_WithLogicOnly_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var parameters = new FilterGroupParameters(logic: "and");

            // Assert
            Assert.Equal("and", parameters.Logic);
            Assert.Null(parameters.Filters);
            Assert.Null(parameters.FilterGroups);
        }

        [Fact]
        public void Constructor_WithAllParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var filters = new List<FilterDefinitionParameters>
            {
                new("Name", "eq", "John")
            };
            var filterGroups = new List<FilterGroupParameters>
            {
                new("or")
            };

            // Act
            var parameters = new FilterGroupParameters(
                logic: "and",
                filters: filters,
                filterGroups: filterGroups
            );

            // Assert
            Assert.Equal("and", parameters.Logic);
            Assert.Equal(filters, parameters.Filters);
            Assert.Equal(filterGroups, parameters.FilterGroups);
        }
    }
}
