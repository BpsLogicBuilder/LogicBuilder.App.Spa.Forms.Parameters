using System.Collections.Generic;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class AggregateTemplateParameters(string templateName, List<AggregateTemplateFieldsParameters> aggregates)
    {
        public string TemplateName { get; set; } = templateName;
        public List<AggregateTemplateFieldsParameters> Aggregates { get; set; } = aggregates;
    }
}
