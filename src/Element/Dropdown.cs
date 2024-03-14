namespace Hosihikari.Minecraft.Extension.UI.Element;

public class Dropdown : ModalElementBase
{
    public List<string>? Options;
    public int DefaultValueIndex { get; set; }
    public string? Result { get; protected set; }

    internal override void SetResult(string value)
    {
        if (Options is null)
        {
            return;
        }

        Result = Options[Convert.ToInt32(value)];
    }
}