using LogicBuilder.App.Spa.Forms.Parameters.Common;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class ChatFormSettingsParametersTest
    {
        [Fact]
        public void Constructor_WithAllParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var signalRConnection = new SignalRConnectionParameters(
                "/agentChatHub",
                "ReceiveAgentError",
                "ReceiveAgentChunk",
                "ReceiveAgentResponseComplete",
                "SendMessageToAgent",
                "SessionInitialized"
            );

            // Act
            var parameters = new ChatFormSettingsParameters(
                title: "Agent Chat Form",
                agentConfigurationIdentifier: "knowledge-search-only",
                chatHeight: 550,
                chatWidth: 600,
                signalRConnection: signalRConnection
            );

            // Assert
            Assert.Equal("Agent Chat Form", parameters.Title);
            Assert.Equal("knowledge-search-only", parameters.AgentConfigurationIdentifier);
            Assert.Equal(550, parameters.ChatHeight);
            Assert.Equal(600, parameters.ChatWidth);
            Assert.Same(signalRConnection, parameters.SignalRConnection);
        }

        [Fact]
        public void Constructor_WithNullReferenceParameters_SetsPropertiesToNull()
        {
            // Arrange & Act
            var parameters = new ChatFormSettingsParameters(null!, null!, 0, 0, null!);

            // Assert
            Assert.Null(parameters.Title);
            Assert.Null(parameters.AgentConfigurationIdentifier);
            Assert.Equal(0, parameters.ChatHeight);
            Assert.Equal(0, parameters.ChatWidth);
            Assert.Null(parameters.SignalRConnection);
        }
    }
}
