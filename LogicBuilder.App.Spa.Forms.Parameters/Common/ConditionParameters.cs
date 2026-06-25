using LogicBuilder.Attributes;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class ConditionParameters(
            [Comments("The condition operator (comparison).")]
            [Domain("eq, neq, lt, lte, gt, gte, contains, doesnotcontain, startswith, endswith, isnotempty, isempty, isnotnull, isnull")]
            [ParameterEditorControl(ParameterControlType.DropDown)]
            string @operator,

            [Comments("Left operand.")]
            [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
            [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, nameof(modelType))]
            string leftVariable,

            [Comments("Right operand.")]
            [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
            [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, nameof(modelType))]
            string? rightVariable = null,

            [Comments("Alternative to right operand.")]
            object? value = null,

            [ParameterEditorControl(ParameterControlType.ParameterSourceOnly)]
            [NameValue(AttributeNames.DEFAULTVALUE, "<myApp>.Domain.Entities.<EntityName>")]
            [Comments("Fully qualified class name for the model type.")]
            string? modelType = null

        )
    {
        public string Operator { get; } = @operator;
        public string LeftVariable { get; } = leftVariable;
        public string? RightVariable { get; } = rightVariable;
        public object? Value { get; } = value;
        public string? ModelType { get; } = modelType;
    }
}