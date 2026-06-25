using LogicBuilder.App.Spa.Forms.Parameters.Common;
using System.Collections.Generic;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class DetailFormSettingsParametersTest
    {
        [Fact]
        public void Constructor_WithRequiredParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var requestDetails = new FormRequestDetailsParameters(
                getUrl: "/api/Entity/Get",
                addUrl: "/api/Entity/Add",
                updateUrl: "/api/Entity/Update",
                deleteUrl: "/api/Entity/Delete",
                modelType: "MyApp.Domain.Entities.Entity",
                dataType: "MyApp.Data.Entities.Entity"
            );
            var fieldSettings = new List<IDetailItemParameters>();

            // Act
            var parameters = new DetailFormSettingsParameters(
                title: "Entity Details",
                displayField: "Name",
                requestDetails: requestDetails,
                fieldSettings: fieldSettings
            );

            // Assert
            Assert.Equal("Entity Details", parameters.Title);
            Assert.Equal("Name", parameters.DisplayField);
            Assert.Equal(requestDetails, parameters.RequestDetails);
            Assert.Equal(fieldSettings, parameters.FieldSettings);
            Assert.Equal("<myApp>.Domain.Entities.<EntityName>", parameters.ModelType);
        }

        [Fact]
        public void Constructor_WithAllParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var requestDetails = new FormRequestDetailsParameters(
                getUrl: "/api/Student/Get",
                addUrl: "/api/Student/Add",
                updateUrl: "/api/Student/Update",
                deleteUrl: "/api/Student/Delete",
                modelType: "MyApp.Domain.Entities.Student",
                dataType: "MyApp.Data.Entities.Student"
            );
            var fieldSettings = new List<IDetailItemParameters>
            {
                new DetailFieldSettingParameters("FirstName", "First Name", "text", "MyApp.Domain.Entities.Student")
            };

            // Act
            var parameters = new DetailFormSettingsParameters(
                title: "Student Details",
                displayField: "FullName",
                requestDetails: requestDetails,
                fieldSettings: fieldSettings,
                modelType: "MyApp.Domain.Entities.Student"
            );

            // Assert
            Assert.Equal("Student Details", parameters.Title);
            Assert.Equal("FullName", parameters.DisplayField);
            Assert.Equal(requestDetails, parameters.RequestDetails);
            Assert.Equal(fieldSettings, parameters.FieldSettings);
            Assert.Equal("MyApp.Domain.Entities.Student", parameters.ModelType);
        }
    }
}
