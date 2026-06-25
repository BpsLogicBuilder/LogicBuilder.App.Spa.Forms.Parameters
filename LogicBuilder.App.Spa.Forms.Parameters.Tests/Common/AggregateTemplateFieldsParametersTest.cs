using LogicBuilder.App.Spa.Forms.Parameters.Common;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class AggregateTemplateFieldsParametersTest
    {
        [Fact]
        public void Constructor_WithParameters_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var parameters = new AggregateTemplateFieldsParameters(
                label: "Test Label",
                aggregateFunction: "sum"
            );

            // Assert
            Assert.Equal("Test Label", parameters.Label);
            Assert.Equal("sum", parameters.Function);
        }
    }
}
