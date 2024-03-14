namespace Hosihikari.Minecraft.Extension.UI.Element;

public class Toggle : ModalElementBase
{
    public bool DefaultValue { get; set; }
    public bool? Result { get; protected internal set; }

    internal override void SetResult(string value)
    {
        Result = Convert.ToBoolean(value);
    }
}