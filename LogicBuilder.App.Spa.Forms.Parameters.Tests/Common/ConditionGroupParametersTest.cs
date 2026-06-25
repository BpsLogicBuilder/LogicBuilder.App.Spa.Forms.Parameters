using LogicBuilder.App.Spa.Forms.Parameters.Common;
using System.Collections.Generic;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class ConditionGroupParametersTest
    {
        [Fact]
        public void Constructor_WithLogicOnly_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var parameters = new ConditionGroupParameters(logic: "and");

            // Assert
            Assert.Equal("and", parameters.Logic);
            Assert.Null(parameters.Conditions);
            Assert.Null(parameters.ConditionGroups);
        }

        [Fact]
        public void Constructor_WithAllParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var conditions = new List<ConditionParameters>
            {
                new(@operator: "eq", leftVariable: "Status")
            };
            var conditionGroups = new List<ConditionGroupParameters>
            {
                new(logic: "or")
            };

            // Act
            var parameters = new ConditionGroupParameters(
                logic: "and",
                conditions: conditions,
                conditionGroups: conditionGroups
            );

            // Assert
            Assert.Equal("and", parameters.Logic);
            Assert.Equal(conditions, parameters.Conditions);
            Assert.Equal(conditionGroups, parameters.ConditionGroups);
        }
    }
}
