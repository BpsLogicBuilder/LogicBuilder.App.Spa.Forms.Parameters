using LogicBuilder.Attributes;
using System.Collections.Generic;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class VariableDirectivesParameters(
            [Comments("Update modelType first. Source property name from the target object.")]
            [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
            [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, nameof(modelType))]
            [NameValue(AttributeNames.USEFOREQUALITY, "true")]
            [NameValue(AttributeNames.USEFORHASHCODE, "true")]
            string field,

            [Comments("List of conditional directives for this field.")]
            List<DirectiveParameters> conditionalDirectives,

            [ParameterEditorControl(ParameterControlType.ParameterSourceOnly)]
            [NameValue(AttributeNames.DEFAULTVALUE, "<myApp>.Domain.Entities.<EntityName>")]
            [Comments("Fully qualified class name for the model type.")]
            [NameValue(AttributeNames.USEFOREQUALITY, "false")]
            [NameValue(AttributeNames.USEFORHASHCODE, "false")]
            string? modelType = null
        )
    {
        public string Field { get; set; } = field;
        public List<DirectiveParameters> ConditionalDirectives { get; set; } = conditionalDirectives;
        public string? ModelType { get; set; } = modelType;
    }
}
