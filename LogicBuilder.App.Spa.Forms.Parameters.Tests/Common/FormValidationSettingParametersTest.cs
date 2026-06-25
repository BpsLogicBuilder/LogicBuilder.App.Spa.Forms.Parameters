using LogicBuilder.App.Spa.Forms.Parameters.Common;
using System.Collections.Generic;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class FormValidationSettingParametersTest
    {
        [Fact]
        public void Constructor_WithDefaultValues_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var parameters = new FormValidationSettingParameters();

            // Assert
            Assert.Null(parameters.DefaultValue);
            Assert.NotNull(parameters.Validators);
            Assert.Empty(parameters.Validators);
        }

        [Fact]
        public void Constructor_WithAllParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var validators = new List<ValidatorDescriptionParameters>
            {
                new("Validators", "required")
            };

            // Act
            var parameters = new FormValidationSettingParameters(
                defaultValue: "DefaultText",
                validators: validators
            );

            // Assert
            Assert.Equal("DefaultText", parameters.DefaultValue);
            Assert.Equal(validators, parameters.Validators);
        }
    }
}
