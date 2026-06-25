using LogicBuilder.App.Spa.Forms.Parameters.Common;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class GridRequestDetailsParametersTest
    {
        [Fact]
        public void Constructor_WithRequiredParameters_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var parameters = new GridRequestDetailsParameters(
                modelType: "MyApp.Domain.Entities.Student",
                dataType: "MyApp.Data.Entities.Student"
            );

            // Assert
            Assert.Equal("MyApp.Domain.Entities.Student", parameters.ModelType);
            Assert.Equal("MyApp.Data.Entities.Student", parameters.DataType);
            Assert.Equal("/api/Generic/GetData", parameters.DataSourceUrl);
            Assert.Null(parameters.SelectExpandDefinition);
        }

        [Fact]
        public void Constructor_WithAllParameters_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var parameters = new GridRequestDetailsParameters(
                modelType: "MyApp.Domain.Entities.Order",
                dataType: "MyApp.Data.Entities.Order",
                dataSourceUrl: "/api/Orders/GetData",
                selectExpandDefinition: null
            );

            // Assert
            Assert.Equal("MyApp.Domain.Entities.Order", parameters.ModelType);
            Assert.Equal("MyApp.Data.Entities.Order", parameters.DataType);
            Assert.Equal("/api/Orders/GetData", parameters.DataSourceUrl);
            Assert.Null(parameters.SelectExpandDefinition);
        }
    }
}
