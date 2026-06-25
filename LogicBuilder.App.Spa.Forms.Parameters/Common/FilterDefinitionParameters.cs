using LogicBuilder.Attributes;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class FilterDefinitionParameters(
        [Comments("Update modelType first. Property name from the target object. Use a period for nested fields i.e. foo.bar.")]
        [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
        [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, nameof(modelType))]
        string field,

        [Comments("The filter operator (comparison).")]
        [Domain("eq, neq, lt, lte, gt, gte, contains, doesnotcontain, startswith, endswith, isnotempty, isempty, isnotnull, isnull")]
        [ParameterEditorControl(ParameterControlType.DropDown)]
        string oper,

        object? value = null,

        [Comments("Determines if the string comparison is case-insensitive.")]
        bool? ignoreCase = null,

        [Comments("A field name on a target object from which the value field will be retrieved at run time.")]
        string valueSourceMember = "",

        [ParameterEditorControl(ParameterControlType.ParameterSourceOnly)]
        [NameValue(AttributeNames.DEFAULTVALUE, "<myApp>.Domain.Entities.<EntityName>")]
        [Comments("Fully qualified class name for the model type.")]
        string? modelType = null
    )
    {
        public string Field { get; } = field;
        public string Operator { get; } = oper;
        public object? Value { get; } = value;
        public bool? IgnoreCase { get; } = ignoreCase;
        public string ValueSourceMember { get; } = valueSourceMember;
        public string? ModelType { get; } = modelType;
    }
}