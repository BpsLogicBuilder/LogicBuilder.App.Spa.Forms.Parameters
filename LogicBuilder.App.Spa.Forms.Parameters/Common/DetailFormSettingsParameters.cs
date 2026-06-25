using LogicBuilder.Attributes;
using System.Collections.Generic;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class DetailFormSettingsParameters(
        [NameValue(AttributeNames.DEFAULTVALUE, "Title")]
        [Comments("Header field on the form")]
        string title,

        [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
        [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, nameof(modelType))]
        [Comments("Update modelType first. This field is displayed next to the title.")]
        string displayField,

        [Comments("Includes the URL to retrieve the data.")]
        FormRequestDetailsParameters requestDetails,

        [Comments("List of fields and form groups for display.")]
        List<IDetailItemParameters> fieldSettings,

        [ParameterEditorControl(ParameterControlType.ParameterSourceOnly)]
        [Comments("Fully qualified class name for the model type.")]
        string? modelType = "<myApp>.Domain.Entities.<EntityName>"
    )
    {
        public string Title { get; set; } = title;
        public string DisplayField { get; set; } = displayField;
        public FormRequestDetailsParameters RequestDetails { get; set; } = requestDetails;
        public List<IDetailItemParameters> FieldSettings { get; set; } = fieldSettings;
        public string? ModelType { get; set; } = modelType;
    }
}
