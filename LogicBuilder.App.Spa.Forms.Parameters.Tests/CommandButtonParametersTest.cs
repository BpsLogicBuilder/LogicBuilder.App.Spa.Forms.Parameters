using LogicBuilder.App.Spa.Forms.Parameters;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests
{
    public class CommandButtonParametersTest
    {
        [Fact]
        public void Constructor_WithDefaultValues_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var parameters = new CommandButtonParameters();

            // Assert
            Assert.False(parameters.Cancel);
            Assert.Null(parameters.GridId);
            Assert.Null(parameters.GridCommandButton);
            Assert.Equal("fa-step-forward", parameters.ButtonIcon);
            Assert.Equal("btn btn-secondary", parameters.ClassString);
        }

        [Fact]
        public void Constructor_WithCustomCancel_SetsPropertyCorrectly()
        {
            // Arrange & Act
            var parameters = new CommandButtonParameters(cancel: true);

            // Assert
            Assert.True(parameters.Cancel);
            Assert.Null(parameters.GridId);
            Assert.Null(parameters.GridCommandButton);
            Assert.Equal("fa-step-forward", parameters.ButtonIcon);
            Assert.Equal("btn btn-secondary", parameters.ClassString);
        }

        [Fact]
        public void Constructor_WithCustomGridId_SetsPropertyCorrectly()
        {
            // Arrange & Act
            var parameters = new CommandButtonParameters(gridId: 42);

            // Assert
            Assert.False(parameters.Cancel);
            Assert.Equal(42, parameters.GridId);
            Assert.Null(parameters.GridCommandButton);
            Assert.Equal("fa-step-forward", parameters.ButtonIcon);
            Assert.Equal("btn btn-secondary", parameters.ClassString);
        }

        [Fact]
        public void Constructor_WithCustomGridCommandButton_SetsPropertyCorrectly()
        {
            // Arrange & Act
            var parameters = new CommandButtonParameters(gridCommandButton: true);

            // Assert
            Assert.False(parameters.Cancel);
            Assert.Null(parameters.GridId);
            Assert.True(parameters.GridCommandButton);
            Assert.Equal("fa-step-forward", parameters.ButtonIcon);
            Assert.Equal("btn btn-secondary", parameters.ClassString);
        }

        [Fact]
        public void Constructor_WithCustomButtonIcon_SetsPropertyCorrectly()
        {
            // Arrange & Act
            var parameters = new CommandButtonParameters(buttonIcon: "fa-save");

            // Assert
            Assert.False(parameters.Cancel);
            Assert.Null(parameters.GridId);
            Assert.Null(parameters.GridCommandButton);
            Assert.Equal("fa-save", parameters.ButtonIcon);
            Assert.Equal("btn btn-secondary", parameters.ClassString);
        }

        [Fact]
        public void Constructor_WithCustomClassString_SetsPropertyCorrectly()
        {
            // Arrange & Act
            var parameters = new CommandButtonParameters(classString: "btn btn-primary");

            // Assert
            Assert.False(parameters.Cancel);
            Assert.Null(parameters.GridId);
            Assert.Null(parameters.GridCommandButton);
            Assert.Equal("fa-step-forward", parameters.ButtonIcon);
            Assert.Equal("btn btn-primary", parameters.ClassString);
        }

        [Fact]
        public void Constructor_WithAllCustomValues_SetsAllPropertiesCorrectly()
        {
            // Arrange & Act
            var parameters = new CommandButtonParameters(
                cancel: true,
                gridId: 100,
                gridCommandButton: false,
                buttonIcon: "fa-trash",
                classString: "btn btn-danger"
            );

            // Assert
            Assert.True(parameters.Cancel);
            Assert.Equal(100, parameters.GridId);
            Assert.False(parameters.GridCommandButton);
            Assert.Equal("fa-trash", parameters.ButtonIcon);
            Assert.Equal("btn btn-danger", parameters.ClassString);
        }

        [Fact]
        public void Constructor_WithMixedValues_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var parameters = new CommandButtonParameters(
                cancel: true,
                buttonIcon: "fa-edit",
                classString: "btn btn-warning"
            );

            // Assert
            Assert.True(parameters.Cancel);
            Assert.Null(parameters.GridId);
            Assert.Null(parameters.GridCommandButton);
            Assert.Equal("fa-edit", parameters.ButtonIcon);
            Assert.Equal("btn btn-warning", parameters.ClassString);
        }
    }
}
