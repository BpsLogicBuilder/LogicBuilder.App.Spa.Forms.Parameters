using LogicBuilder.Attributes;
using LogicBuilder.Forms.Parameters.Expressions;
using System.Collections.Generic;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class ListFormSettingsParameters(
        [NameValue(AttributeNames.DEFAULTVALUE, "Title")]
        [Comments("Header field on the form")]
        string title,

        [Comments("Defines the LINQ query for retrieving the list.")]
        SelectorLambdaOperatorParameters fieldsSelector,

        [Comments("Includes the URL to retrieve the data.")]
        RequestDetailsParameters requestDetails,

        [Comments("List of fields and form groups for display.")]
        List<IDetailItemParameters> fieldSettings
    )
    {
        public string Title { get; set; } = title;
        public RequestDetailsParameters RequestDetails { get; set; } = requestDetails;
        public SelectorLambdaOperatorParameters FieldsSelector { get; set; } = fieldsSelector;
        public List<IDetailItemParameters> FieldSettings { get; set; } = fieldSettings;
    }
}
