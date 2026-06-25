using LogicBuilder.Attributes;
using System.Collections.Generic;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class DetailListSettingsParameters(
        [Comments("Update modelType first. Source property name from the target object.")]
        [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
        [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, nameof(modelType))]
        string field,

        [Comments("Title")]
        [NameValue(AttributeNames.DEFAULTVALUE, "Title")]
        string title,

        [Comments("HTML template for the list.")]
        DetailListTemplateParameters listTemplate,

        [Comments("List of fields and form groups in the list.")]
        List<IDetailItemParameters> fieldSettings,

        [ParameterEditorControl(ParameterControlType.ParameterSourceOnly)]
        [NameValue(AttributeNames.DEFAULTVALUE, "<myApp>.Domain.Entities.<EntityName>")]
        [Comments("Fully qualified class name for the model type.")]
        string? modelType = null
    ) : IDetailItemParameters
    {
        public DetailItemType DetailType => DetailItemType.List;
        public string Field { get; } = field;
        public string Title { get; } = title;
        public DetailListTemplateParameters ListTemplate { get; } = listTemplate;
        public List<IDetailItemParameters> FieldSettings { get; } = fieldSettings;
        public string? ModelType { get; } = modelType;
    }
}
