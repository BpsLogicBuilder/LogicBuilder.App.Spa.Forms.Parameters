using LogicBuilder.Attributes;
using LogicBuilder.Forms.Parameters.Expressions;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class MultiSelectTemplateParameters(
        [Comments("HTML template for the drop-down.")]
        [NameValue(AttributeNames.DEFAULTVALUE, "multiSelectTemplate")]
        string templateName,

        [Comments("Place holder text.")]
        [NameValue(AttributeNames.DEFAULTVALUE, "Select One ...")]
        string placeHolderText,

        [Comments("Update modelType first. Property name for the text field. Use a period for nested fields i.e. foo.bar.")]
        [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
        [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, nameof(modelType))]
        [NameValue(AttributeNames.DEFAULTVALUE, "text")]
        string textField,

        [Comments("Update modelType first. Property name for the value field. Use a period for nested fields i.e. foo.bar.")]
        [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
        [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, nameof(modelType))]
        [NameValue(AttributeNames.DEFAULTVALUE, "value")]
        string valueField,

        [Comments("Single object used for defining the selector lambda expression e.g. q => q.OrderBy(s => s.FullName).Select(a => new InstructorModel() {ID = a.ID, FullName = a.FullName})")]
        SelectorLambdaOperatorParameters textAndValueSelector,

        [Comments("Details about the drop-down data source including joins and partial field set (selects).")]
        RequestDetailsParameters requestDetails,

        [ParameterEditorControl(ParameterControlType.ParameterSourceOnly)]
        [Comments("Fully qualified class name for the model type.")]
        string modelType = "<myApp>.Domain.Entities.<EntityName>"
    )
    {
        public string TemplateName { get; } = templateName;
        public string PlaceHolderText { get; } = placeHolderText;
        public string TextField { get; } = textField;
        public string ValueField { get; } = valueField;
        public SelectorLambdaOperatorParameters TextAndValueSelector { get; } = textAndValueSelector;
        public RequestDetailsParameters RequestDetails { get; } = requestDetails;
        public string ModelType { get; } = modelType;
    }
}
