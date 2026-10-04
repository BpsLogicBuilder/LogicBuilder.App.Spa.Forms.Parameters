using LogicBuilder.Attributes;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class ChatFormSettingsParameters(
        [NameValue(AttributeNames.DEFAULTVALUE, "Title")]
        [Comments("Header field on the form")]
        string title,

        [Comments("Name for the agent configuration used by the chat.  Ah agent configuration specifies the model, the instructions and the tools available to the agent e.g. knowledge-search-only")]
        string agentConfigurationIdentifier,

        [Comments("The height of the chat area in pixels.")]
        [NameValue(AttributeNames.DEFAULTVALUE, "550")]
        int chatHeight,

        [Comments("The width of the chat area in pixels.")]
        [NameValue(AttributeNames.DEFAULTVALUE, "600")]
        int chatWidth,

        [Comments("Includes configurable setting for the SignalR connection like the relative URL for the hub and event handler names.")]
        SignalRConnectionParameters signalRConnection)
    {
        public string Title { get; } = title;
        public string AgentConfigurationIdentifier { get; } = agentConfigurationIdentifier;
        public int ChatHeight { get; } = chatHeight;
        public int ChatWidth { get; } = chatWidth;
        public SignalRConnectionParameters SignalRConnection { get; } = signalRConnection;
    }
}
