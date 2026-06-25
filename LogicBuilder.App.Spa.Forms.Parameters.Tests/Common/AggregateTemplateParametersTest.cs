using LogicBuilder.App.Spa.Forms.Parameters.Common;
using System.Collections.Generic;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class AggregateTemplateParametersTest
    {
        [Fact]
        public void Constructor_WithParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var aggregates = new List<AggregateTemplateFieldsParameters>
            {
                new("Label1", "sum"),
                new("Label2", "average")
            };

            // Act
            var parameters = new AggregateTemplateParameters(
                templateName: "TestTemplate",
                aggregates: aggregates
            );

            // Assert
            Assert.Equal("TestTemplate", parameters.TemplateName);
            Assert.Equal(2, parameters.Aggregates.Count);
            Assert.Equal(aggregates, parameters.Aggregates);
        }
    }
}
