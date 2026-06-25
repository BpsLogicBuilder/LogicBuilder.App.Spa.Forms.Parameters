using LogicBuilder.Attributes;
using LogicBuilder.Forms.Parameters.Expansions;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class GridRequestDetailsParameters(
        [ParameterEditorControl(ParameterControlType.TypeAutoComplete)]
        [NameValue(AttributeNames.DEFAULTVALUE, "<myApp>.Domain.Entities.<EntityName>")]
        [Comments("Fully qualified class name for the model type.")]
        string modelType,

        [ParameterEditorControl(ParameterControlType.TypeAutoComplete)]
        [NameValue(AttributeNames.DEFAULTVALUE, "Contoso.Data.Entities")]
        [Comments("Fully qualified class name for the data type.")]
        string dataType,

        string dataSourceUrl = "/api/Generic/GetData",

        [Comments("Defines and navigation properties to include in the edit model")]
        SelectExpandDefinitionParameters? selectExpandDefinition = null
    )
    {
        public string ModelType { get; set; } = modelType;
        public string DataType { get; set; } = dataType;
        public string DataSourceUrl { get; set; } = dataSourceUrl;
        public SelectExpandDefinitionParameters? SelectExpandDefinition { get; set; } = selectExpandDefinition;
    }
}
