using LogicBuilder.Attributes;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class DetailGroupTemplateParameters(
        [Comments("HTML template for the group.")]
            [NameValue(AttributeNames.DEFAULTVALUE, "groupTemplate")]
            string templateName
        )
    {
        public string TemplateName { get; } = templateName;
    }
}
