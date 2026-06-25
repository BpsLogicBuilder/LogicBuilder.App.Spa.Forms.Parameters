using LogicBuilder.Attributes;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class DetailFieldSettingParameters(
        [Comments("Update modelType first. Source property name from the target object.")]
        [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
        [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, nameof(modelType))]
        string field,

        [Comments("Title")]
        [NameValue(AttributeNames.DEFAULTVALUE, "Title")]
        string title,

        [Comments("text/numeric/boolean/date")]
        [Domain("text,numeric,boolean,date")]
        [ParameterEditorControl(ParameterControlType.DropDown)]
        string type,

        [ParameterEditorControl(ParameterControlType.ParameterSourceOnly)]
        [NameValue(AttributeNames.DEFAULTVALUE, "<myApp>.Domain.Entities.<EntityName>")]
        [Comments("Fully qualified class name for the model type.")]
        string modelType,

        [Comments("HTML template for the field.")]
        DetailFieldTemplateParameters? fieldTemplate = null,

        [Comments("HTML template for the field.")]
        DetailDropDownTemplateParameters? valueTextTemplate = null
    ) : IDetailItemParameters
    {
        public DetailItemType DetailType => DetailItemType.Field;
        public string Field { get; set; } = field;
        public string Title { get; set; } = title;
        public string Type { get; set; } = type;
        public string ModelType { get; set; } = modelType;
        public DetailFieldTemplateParameters? FieldTemplate { get; set; } = fieldTemplate;
        public DetailDropDownTemplateParameters? ValueTextTemplate { get; set; } = valueTextTemplate;
    }
}
