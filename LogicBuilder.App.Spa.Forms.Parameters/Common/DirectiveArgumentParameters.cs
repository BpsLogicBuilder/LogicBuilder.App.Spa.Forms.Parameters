using LogicBuilder.Attributes;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class DirectiveArgumentParameters(
        [Comments("The argument's name.")]
        [NameValue(AttributeNames.USEFOREQUALITY, "true")]
        [NameValue(AttributeNames.USEFORHASHCODE, "true")]
        string name,

        [Comments("The argument's value.")]
        [NameValue(AttributeNames.USEFOREQUALITY, "false")]
        [NameValue(AttributeNames.USEFORHASHCODE, "false")]
        object value
    )
    {
        public string Name { get; set; } = name;
        public object Value { get; set; } = value;
    }
}
