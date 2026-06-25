using LogicBuilder.Attributes;
using LogicBuilder.Forms.Parameters.Expressions;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class FilterTemplateParameters(
        string templateName,

        bool isPrimitive,

        [Comments("Update modelType first. Property name for the text field. Use a period for nested fields i.e. foo.bar.")]
        [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
        [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, nameof(modelType))]
        string textField,

        [Comments("Update modelType first. Property name for the value field. Use a period for nested fields i.e. foo.bar.")]
        [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
        [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, nameof(modelType))]
        string valueField,

        [Comments("Single object used for defining the selector lambda expression e.g. q => q.OrderBy(s => s.FullName).Select(a => new InstructorModel() {ID = a.ID, FullName = a.FullName})")]
        SelectorLambdaOperatorParameters textAndValueSelector,

        RequestDetailsParameters requestDetails,

        [ParameterEditorControl(ParameterControlType.ParameterSourceOnly)]
        [NameValue(AttributeNames.DEFAULTVALUE, "<myApp>.Domain.Entities.<EntityName>")]
        [Comments("Fully qualified class name for the model type.")]
        string? modelType = null
    )
    {
        public string TemplateName { get; } = templateName;
        public bool IsPrimitive { get; } = isPrimitive;
        public string TextField { get; } = textField;
        public string ValueField { get; } = valueField;
        public SelectorLambdaOperatorParameters TextAndValueSelector { get; } = textAndValueSelector;
        public RequestDetailsParameters RequestDetails { get; } = requestDetails;
        public string? ModelType { get; } = modelType;
    }
}
