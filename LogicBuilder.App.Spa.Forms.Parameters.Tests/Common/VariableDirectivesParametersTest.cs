using LogicBuilder.App.Spa.Forms.Parameters.Common;
using System.Collections.Generic;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class VariableDirectivesParametersTest
    {
        [Fact]
        public void Constructor_WithRequiredParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var conditionalDirectives = new List<DirectiveParameters>
            {
                new(
                    new DirectiveDescriptionParameters("Directives", "hideIf"),
                    new ConditionGroupParameters("and")
                )
            };

            // Act
            var parameters = new VariableDirectivesParameters(
                field: "Status",
                conditionalDirectives: conditionalDirectives
            );

            // Assert
            Assert.Equal("Status", parameters.Field);
            Assert.Equal(conditionalDirectives, parameters.ConditionalDirectives);
            Assert.Null(parameters.ModelType);
        }

        [Fact]
        public void Constructor_WithAllParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var conditionalDirectives = new List<DirectiveParameters>
            {
                new(
                    new DirectiveDescriptionParameters("Directives", "validateIf"),
                    new ConditionGroupParameters("or")
                )
            };

            // Act
            var parameters = new VariableDirectivesParameters(
                field: "Priority",
                conditionalDirectives: conditionalDirectives,
                modelType: "MyApp.Domain.Entities.Task"
            );

            // Assert
            Assert.Equal("Priority", parameters.Field);
            Assert.Equal(conditionalDirectives, parameters.ConditionalDirectives);
            Assert.Equal("MyApp.Domain.Entities.Task", parameters.ModelType);
        }
    }
}
