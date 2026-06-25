using LogicBuilder.Attributes;
using System.Collections.Generic;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class DetailGroupSettingsParameters(
        [Comments("Update modelType first. Source property name from the target object.")]
        [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
        [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, nameof(modelType))]
        string field,

        [Comments("Title")]
        [NameValue(AttributeNames.DEFAULTVALUE, "Title")]
        string title,

        [Comments("HTML template for the group.")]
        DetailGroupTemplateParameters groupTemplate,

        [Comments("List of fields and form groups in the form group.")]
        List<IDetailItemParameters> fieldSettings,

        [ParameterEditorControl(ParameterControlType.ParameterSourceOnly)]
        [NameValue(AttributeNames.DEFAULTVALUE, "<myApp>.Domain.Entities.<EntityName>")]
        [Comments("Fully qualified class name for the model type.")]
        string? modelType = null
    ) : IDetailItemParameters
    {
        public DetailItemType DetailType => DetailItemType.Group;
        public string Field { get; } = field;
        public string Title { get; } = title;
        public DetailGroupTemplateParameters GroupTemplate { get; } = groupTemplate;
        public List<IDetailItemParameters> FieldSettings { get; } = fieldSettings;
        public string? ModelType { get; } = modelType;
    }
}
