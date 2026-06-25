using LogicBuilder.App.Spa.Forms.Parameters.Common;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class SortParametersTest
    {
        [Fact]
        public void Constructor_WithRequiredParameters_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var parameters = new SortParameters(
                field: "LastName",
                dir: "asc"
            );

            // Assert
            Assert.Equal("LastName", parameters.Field);
            Assert.Equal("asc", parameters.Dir);
            Assert.Null(parameters.ModelType);
        }

        [Fact]
        public void Constructor_WithAllParameters_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var parameters = new SortParameters(
                field: "CreatedDate",
                dir: "desc",
                modelType: "MyApp.Domain.Entities.Order"
            );

            // Assert
            Assert.Equal("CreatedDate", parameters.Field);
            Assert.Equal("desc", parameters.Dir);
            Assert.Equal("MyApp.Domain.Entities.Order", parameters.ModelType);
        }
    }
}
