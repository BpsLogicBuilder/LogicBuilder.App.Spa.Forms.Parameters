using LogicBuilder.Attributes;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class CommandColumnParameters(
        [Comments("Column title.")]
        string title,

        [Comments("Column width")]
        int? width
    )
    {
        public string Title { get; } = title;
        public int? Width { get; } = width;
    }
}
