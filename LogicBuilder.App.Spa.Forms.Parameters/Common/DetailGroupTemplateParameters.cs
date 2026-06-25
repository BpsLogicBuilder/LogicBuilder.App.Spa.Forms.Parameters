using LogicBuilder.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class DetailGroupTemplateParameters(
        [Comments("HTML template for the group.")]
            [NameValue(AttributeNames.DEFAULTVALUE, "groupTemplate")]
            string templateName
        )
    {
        public string TemplateName { get; set; } = templateName;
    }
}
