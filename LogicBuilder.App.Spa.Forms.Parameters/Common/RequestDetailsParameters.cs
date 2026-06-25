using LogicBuilder.Attributes;
using LogicBuilder.Forms.Parameters.Expansions;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class RequestDetailsParameters(
        [ParameterEditorControl(ParameterControlType.TypeAutoComplete)]
        [NameValue(AttributeNames.DEFAULTVALUE, "<myApp>.Domain.Entities.<EntityName>")]
        [Comments("The model element type for the queryable i.e. T in IQueryable<T>. Click the function button and use the configured GetType function.  Use the Assembly qualified type name for the type argument.")]
        string modelType,

        [ParameterEditorControl(ParameterControlType.TypeAutoComplete)]
        [NameValue(AttributeNames.DEFAULTVALUE, "Contoso.Data.Entities")]
        [Comments("The data element type for the queryable i.e. T in IQueryable<T>. Click the function button and use the configured GetType function.  Use the Assembly qualified type name for the type argument.")]
        string dataType,

        [ParameterEditorControl(ParameterControlType.TypeAutoComplete)]
        [NameValue(AttributeNames.DEFAULTVALUE, "Contoso.Data.Entities")]
        [Comments("The model collection type being returned e.g. IEnumerable<StudentModel>. Click the function button and use the configured GetType function.  Auto complete to System.Collections.Generic.IEnumerable`1.  Finally right-click and select 'Add/Update Generic Arguments'")]
        string modelReturnType,

        [ParameterEditorControl(ParameterControlType.TypeAutoComplete)]
        [NameValue(AttributeNames.DEFAULTVALUE, "Contoso.Data.Entities")]
        [Comments("The data collection type being returned e.g. IEnumerable<Student>. Click the function button and use the configured GetType function.  Auto complete to System.Collections.Generic.IEnumerable`1.  Finally right-click and select 'Add/Update Generic Arguments'")]
        string dataReturnType,

        string dataSourceUrl = "/api/List/GetList",

        [Comments("Defines and navigation properties to include in the edit model")]
        SelectExpandDefinitionParameters? selectExpandDefinition = null
    )
    {
        public string ModelType { get; set; } = modelType;
        public string DataType { get; set; } = dataType;
        public string ModelReturnType { get; set; } = modelReturnType;
        public string DataReturnType { get; set; } = dataReturnType;
        public string DataSourceUrl { get; set; } = dataSourceUrl;
        public SelectExpandDefinitionParameters? SelectExpandDefinition { get; set; } = selectExpandDefinition;
    }
}