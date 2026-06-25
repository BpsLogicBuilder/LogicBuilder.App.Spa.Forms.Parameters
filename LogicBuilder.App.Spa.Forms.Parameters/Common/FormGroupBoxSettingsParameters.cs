using LogicBuilder.Attributes;
using System.Collections.Generic;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class FormGroupBoxSettingsParameters(
        [Comments("HTML template for the group box.")]
        FormGroupTemplateParameters formGroupTemplate,

        [Comments("Configuration for each field in the group box.")]
        List<IFormItemSettingParameters> fieldSettings,

        [NameValue(AttributeNames.DEFAULTVALUE, "Title")]
        [Comments("Title for the group box.")]
        string title,

    bool showTitle = true
    ) : IFormItemSettingParameters
    {
        public AbstractControlType AbstractControlType => AbstractControlType.GroupBox;
        public FormGroupTemplateParameters FormGroupTemplate { get; } = formGroupTemplate;
        public List<IFormItemSettingParameters> FieldSettings { get; } = fieldSettings;
        public string Title { get; } = title;
        public bool ShowTitle { get; } = showTitle;
    }
}
