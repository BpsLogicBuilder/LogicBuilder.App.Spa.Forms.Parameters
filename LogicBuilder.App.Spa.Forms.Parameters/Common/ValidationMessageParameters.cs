using LogicBuilder.Attributes;
using System.Collections.Generic;
using System.Linq;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class ValidationMessageParameters(
        [Comments("Update modelType first. Source property name from the target object.")]
        [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
        [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, nameof(modelType))]
        string field,

        [Comments("Validation method and message to be used by the Reactive Forms validator.")]
        List<ValidationMethodParameters> methods,

        [ParameterEditorControl(ParameterControlType.ParameterSourceOnly)]
        [NameValue(AttributeNames.DEFAULTVALUE, "<myApp>.Domain.Entities.<EntityName>")]
        [Comments("Fully qualified class name for the model type.")]
        string? modelType = null
    )
    {
        public string Field { get; } = field;
        public Dictionary<string, string> Methods { get; } = methods.ToDictionary(kvp => kvp.Method, kvp => kvp.Message);
        public string? ModelType { get; } = modelType;
    }
}
