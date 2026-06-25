using LogicBuilder.Attributes;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class CellListTemplateParameters(
            [Comments("HTML template name for the cell.")]
            string templateName,

            [Comments("Update modelType first. Source property name from the target object. Use a period for nested fields i.e. foo.bar.")]
            [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
            [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, nameof(modelType))]
            string displayMember,

            [ParameterEditorControl(ParameterControlType.ParameterSourceOnly)]
            [Comments("Fully qualified class name for the model type.")]
            string? modelType = "<myApp>.Domain.Entities.<EntityName>"
        )
    {
        public string TemplateName { get; } = templateName;
        public string DisplayMember { get; } = displayMember;
        public string? ModelType { get; } = modelType;
    }
}
