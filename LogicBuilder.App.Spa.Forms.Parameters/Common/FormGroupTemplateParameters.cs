using LogicBuilder.Attributes;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class FormGroupTemplateParameters(
        [Comments("HTML template for the form group.")]
        [NameValue(AttributeNames.DEFAULTVALUE, "formGroupTemplate")]
        string templateName
    )
    {
        public string TemplateName { get; } = templateName;
    }
}
