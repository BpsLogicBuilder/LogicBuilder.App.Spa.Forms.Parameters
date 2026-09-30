using LogicBuilder.Attributes;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class SignalRConnectionParameters(
        [Comments("The hub's endpoint minus the base URL e.g. /agentChatHub")]
        [NameValue(AttributeNames.DEFAULTVALUE, "/agentChatHub")]
        string agentHubUrl,

        [Comments("Message triggered by the SinalR hub on error.")]
        [NameValue(AttributeNames.DEFAULTVALUE, "ReceiveAgentError")]
        string receiveAgentErrorHandler,

        [Comments("Message triggered by the SinalR hub to send a message to the client.")]
        [NameValue(AttributeNames.DEFAULTVALUE, "ReceiveAgentChunk")]
        string receiveAgentMessageHandler,

        [Comments("This will be sent from the hub once the response is complet in either streaming or single message scenarios.")]
        [NameValue(AttributeNames.DEFAULTVALUE, "ReceiveAgentResponseComplete")]
        string receiveAgentResponseCompleteHandler,

        [Comments("use this method tp send a request to the SignalR chat hub from the SPA client.")]
        [NameValue(AttributeNames.DEFAULTVALUE, "SendMessageToAgent")]
        string sendMessageToAgentHubMethodName,

        [Comments("Message triggered by the SinalR hub when a new sesion has been initiated.")]
        [NameValue(AttributeNames.DEFAULTVALUE, "SessionInitialized")]
        string sessionInitializedHandler)
    {
        public string AgentHubUrl { get; } = agentHubUrl;
        public string ReceiveAgentErrorHandler { get; } = receiveAgentErrorHandler;
        public string ReceiveAgentMessageHandler { get; } = receiveAgentMessageHandler;
        public string ReceiveAgentResponseCompleteHandler { get; } = receiveAgentResponseCompleteHandler;
        public string SendMessageToAgentHubMethodName { get; } = sendMessageToAgentHubMethodName;
        public string SessionInitializedHandler { get; } = sessionInitializedHandler;
    }
}
