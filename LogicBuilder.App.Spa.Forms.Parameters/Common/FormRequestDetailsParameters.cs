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
        public string GetUrl { get; } = getUrl;
        public string AddUrl { get; } = addUrl;
        public string UpdateUrl { get; } = updateUrl;
        public string DeleteUrl { get; } = deleteUrl;
        public string ModelType { get; } = modelType;
        public string DataType { get; } = dataType;
        public FilterLambdaOperatorParameters? Filter { get; } = filter;
        public SelectExpandDefinitionParameters? SelectExpandDefinition { get; } = selectExpandDefinition;
    }
}
