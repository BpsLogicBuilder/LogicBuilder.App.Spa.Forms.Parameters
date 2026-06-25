using LogicBuilder.Attributes;
using System.Collections.Generic;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
#pragma warning disable S107 //Parameters used to configure a control with several optional settings
    public class MultiSelectFormControlSettingsParameters(
        [Comments("Usually just a list of one item - the primary key. Additional fields apply when the primary key is a composite key.")]
        List<string> keyFields,

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

        [Comments("text/numeric/boolean/date")]
        [Domain("text,numeric,boolean,date")]
        [ParameterEditorControl(ParameterControlType.DropDown)]
        string type,

        [Comments("HTML template applicable to multi-select elements.")]
        MultiSelectTemplateParameters multiSelectTemplate,

        [Comments("Defines the field's default value, validation functions (and arguments for the validator where necessary).")]
        FormValidationSettingParameters? validationSetting = null,

        [ParameterEditorControl(ParameterControlType.ParameterSourceOnly)]
        [NameValue(AttributeNames.DEFAULTVALUE, "<myApp>.Domain.Entities.<EntityName>")]
        [Comments("Fully qualified class name for the model type.")]
        string? modelType = null
    ) : IFormItemSettingParameters
#pragma warning restore S107
    {
        public AbstractControlType AbstractControlType { get => AbstractControlType.MultiSelectFormControl; }
        public List<string> KeyFields { get; set; } = keyFields;
        public string Field { get; set; } = field;
        public string DomElementId { get; set; } = domElementId;
        public string Title { get; set; } = title;
        public string Placeholder { get; set; } = placeHolder;
        public string Type { get; set; } = type;
        public MultiSelectTemplateParameters MultiSelectTemplate { get; set; } = multiSelectTemplate;
        public FormValidationSettingParameters? ValidationSetting { get; set; } = validationSetting;
        public string? ModelType { get; set; } = modelType;
    }
}
