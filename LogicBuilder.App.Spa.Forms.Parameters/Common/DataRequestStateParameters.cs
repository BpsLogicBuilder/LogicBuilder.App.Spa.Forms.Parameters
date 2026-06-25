using LogicBuilder.Attributes;
using System.Collections.Generic;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class DataRequestStateParameters(
        [Comments("Number of records to skip.")]
        int? skip = null,

        [Comments("Page size.")]
        int? take = null,

        [Comments("Sort descriptor.")]
        List<SortParameters>? sort = null,

        [Comments("Group by.")]
        List<GroupParameters>? group = null,

        [Comments("Filter descriptors.")]
        FilterGroupParameters? filterGroup = null,

        [Comments("Aggregate functions.")]
        List<AggregateDefinitionParameters>? aggregates = null
    )
    {
        public int? Skip { get; set; } = skip;
        public int? Take { get; set; } = take;
        public List<SortParameters>? Sort { get; set; } = sort;
        public List<GroupParameters>? Group { get; set; } = group;
        public FilterGroupParameters? FilterGroup { get; set; } = filterGroup;
        public List<AggregateDefinitionParameters>? Aggregates { get; set; } = aggregates;
    }
}