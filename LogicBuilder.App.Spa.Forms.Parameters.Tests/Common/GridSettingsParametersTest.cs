using LogicBuilder.App.Spa.Forms.Parameters.Common;
using System.Collections.Generic;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class GridSettingsParametersTest
    {
        [Fact]
        public void Constructor_WithRequiredParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var requestDetails = new GridRequestDetailsParameters(
                modelType: "MyApp.Domain.Entities.Student",
                dataType: "MyApp.Data.Entities.Student"
            );
            var columns = new List<ColumnSettingsParameters>
            {
                new("Name", "Student Name", "text")
            };

            // Act
            var parameters = new GridSettingsParameters(
                title: "Students Grid",
                sortable: true,
                pageable: true,
                scrollable: "scrollable",
                groupable: false,
                isFilterable: true,
                filterableType: "menu",
                requestDetails: requestDetails,
                columns: columns
            );

            // Assert
            Assert.Equal("Students Grid", parameters.Title);
            Assert.True(parameters.Sortable);
            Assert.True(parameters.Pageable);
            Assert.Equal("scrollable", parameters.Scrollable);
            Assert.False(parameters.Groupable);
            Assert.True(parameters.IsFilterable);
            Assert.Equal("menu", parameters.FilterableType);
            Assert.Equal(requestDetails, parameters.RequestDetails);
            Assert.Equal(columns, parameters.Columns);
            Assert.Null(parameters.GridId);
            Assert.Null(parameters.Height);
            Assert.Null(parameters.CommandColumn);
            Assert.Null(parameters.State);
            Assert.Null(parameters.Aggregates);
            Assert.Null(parameters.DetailGridSettings);
        }

        [Fact]
        public void Constructor_FilterableProperty_ReturnsCorrectValue()
        {
            // Arrange
            var requestDetails = new GridRequestDetailsParameters(
                modelType: "MyApp.Domain.Entities.Student",
                dataType: "MyApp.Data.Entities.Student"
            );
            var columns = new List<ColumnSettingsParameters>();

            // Act - with filterableType set
            var parameters1 = new GridSettingsParameters(
                title: "Test Grid",
                sortable: true,
                pageable: true,
                scrollable: "",
                groupable: false,
                isFilterable: false,
                filterableType: "row",
                requestDetails: requestDetails,
                columns: columns
            );

            // Act - without filterableType
            var parameters2 = new GridSettingsParameters(
                title: "Test Grid",
                sortable: true,
                pageable: true,
                scrollable: "",
                groupable: false,
                isFilterable: true,
                filterableType: "",
                requestDetails: requestDetails,
                columns: columns
            );

            // Assert
            Assert.Equal("row", parameters1.Filterable);
            Assert.True((bool)parameters2.Filterable);
        }
    }
}
