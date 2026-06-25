using LogicBuilder.App.Spa.Forms.Parameters.Common;
using LogicBuilder.Forms.Parameters.Expressions;
using System.Collections.Generic;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class ListFormSettingsParametersTest
    {
        [Fact]
        public void Constructor_WithRequiredParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var fieldsSelector = new SelectorLambdaOperatorParameters(null!, null!, null!);
            var requestDetails = new RequestDetailsParameters(
                "MyApp.Domain.Entities.Student",
                "MyApp.Data.Entities.Student",
                "System.Collections.Generic.IEnumerable`1",
                "System.Collections.Generic.IEnumerable`1"
            );
            var fieldSettings = new List<IDetailItemParameters>();

            // Act
            var parameters = new ListFormSettingsParameters(
                title: "Students List",
                fieldsSelector: fieldsSelector,
                requestDetails: requestDetails,
                fieldSettings: fieldSettings
            );

            // Assert
            Assert.Equal("Students List", parameters.Title);
            Assert.Equal(fieldsSelector, parameters.FieldsSelector);
            Assert.Equal(requestDetails, parameters.RequestDetails);
            Assert.Equal(fieldSettings, parameters.FieldSettings);
        }
    }
}
