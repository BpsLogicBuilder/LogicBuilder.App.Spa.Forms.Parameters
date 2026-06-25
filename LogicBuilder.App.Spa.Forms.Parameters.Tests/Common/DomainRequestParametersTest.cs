using LogicBuilder.App.Spa.Forms.Parameters.Common;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class DomainRequestParametersTest
    {
        [Fact]
        public void Constructor_WithParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var state = new DataRequestStateParameters(skip: 0, take: 10);
            var requestDetails = new RequestDetailsParameters(
                modelType: "MyApp.Domain.Entities.Entity",
                dataType: "MyApp.Data.Entities.Entity",
                modelReturnType: "System.Collections.Generic.IEnumerable`1",
                dataReturnType: "System.Collections.Generic.IEnumerable`1"
            );

            // Act
            var parameters = new DomainRequestParameters(
                state: state,
                requestDetails: requestDetails
            );

            // Assert
            Assert.Equal(state, parameters.State);
            Assert.Equal(requestDetails, parameters.RequestDetails);
        }
    }
}
