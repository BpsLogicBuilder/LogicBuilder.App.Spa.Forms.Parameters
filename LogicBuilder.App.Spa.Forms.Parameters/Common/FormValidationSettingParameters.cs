using LogicBuilder.Attributes;
using System.Collections.Generic;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class FormValidationSettingParameters(
        [Comments("Default value for the form control.")]
        object? defaultValue = null,

        [Comments("Configuration for validation classes, functions (and arguments for the validator where necessary).")]
        List<ValidatorDescriptionParameters>? validators = null
    )
    {
        public object? DefaultValue { get; } = defaultValue;
        public List<ValidatorDescriptionParameters>? Validators { get; } = validators ?? [];
    }
}
