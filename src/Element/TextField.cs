namespace Hosihikari.Minecraft.Extension.UI.Element;

public class TextField : ModalElementBase
{
    public string? PlaceholderText { get; set; }
    public string DefaultValue { get; set; } = string.Empty;
    public string? Result { get; protected set; }

    internal override void SetResult(string value)
    {
        Result = value;
    }
}