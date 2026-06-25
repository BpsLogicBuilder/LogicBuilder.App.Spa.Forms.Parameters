using LogicBuilder.Attributes;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class DetailListTemplateParameters(
        [Comments("HTML template for the list.")]
        [NameValue(AttributeNames.DEFAULTVALUE, "listTemplate")]
        string templateName
    )
    {
        public string TemplateName { get; } = templateName;
    }
}
