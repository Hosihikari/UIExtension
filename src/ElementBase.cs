namespace Hosihikari.Minecraft.Extension.UI;

public abstract class ElementBase;

public abstract class ModalElementBase : ElementBase
{
    public string? Label { get; set; }
    internal abstract void SetResult(string value);
}