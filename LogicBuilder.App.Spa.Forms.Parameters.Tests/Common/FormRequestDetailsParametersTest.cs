using LogicBuilder.App.Spa.Forms.Parameters.Common;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class FormRequestDetailsParametersTest
    {
        [Fact]
        public void Constructor_WithRequiredParameters_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var parameters = new FormRequestDetailsParameters(
                getUrl: "/api/Student/Get",
                addUrl: "/api/Student/Add",
                updateUrl: "/api/Student/Update",
                deleteUrl: "/api/Student/Delete",
                modelType: "MyApp.Domain.Entities.Student",
                dataType: "MyApp.Data.Entities.Student"
            );

            // Assert
            Assert.Equal("/api/Student/Get", parameters.GetUrl);
            Assert.Equal("/api/Student/Add", parameters.AddUrl);
            Assert.Equal("/api/Student/Update", parameters.UpdateUrl);
            Assert.Equal("/api/Student/Delete", parameters.DeleteUrl);
            Assert.Equal("MyApp.Domain.Entities.Student", parameters.ModelType);
            Assert.Equal("MyApp.Data.Entities.Student", parameters.DataType);
            Assert.Null(parameters.Filter);
            Assert.Null(parameters.SelectExpandDefinition);
        }

        [Fact]
        public void Constructor_WithAllParameters_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var parameters = new FormRequestDetailsParameters(
                getUrl: "/api/Order/Get",
                addUrl: "/api/Order/Add",
                updateUrl: "/api/Order/Update",
                deleteUrl: "/api/Order/Delete",
                modelType: "MyApp.Domain.Entities.Order",
                dataType: "MyApp.Data.Entities.Order",
                filter: null,
                selectExpandDefinition: null
            );

            // Assert
            Assert.Equal("/api/Order/Get", parameters.GetUrl);
            Assert.Equal("/api/Order/Add", parameters.AddUrl);
            Assert.Equal("/api/Order/Update", parameters.UpdateUrl);
            Assert.Equal("/api/Order/Delete", parameters.DeleteUrl);
            Assert.Equal("MyApp.Domain.Entities.Order", parameters.ModelType);
            Assert.Equal("MyApp.Data.Entities.Order", parameters.DataType);
        }
    }
}
