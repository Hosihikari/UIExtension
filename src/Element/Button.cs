namespace Hosihikari.Minecraft.Extension.UI.Element;

public class Button : ElementBase
{
    public string? Text { get; set; }
    public event Action<ServerPlayer>? Clicked;

    internal void OnClick(ServerPlayer player)
    {
        Clicked?.Invoke(player);
    }
}