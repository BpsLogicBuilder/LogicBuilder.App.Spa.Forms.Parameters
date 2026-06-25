using LogicBuilder.App.Spa.Forms.Parameters.Common;
using System.Collections.Generic;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class DetailListSettingsParametersTest
    {
        [Fact]
        public void Constructor_WithRequiredParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var listTemplate = new DetailListTemplateParameters("listTemplate");
            var fieldSettings = new List<IDetailItemParameters>();

            // Act
            var parameters = new DetailListSettingsParameters(
                field: "Enrollments",
                title: "Student Enrollments",
                listTemplate: listTemplate,
                fieldSettings: fieldSettings
            );

            // Assert
            Assert.Equal(DetailItemType.List, parameters.DetailType);
            Assert.Equal("Enrollments", parameters.Field);
            Assert.Equal("Student Enrollments", parameters.Title);
            Assert.Equal(listTemplate, parameters.ListTemplate);
            Assert.Equal(fieldSettings, parameters.FieldSettings);
            Assert.Null(parameters.ModelType);
        }

        [Fact]
        public void Constructor_WithAllParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var listTemplate = new DetailListTemplateParameters("customList");
            var fieldSettings = new List<IDetailItemParameters>
            {
                new DetailFieldSettingParameters("CourseName", "Course", "text", "MyApp.Domain.Entities.Enrollment")
            };

            // Act
            var parameters = new DetailListSettingsParameters(
                field: "Courses",
                title: "Enrolled Courses",
                listTemplate: listTemplate,
                fieldSettings: fieldSettings,
                modelType: "MyApp.Domain.Entities.Student"
            );

            // Assert
            Assert.Equal(DetailItemType.List, parameters.DetailType);
            Assert.Equal("Courses", parameters.Field);
            Assert.Equal("Enrolled Courses", parameters.Title);
            Assert.Equal(listTemplate, parameters.ListTemplate);
            Assert.Equal(fieldSettings, parameters.FieldSettings);
            Assert.Equal("MyApp.Domain.Entities.Student", parameters.ModelType);
        }
    }
}
