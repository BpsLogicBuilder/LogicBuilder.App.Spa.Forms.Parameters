using LogicBuilder.Attributes;
using System.Collections.Generic;
using System.Linq;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class ValidatorDescriptionParameters(
        [Comments("Class name")]
            [NameValue(AttributeNames.DEFAULTVALUE, "Validators")]
            string className,

        [Comments("Function")]
            [NameValue(AttributeNames.DEFAULTVALUE, "required")]
            string functionName,

        [Comments("Where applicable, add arguments for the validator function.")]
            List<ValidatorArgumentParameters>? arguments = null
        )
    {
        public string ClassName { get; set; } = className;
        public string FunctionName { get; set; } = functionName;
        public Dictionary<string, object>? Arguments { get; set; } = arguments?.ToDictionary(kvp => kvp.Name, kvp => kvp.Value);
    }
}
