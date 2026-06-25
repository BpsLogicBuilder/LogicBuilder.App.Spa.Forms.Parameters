using LogicBuilder.Attributes;
using System.Collections.Generic;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
#pragma warning disable S107 //Parameters used to configure a grid with several optional settings
    public class GridSettingsParameters(
        [Comments("Grid Title.")]
        string title,

        [Comments("True if the grid is sortable otherwise false")]
        [Domain("true,false")]
        [ParameterEditorControl(ParameterControlType.DropDown)]
        bool sortable,

        [Comments("True if the grid is pageable otherwise false")]
        [Domain("true,false")]
        [ParameterEditorControl(ParameterControlType.DropDown)]
        bool pageable,

        [Comments("'scrollable' if the grid is scrollable otherwise empty string.")]
        [Domain("scrollable")]
        string scrollable,

        [Comments("True if the grid is groupable otherwise false")]
        [Domain("true,false")]
        [ParameterEditorControl(ParameterControlType.DropDown)]
        bool groupable,

        [Comments("True if the grid is filterpable otherwise false.  The filterableType field takes precedence.")]
        [Domain("true,false")]
        [ParameterEditorControl(ParameterControlType.DropDown)]
        bool isFilterable,

        [Comments("Defines the type of filter for the grid.  Use menu, row for both filter types.  When a filter type has been set, the grid will be filterable regardless of the isFilterable property.")]
        [Domain("row,menu,\"menu, row\"")]
        string filterableType,

        [Comments("URL and other meta data for the data request.")]
        GridRequestDetailsParameters requestDetails,

        [Comments("Column definitions.")]
        List<ColumnSettingsParameters> columns,

        [Comments("The grid ID helps determine if a command button should be assigned to the grid's command column.")]
        int? gridId = null,

        [Comments("Gives the grid a fixed height when set.")]
        int? height = null,

        [Comments("Details about the command (Edit, Detail, Delete) column.")]
        CommandColumnParameters? commandColumn = null,

        [Comments("Defines the state of the grid including the sort, filter, page and page size.")]
        DataRequestStateParameters? state = null,

        [Comments("List of fields and correspondong aggregate functions if set.")]
        List<AggregateDefinitionParameters>? aggregates = null,

        [Comments("Detail grid if set.")]
        GridSettingsParameters? detailGridSettings = null
    )
#pragma warning restore S107
    {
        public string Title { get; } = title;
        public bool Sortable { get; } = sortable;
        public bool Pageable { get; } = pageable;
        public string Scrollable { get; } = scrollable;
        public bool Groupable { get; } = groupable;
        public bool IsFilterable { get; } = isFilterable;
        public string FilterableType { get; } = filterableType;
        public dynamic Filterable => string.IsNullOrEmpty(FilterableType)
                                        ? (object)IsFilterable
                                        : FilterableType;
        public List<ColumnSettingsParameters> Columns { get; } = columns;
        public int? GridId { get; } = gridId;
        public int? Height { get; } = height;
        public CommandColumnParameters? CommandColumn { get; } = commandColumn;
        public DataRequestStateParameters? State { get; } = state;
        public List<AggregateDefinitionParameters>? Aggregates { get; } = aggregates;
        public GridRequestDetailsParameters? RequestDetails { get; } = requestDetails;
        public GridSettingsParameters? DetailGridSettings { get; } = detailGridSettings;
    }
}
