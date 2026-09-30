using LogicBuilder.App.Spa.Forms.Parameters.Common;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class SignalRConnectionParametersTest
    {
        [Fact]
        public void Constructor_WithAllParameters_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var parameters = new SignalRConnectionParameters(
                agentHubUrl: "/agentChatHub",
                receiveAgentErrorHandler: "ReceiveAgentError",
                receiveAgentMessageHandler: "ReceiveAgentChunk",
                receiveAgentResponseCompleteHandler: "ReceiveAgentResponseComplete",
                sendMessageToAgentHubMethodName: "SendMessageToAgent",
                sessionInitializedHandler: "SessionInitialized"
            );

            // Assert
            Assert.Equal("/agentChatHub", parameters.AgentHubUrl);
            Assert.Equal("ReceiveAgentError", parameters.ReceiveAgentErrorHandler);
            Assert.Equal("ReceiveAgentChunk", parameters.ReceiveAgentMessageHandler);
            Assert.Equal("ReceiveAgentResponseComplete", parameters.ReceiveAgentResponseCompleteHandler);
            Assert.Equal("SendMessageToAgent", parameters.SendMessageToAgentHubMethodName);
            Assert.Equal("SessionInitialized", parameters.SessionInitializedHandler);
        }

        [Fact]
        public void Constructor_WithNullParameters_SetsPropertiesToNull()
        {
            // Arrange & Act
            var parameters = new SignalRConnectionParameters(null!, null!, null!, null!, null!, null!);

            // Assert
            Assert.Null(parameters.AgentHubUrl);
            Assert.Null(parameters.ReceiveAgentErrorHandler);
            Assert.Null(parameters.ReceiveAgentMessageHandler);
            Assert.Null(parameters.ReceiveAgentResponseCompleteHandler);
            Assert.Null(parameters.SendMessageToAgentHubMethodName);
            Assert.Null(parameters.SessionInitializedHandler);
        }
    }
}
