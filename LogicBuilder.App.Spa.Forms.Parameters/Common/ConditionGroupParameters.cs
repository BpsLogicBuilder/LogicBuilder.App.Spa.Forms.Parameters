using LogicBuilder.Attributes;
using System.Collections.Generic;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class ConditionGroupParameters(
        [Domain("and,or")]
        [ParameterEditorControl(ParameterControlType.DropDown)]
        string logic,

        [Comments("List of conditions.")]
        List<ConditionParameters>? conditions = null,

        [Comments("Child condition groups.")]
        List<ConditionGroupParameters>? conditionGroups = null
    )
    {
        public string Logic { get; } = logic;
        public List<ConditionParameters>? Conditions { get; } = conditions;
        public List<ConditionGroupParameters>? ConditionGroups { get; } = conditionGroups;
    }
}