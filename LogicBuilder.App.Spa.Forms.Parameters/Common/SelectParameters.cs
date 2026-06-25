using LogicBuilder.Attributes;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class SelectParameters(
        [Comments("Property name for field in the anonymous type.")]
        string fieldName,

        [Comments("Update modelType first. Source property name from the target object. Use a period for nested fields i.e. foo.bar.")]
        [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
        [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, nameof(modelType))]
        string sourceMember,

        [ParameterEditorControl(ParameterControlType.ParameterSourceOnly)]
        [NameValue(AttributeNames.DEFAULTVALUE, "<myApp>.Domain.Entities.<EntityName>")]
        [Comments("Fully qualified class name for the model type.")]
        string? modelType = null
    )
    {
        public string FieldName { get; } = fieldName;
        public string SourceMember { get; } = sourceMember;
        public string? ModelType { get; } = modelType;
    }
}
