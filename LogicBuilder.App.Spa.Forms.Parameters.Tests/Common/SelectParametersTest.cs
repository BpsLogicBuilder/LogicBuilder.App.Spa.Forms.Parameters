using LogicBuilder.App.Spa.Forms.Parameters.Common;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class SelectParametersTest
    {
        [Fact]
        public void Constructor_WithRequiredParameters_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var parameters = new SelectParameters(
                fieldName: "FullName",
                sourceMember: "Name"
            );

            // Assert
            Assert.Equal("FullName", parameters.FieldName);
            Assert.Equal("Name", parameters.SourceMember);
            Assert.Null(parameters.ModelType);
        }

        [Fact]
        public void Constructor_WithAllParameters_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var parameters = new SelectParameters(
                fieldName: "StudentName",
                sourceMember: "Student.FullName",
                modelType: "MyApp.Domain.Entities.Enrollment"
            );

            // Assert
            Assert.Equal("StudentName", parameters.FieldName);
            Assert.Equal("Student.FullName", parameters.SourceMember);
            Assert.Equal("MyApp.Domain.Entities.Enrollment", parameters.ModelType);
        }
    }
}
