using LogicBuilder.Attributes;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class MessageTemplateParameters(
            [NameValue(AttributeNames.DEFAULTVALUE, "Caption")]
            [Comments("Caption for the message.")]
            string caption,

            [NameValue(AttributeNames.DEFAULTVALUE, "Message Text")]
            [Comments("The message text.")]
            string message,

            [NameValue(AttributeNames.DEFAULTVALUE, "messageTemplate")]
            [Comments("HTML template for the control's layout.")]
            string templateName
        )
    {
        public string Caption { get; } = caption;
        public string Message { get; } = message;
        public string TemplateName { get; } = templateName;
    }
}
