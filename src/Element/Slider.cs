namespace Hosihikari.Minecraft.Extension.UI.Element;

public class Slider : ModalElementBase
{
    public int MinimumValue { get; set; }
    public int MaximumValue { get; set; }
    public int ValueStep { get; set; }
    public int DefaultValue { get; set; }
    public int? Result { get; protected set; }

    internal override void SetResult(string value)
    {
        Result = Convert.ToInt32(value);
    }
}