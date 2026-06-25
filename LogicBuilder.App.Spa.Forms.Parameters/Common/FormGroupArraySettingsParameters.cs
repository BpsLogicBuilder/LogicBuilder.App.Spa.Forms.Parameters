using LogicBuilder.Attributes;
using System.Collections.Generic;
using System.Linq;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
#pragma warning disable S107 //Parameters used to configure a column with several optional settings
    public class FormGroupArraySettingsParameters(
    [   Comments($"Update {nameof(arrayElementType)} first. Source property name from the target object.")]
        [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
        [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, nameof(arrayElementType))]
        string field,

        [Comments("HTML template for the form group.")]
        FormGroupTemplateParameters formGroupTemplate,

        [Comments("Configuration for each field in one of the array's form groups.")]
        List<IFormItemSettingParameters> fieldSettings,

        [Comments("Usually just a list of one item - the primary key. Additional fields apply when the primary key is a composite key.")]
        List<string> keyFields,

        [Comments("Input validation messages for each field.")]
        List<ValidationMessageParameters> validationMessages,

        [NameValue(AttributeNames.DEFAULTVALUE, "Title")]
        [Comments("Title for the form group.")]
        string title,

        [NameValue(AttributeNames.DEFAULTVALUE, "true")]
        bool showTitle,

        [ParameterEditorControl(ParameterControlType.ParameterSourceOnly)]
        [Comments("Fully qualified class name for the model type.")]
        string arrayElementType = "<myApp>.Domain.Entities.<EntityName>",

        [Comments("Conditional directtives for each field.")]
        List<VariableDirectivesParameters>? conditionalDirectives = null
    ) : IFormItemSettingParameters
#pragma warning restore S107
    {
        public AbstractControlType AbstractControlType => AbstractControlType.FormGroupArray;
        public string Field { get; } = field;
        public FormGroupTemplateParameters FormGroupTemplate { get; } = formGroupTemplate;
        public List<IFormItemSettingParameters> FieldSettings { get; } = fieldSettings;
        public Dictionary<string, Dictionary<string, string>> ValidationMessages { get; } = validationMessages.ToDictionary(kvp => kvp.Field, kvp => kvp.Methods);
        public List<string> KeyFields { get; } = keyFields;
        public Dictionary<string, List<DirectiveParameters>> ConditionalDirectives { get; } = conditionalDirectives?.Select
            (
                cd => new VariableDirectivesParameters(cd.Field.Replace('.', '_'), cd.ConditionalDirectives)
            ).ToDictionary(kvp => kvp.Field, kvp => kvp.ConditionalDirectives) ?? [];
        public string Title { get; } = title;
        public bool ShowTitle { get; } = showTitle;
        public string ArrayElementType { get; } = arrayElementType;
    }
}
