using LogicBuilder.Attributes;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{

#pragma warning disable S107 //Parameters used to configure a column with several optional settings
    public class ColumnSettingsParameters(
        [Comments("Update modelType first. Source property name from the target object. Use a period for nested fields i.e. foo.bar.")]
        [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
        [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, nameof(modelType))]
        string field,

        [Comments("Column title.")]
        string title,

        [Comments("text/numeric/boolean/date")]
        [Domain("text,numeric,boolean,date")]
        [ParameterEditorControl(ParameterControlType.DropDown)]
        string type,

        bool? groupable = null,
        int? width = null,
        string? format = null,

        [Domain("text,numeric,boolean,date")]
        [ParameterEditorControl(ParameterControlType.DropDown)]
        string? filter = null,

        [Comments("HTML template for the cell.")]
        CellTemplateParameters? cellTemplate = null,

        [Comments("HTML template for the cell flor list content.")]
        CellListTemplateParameters? cellListTemplate = null,

        [Comments("HTML template which can be applied when the grid's filterable type is 'row' or 'menu, row'.")]
        FilterTemplateParameters? filterRowTemplate = null,

        [Comments("HTML template which can be applied when the grid's filterable type is 'menu' or 'menu, row'.")]
        FilterTemplateParameters? filterMenuTemplate = null,

        [Comments("Group header template.")]
        AggregateTemplateParameters? groupHeaderTemplate = null,

        [Comments("Group footer template.")]
        AggregateTemplateParameters? groupFooterTemplate = null,

        [Comments("Grid footer template.")]
        AggregateTemplateParameters? gridFooterTemplate = null,

        [ParameterEditorControl(ParameterControlType.ParameterSourceOnly)]
        [NameValue(AttributeNames.DEFAULTVALUE, "<myApp>.Domain.Entities.<EntityName>")]
        [Comments("Fully qualified class name for the model type.")]
        string? modelType = null
    )
#pragma warning restore S107
    {
        public string Field { get; } = field;
        public string Title { get; } = title;
        public string Type { get; } = type;
        public bool? Groupable { get; } = groupable;
        public int? Width { get; } = width;
        public string? Format { get; } = format;
        public string? Filter { get; } = filter;
        public CellTemplateParameters? CellTemplate { get; } = cellTemplate;
        public CellListTemplateParameters? CellListTemplate { get; } = cellListTemplate;
        public FilterTemplateParameters? FilterRowTemplate { get; } = filterRowTemplate;
        public FilterTemplateParameters? FilterMenuTemplate { get; } = filterMenuTemplate;
        public AggregateTemplateParameters? GroupHeaderTemplate { get; } = groupHeaderTemplate;
        public AggregateTemplateParameters? GroupFooterTemplate { get; } = groupFooterTemplate;
        public AggregateTemplateParameters? GridFooterTemplate { get; } = gridFooterTemplate;
        public string? ModelType { get; } = modelType;
    }
}
