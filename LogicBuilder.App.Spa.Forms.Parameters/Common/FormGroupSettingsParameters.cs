using LogicBuilder.Attributes;
using System.Collections.Generic;
using System.Linq;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
#pragma warning disable S107 //Parameters used to configure a column with several optional settings
    public class FormGroupSettingsParameters(
        [Comments("Update modelType first. Source property name from the target object.")]
        [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
        [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, nameof(modelType))]
        string field,

        [Comments("HTML template for the form group.")]
        FormGroupTemplateParameters formGroupTemplate,

        [Comments("Configuration for each field in the form group.")]
        List<IFormItemSettingParameters> fieldSettings,

        [Comments("Input validation messages for each field.")]
        List<ValidationMessageParameters> validationMessages,

        [NameValue(AttributeNames.DEFAULTVALUE, "Title")]
        [Comments("Title for the form group.")]
        string title,

        [NameValue(AttributeNames.DEFAULTVALUE, "true")]
        bool showTitle,

        [ParameterEditorControl(ParameterControlType.ParameterSourceOnly)]
        [NameValue(AttributeNames.DEFAULTVALUE, "<myApp>.Domain.Entities.<EntityName>")]
        [Comments("Fully qualified class name for the model type.")]
        string modelType,

        [Comments("Conditional directtives for each field.")]
        List<VariableDirectivesParameters>? conditionalDirectives = null
    ) : IFormItemSettingParameters
#pragma warning restore S107
    {
        public AbstractControlType AbstractControlType => AbstractControlType.FormGroup;
        public string Field { get; set; } = field;
        public FormGroupTemplateParameters FormGroupTemplate { get; set; } = formGroupTemplate;
        public List<IFormItemSettingParameters> FieldSettings { get; set; } = fieldSettings;
        public Dictionary<string, Dictionary<string, string>> ValidationMessages { get; set; } = validationMessages.ToDictionary(kvp => kvp.Field, kvp => kvp.Methods);
        public Dictionary<string, List<DirectiveParameters>> ConditionalDirectives { get; set; } = conditionalDirectives?.Select
        (
            cd => new VariableDirectivesParameters(cd.Field.Replace('.', '_'), cd.ConditionalDirectives)
        ).ToDictionary(kvp => kvp.Field, kvp => kvp.ConditionalDirectives) ?? [];
        public string Title { get; set; } = title;
        public bool ShowTitle { get; set; } = showTitle;
        public string ModelType { get; set; } = modelType;
    }
}
