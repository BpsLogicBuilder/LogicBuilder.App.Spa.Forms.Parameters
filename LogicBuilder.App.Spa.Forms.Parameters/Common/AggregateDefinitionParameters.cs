using LogicBuilder.Attributes;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class AggregateDefinitionParameters(
            [Comments("Update modelType first. Property name for the aggregate field. Use a period for nested fields i.e. foo.bar.")]
            [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
            [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, nameof(modelType))]
            string field,

            [Domain("average,count,max,min,sum")]
            [ParameterEditorControl(ParameterControlType.DropDown)]
            string aggregate,

            [ParameterEditorControl(ParameterControlType.ParameterSourceOnly)]
            [NameValue(AttributeNames.DEFAULTVALUE, "<myApp>.Domain.Entities.<EntityName>")]
            [Comments("Fully qualified class name for the model type.")]
            string? modelType = null
        )
    {
        public string Field { get; } = field;
        public string Aggregate { get; } = aggregate;
        public string? ModelType { get; } = modelType;
    }
}