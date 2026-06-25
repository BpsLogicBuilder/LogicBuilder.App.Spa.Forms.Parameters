using LogicBuilder.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class ContentTemplateParameters(
        [NameValue(AttributeNames.DEFAULTVALUE, "Title")]
        [Comments("Header text for the page")]
        string title,

        [Comments("HTML template for the page markup.")]
        [NameValue(AttributeNames.DEFAULTVALUE, "(customTemplate)")]
        string templateName
    )
    {
        public string Title { get; set; } = title;
        public string TemplateName { get; set; } = templateName;
    }
}
