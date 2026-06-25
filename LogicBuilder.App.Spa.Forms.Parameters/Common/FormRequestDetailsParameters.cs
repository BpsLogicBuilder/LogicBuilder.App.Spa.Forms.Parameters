using LogicBuilder.Attributes;
using LogicBuilder.Forms.Parameters.Expansions;
using LogicBuilder.Forms.Parameters.Expressions;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
#pragma warning disable S107 //Parameters used to configure a request with several settings
    public class FormRequestDetailsParameters(
        [Comments("API end point to get the entity.")]
        [NameValue(AttributeNames.DEFAULTVALUE, "api/Entity/GetEntity")]
        string getUrl,

        [Comments("API end point to add the entity.")]
        [NameValue(AttributeNames.DEFAULTVALUE, "api/Student/Save")]
        string addUrl,

        [Comments("API end point to update the entity.")]
        [NameValue(AttributeNames.DEFAULTVALUE, "api/Student/Save")]
        string updateUrl,

        [Comments("API end point to update the entity.")]
        [NameValue(AttributeNames.DEFAULTVALUE, "api/Student/Delete")]
        string deleteUrl,

        [ParameterEditorControl(ParameterControlType.TypeAutoComplete)]
        [NameValue(AttributeNames.DEFAULTVALUE, "<myApp>.Domain.Entities.<EntityName>")]
        [Comments("The model type for the object being requested. Click the function button and use the configured GetType function.  Use the Assembly qualified type name for the type argument.")]
        string modelType,

        [ParameterEditorControl(ParameterControlType.TypeAutoComplete)]
        [NameValue(AttributeNames.DEFAULTVALUE, "<myApp>.Contoso.Data.Entities.<EntityName>")]
        [Comments("The data type for the object being requested. Click the function button and use the configured GetType function.  Use the Assembly qualified type name for the type argument.")]
        string dataType,

        [Comments("Defines the filter for the single object being edited - only applicable when the edit type is update.")]
        FilterLambdaOperatorParameters? filter = null,

        [Comments("Defines and navigation properties to include in the edit model")]
        SelectExpandDefinitionParameters? selectExpandDefinition = null
    )
#pragma warning restore S107
    {
        public string GetUrl { get; set; } = getUrl;
        public string AddUrl { get; set; } = addUrl;
        public string UpdateUrl { get; set; } = updateUrl;
        public string DeleteUrl { get; set; } = deleteUrl;
        public string ModelType { get; set; } = modelType;
        public string DataType { get; set; } = dataType;
        public FilterLambdaOperatorParameters? Filter { get; set; } = filter;
        public SelectExpandDefinitionParameters? SelectExpandDefinition { get; set; } = selectExpandDefinition;
    }
}
