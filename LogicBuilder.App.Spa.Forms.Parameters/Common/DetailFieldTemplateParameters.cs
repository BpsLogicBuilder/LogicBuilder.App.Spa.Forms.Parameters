using LogicBuilder.Attributes;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class DetailFieldTemplateParameters(
        [Comments("HTML template for the field.")]
        [NameValue(AttributeNames.DEFAULTVALUE, "textTemplate")]
        string templateName
    )
    {
        public string TemplateName { get; } = templateName;
    }
}
