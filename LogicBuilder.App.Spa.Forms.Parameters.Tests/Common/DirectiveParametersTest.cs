using LogicBuilder.App.Spa.Forms.Parameters.Common;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class DirectiveParametersTest
    {
        [Fact]
        public void Constructor_WithParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var directiveDescription = new DirectiveDescriptionParameters("Directives", "hideIf");
            var conditionGroup = new ConditionGroupParameters("and");

            // Act
            var parameters = new DirectiveParameters(
                directiveDescription: directiveDescription,
                conditionGroup: conditionGroup
            );

            // Assert
            Assert.Equal(directiveDescription, parameters.DirectiveDescription);
            Assert.Equal(conditionGroup, parameters.ConditionGroup);
        }
    }
}
