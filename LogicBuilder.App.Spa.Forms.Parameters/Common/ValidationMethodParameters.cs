using LogicBuilder.Attributes;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class ValidationMethodParameters(
        [Comments("Method")]
        [NameValue(AttributeNames.DEFAULTVALUE, "required")]
        string method,

        [Comments("Validation message.")]
        [NameValue(AttributeNames.DEFAULTVALUE, "(Title) is required.")]
        string message
    )
    {
        public string Method { get; } = method;
        public string Message { get; } = message;
    }
}
