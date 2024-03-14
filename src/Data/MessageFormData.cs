using Hosihikari.Minecraft.Extension.UI.Element;

namespace Hosihikari.Minecraft.Extension.UI.Data;

public class MessageFormData : FormBase
{
    public string? Body { get; set; }
    public (Button, Button) Elements { get; set; }

    public override void Show(ServerPlayer player)
    {
        ArgumentNullException.ThrowIfNull(Elements.Item1);
        ArgumentNullException.ThrowIfNull(Elements.Item2);
        throw new NotImplementedException();
    }
}