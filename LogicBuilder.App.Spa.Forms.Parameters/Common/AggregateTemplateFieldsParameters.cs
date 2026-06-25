using LogicBuilder.Attributes;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class AggregateTemplateFieldsParameters(string label,
        [Domain("average,count,max,min,sum")]
            [ParameterEditorControl(ParameterControlType.DropDown)]
            string aggregateFunction)
    {
        public string Label { get; } = label;
        public string Function { get; } = aggregateFunction;
    }
}
