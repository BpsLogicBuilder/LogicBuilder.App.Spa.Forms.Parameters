using LogicBuilder.Attributes;
using System.Collections.Generic;
using System.Linq;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class DirectiveDescriptionParameters(
        [Comments("Class name")]
        [NameValue(AttributeNames.DEFAULTVALUE, "Directives")]
        string className,

        [Comments("Function")]
        [NameValue(AttributeNames.DEFAULTVALUE, "hideIf")]
        [Domain("disableIf,hideIf,validateIf")]
        string functionName,

        [Comments("Where applicable, add arguments for the directive function.")]
        List<DirectiveArgumentParameters>? arguments = null
    )
    {
        public string ClassName { get; } = className;
        public string FunctionName { get; } = functionName;
        public Dictionary<string, object>? Arguments { get; } = arguments?.ToDictionary(kvp => kvp.Name, kvp => kvp.Value);
    }
}
