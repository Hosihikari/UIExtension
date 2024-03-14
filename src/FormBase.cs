using Hosihikari.Minecraft.Extension.UI.Result;

namespace Hosihikari.Minecraft.Extension.UI;

public abstract class FormBase
{
    public string? Title { get; set; }
    public event Action<FormCancelationReason>? Canceled;

    internal void OnCancel(FormCancelationReason reason)
    {
        Canceled?.Invoke(reason);
    }

    public abstract void Show(ServerPlayer player);

    public TForm As<TForm>() where TForm : FormBase
    {
        return (TForm)this;
    }
}

public abstract class FormBase<TElement> : FormBase
    where TElement : ElementBase
{
    internal readonly List<TElement> Elements = [];
}