using LogicBuilder.Attributes;
using System.Collections.Generic;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class GroupParameters(
        [Comments("Update modelType first. Property name from the target object. Use a period for nested fields i.e. foo.bar.")]
        [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
        [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, nameof(modelType))]
        string field,

        [Domain("asc,desc")]
        [ParameterEditorControl(ParameterControlType.DropDown)]
        string dir,

        List<AggregateDefinitionParameters> aggregates,

        [ParameterEditorControl(ParameterControlType.ParameterSourceOnly)]
        [NameValue(AttributeNames.DEFAULTVALUE, "<myApp>.Domain.Entities.<EntityName>")]
        [Comments("Fully qualified class name for the model type.")]
        string? modelType = null
    )
    {
        public string Field { get; set; } = field;
        public string Dir { get; set; } = dir;
        public List<AggregateDefinitionParameters> Aggregates { get; set; } = aggregates;
        public string? ModelType { get; set; } = modelType;
    }
}