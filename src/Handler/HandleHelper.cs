using Hosihikari.Minecraft.Extension.UI.Data;

namespace Hosihikari.Minecraft.Extension.UI.Handler;

internal static class HandleHelper
{
    private static readonly Dictionary<int, FormBase> s_forms = [];

    public static void QueueForm(int id, FormBase form)
    {
        if (!s_forms.TryAdd(id, form))
        {
            throw new InvalidDataException();
        }
    }

    public static void HandleMessageForm(int id, ServerPlayer player, bool conformed)
    {
        FormBase form = s_forms[id];
        MessageFormData formData = form.As<MessageFormData>();
        (conformed switch
        {
            true => formData.Elements.Item1,
            false => formData.Elements.Item2
        }).OnClick(player);
        s_forms.Remove(id);
    }

    public static void HandleActionForm(int id, ServerPlayer player, int index)
    {
        FormBase form = s_forms[id];
        ActionFormData formData = form.As<ActionFormData>();
        formData.Elements[index].OnClick(player);
        s_forms.Remove(id);
    }

    public static void HandleModalForm(int id, ServerPlayer player, List<string> values)
    {
        FormBase form = s_forms[id];
        ModalFormData formData = form.As<ModalFormData>();
        formData.OnConform(player, values);
        s_forms.Remove(id);
    }

    public static void HandleServerSettings()
    {
        throw new NotImplementedException();
    }
}