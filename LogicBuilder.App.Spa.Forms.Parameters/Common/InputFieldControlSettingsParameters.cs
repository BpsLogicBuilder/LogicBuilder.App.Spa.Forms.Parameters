using LogicBuilder.Attributes;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
#pragma warning disable S107 //Parameters used to configure a control with several optional settings
    public class InputFieldControlSettingsParameters(
            [Comments("Update modelType first. Source property name from the target object.")]
            [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
            [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, nameof(modelType))]
            string field,

            [Comments("ID attribute for the DOM element - usually (field)_id - also used on the label's for attribute.")]
            [NameValue(AttributeNames.DEFAULTVALUE, "(field)_id")]
            string domElementId,

            [Comments("Title")]
            [NameValue(AttributeNames.DEFAULTVALUE, "Title")]
            string title,

            [Comments("Place holder text.")]
            [NameValue(AttributeNames.DEFAULTVALUE, "(Title) required")]
            string placeHolder,

            [Comments("text/numeric/boolean/date/email")]
            [Domain("text,numeric,boolean,date,email")]
            [ParameterEditorControl(ParameterControlType.SingleLineTextBox)]
            string type,

            [Comments("HTML template applicable to input elements.")]
            TextFieldTemplateParameters textTemplate,

            [ParameterEditorControl(ParameterControlType.ParameterSourceOnly)]
            [NameValue(AttributeNames.DEFAULTVALUE, "<myApp>.Domain.Entities.<EntityName>")]
            [Comments("Fully qualified class name for the model type.")]
            string modelType,

            [Comments("Defines the field's default value, validation functions (and arguments for the validator where necessary).")]
            FormValidationSettingParameters? validationSetting = null
    ) : IFormItemSettingParameters
#pragma warning restore S107
    {
        public AbstractControlType AbstractControlType => AbstractControlType.InputFieldControl;
        public string Field { get; set; } = field;
        public string DomElementId { get; set; } = domElementId;
        public string Title { get; set; } = title;
        public string Placeholder { get; set; } = placeHolder;
        public string Type { get; set; } = type;
        public TextFieldTemplateParameters TextTemplate { get; set; } = textTemplate;
        public string ModelType { get; set; } = modelType;
        public FormValidationSettingParameters? ValidationSetting { get; set; } = validationSetting;
    }
}
