using LogicBuilder.App.Spa.Forms.Parameters.Common;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class RequestDetailsParametersTest
    {
        [Fact]
        public void Constructor_WithRequiredParameters_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var parameters = new RequestDetailsParameters(
                modelType: "MyApp.Domain.Entities.Student",
                dataType: "MyApp.Data.Entities.Student",
                modelReturnType: "System.Collections.Generic.IEnumerable`1",
                dataReturnType: "System.Collections.Generic.IEnumerable`1"
            );

            // Assert
            Assert.Equal("MyApp.Domain.Entities.Student", parameters.ModelType);
            Assert.Equal("MyApp.Data.Entities.Student", parameters.DataType);
            Assert.Equal("System.Collections.Generic.IEnumerable`1", parameters.ModelReturnType);
            Assert.Equal("System.Collections.Generic.IEnumerable`1", parameters.DataReturnType);
            Assert.Equal("/api/List/GetList", parameters.DataSourceUrl);
            Assert.Null(parameters.SelectExpandDefinition);
        }

        [Fact]
        public void Constructor_WithAllParameters_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var parameters = new RequestDetailsParameters(
                modelType: "MyApp.Domain.Entities.Order",
                dataType: "MyApp.Data.Entities.Order",
                modelReturnType: "System.Collections.Generic.List`1",
                dataReturnType: "System.Collections.Generic.List`1",
                dataSourceUrl: "/api/Orders/GetList",
                selectExpandDefinition: null
            );

            // Assert
            Assert.Equal("MyApp.Domain.Entities.Order", parameters.ModelType);
            Assert.Equal("MyApp.Data.Entities.Order", parameters.DataType);
            Assert.Equal("System.Collections.Generic.List`1", parameters.ModelReturnType);
            Assert.Equal("System.Collections.Generic.List`1", parameters.DataReturnType);
            Assert.Equal("/api/Orders/GetList", parameters.DataSourceUrl);
            Assert.Null(parameters.SelectExpandDefinition);
        }
    }
}
