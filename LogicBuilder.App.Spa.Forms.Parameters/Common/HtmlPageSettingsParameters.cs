using LogicBuilder.Attributes;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class HtmlPageSettingsParameters(
        [Comments("Template when the page will be used for markup.")]
        ContentTemplateParameters? contentTemplate = null,

        [Comments("Template when the page will be used to display a message or ask a question.")]
        MessageTemplateParameters? messageTemplate = null
    )
    {
        public ContentTemplateParameters? ContentTemplate { get; set; } = contentTemplate;
        public MessageTemplateParameters? MessageTemplate { get; set; } = messageTemplate;
    }
}
