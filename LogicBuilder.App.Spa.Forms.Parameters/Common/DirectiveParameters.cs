using LogicBuilder.Attributes;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class DirectiveParameters(
        [Comments("Details about the directive's function and its arguments.")]
        DirectiveDescriptionParameters directiveDescription,

        [Comments("Condition group to trigger the directive.")]
        ConditionGroupParameters conditionGroup
    )
    {
        public DirectiveDescriptionParameters DirectiveDescription { get; } = directiveDescription;
        public ConditionGroupParameters ConditionGroup { get; } = conditionGroup;
    }
}