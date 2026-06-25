using LogicBuilder.Attributes;
using System.Collections.Generic;
using System.Linq;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class EditFormSettingsParameters(
        [NameValue(AttributeNames.DEFAULTVALUE, "Title")]
        [Comments("Header field on the form")]
        string title,

        [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
        [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, nameof(modelType))]
        [Comments("Update modelType first. This field is displayed next to the title - empty on Create.")]
        string displayField,

        [Comments("Includes the URL's for create, read, update and delete.")]
        FormRequestDetailsParameters requestDetails,

        [Comments("Input validation messages for each field.")]
        List<ValidationMessageParameters> validationMessages,

        [Comments("List of fields and form groups for this form.")]
        List<IFormItemSettingParameters> fieldSettings,

        [Comments("Conditional directtives for each field.")]
        List<VariableDirectivesParameters>? conditionalDirectives = null,

        [ParameterEditorControl(ParameterControlType.ParameterSourceOnly)]
        [Comments("Assembly qualified class name for the model type.")]
        string modelType = "Contoso.Domain.Entities.XXXX , Contoso.Domain, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
    )
    {
        public string Title { get; } = title;
        public string DisplayField { get; } = displayField;
        public FormRequestDetailsParameters RequestDetails { get; } = requestDetails;
        public Dictionary<string, Dictionary<string, string>> ValidationMessages { get; } = validationMessages.ToDictionary(kvp => kvp.Field, kvp => kvp.Methods);
        public List<IFormItemSettingParameters> FieldSettings { get; } = fieldSettings;
        public Dictionary<string, List<DirectiveParameters>> ConditionalDirectives { get; } = conditionalDirectives?.Select
            (
                cd => new VariableDirectivesParameters(cd.Field.Replace('.', '_'), cd.ConditionalDirectives)
            ).ToDictionary(kvp => kvp.Field, kvp => kvp.ConditionalDirectives) ?? [];
        public string ModelType { get; } = modelType;
    }
}
