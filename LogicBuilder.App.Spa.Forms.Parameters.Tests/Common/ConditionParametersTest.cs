using LogicBuilder.App.Spa.Forms.Parameters.Common;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class ConditionParametersTest
    {
        [Fact]
        public void Constructor_WithRequiredParameters_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var parameters = new ConditionParameters(
                @operator: "eq",
                leftVariable: "Status"
            );

            // Assert
            Assert.Equal("eq", parameters.Operator);
            Assert.Equal("Status", parameters.LeftVariable);
            Assert.Null(parameters.RightVariable);
            Assert.Null(parameters.Value);
            Assert.Null(parameters.ModelType);
        }

        [Fact]
        public void Constructor_WithAllParameters_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var parameters = new ConditionParameters(
                @operator: "neq",
                leftVariable: "Status",
                rightVariable: "ExpectedStatus",
                value: "Active",
                modelType: "MyApp.Domain.Entities.Order"
            );

            // Assert
            Assert.Equal("neq", parameters.Operator);
            Assert.Equal("Status", parameters.LeftVariable);
            Assert.Equal("ExpectedStatus", parameters.RightVariable);
            Assert.Equal("Active", parameters.Value);
            Assert.Equal("MyApp.Domain.Entities.Order", parameters.ModelType);
        }
    }
}
