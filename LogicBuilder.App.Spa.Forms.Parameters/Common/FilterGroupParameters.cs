using LogicBuilder.Attributes;
using System.Collections.Generic;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class FilterGroupParameters(
        [Domain("and,or")]
        [ParameterEditorControl(ParameterControlType.DropDown)]
        [Comments("and,or")]
        string logic,
        List<FilterDefinitionParameters>? filters = null,
        List<FilterGroupParameters>? filterGroups = null
    )
    {
        public string Logic { get; set; } = logic;
        public List<FilterDefinitionParameters>? Filters { get; set; } = filters;
        public List<FilterGroupParameters>? FilterGroups { get; set; } = filterGroups;
    }
}