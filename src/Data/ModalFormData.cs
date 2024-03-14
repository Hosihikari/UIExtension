using System.Reflection;

namespace Hosihikari.Minecraft.Extension.UI.Data;

public class ModalFormData(dynamic value) : FormBase<ModalElementBase>
{
    public event Action<ServerPlayer>? Conformed;

    internal void OnConform(ServerPlayer player, List<string> values)
    {
        if (Conformed is null)
        {
            return;
        }

        for (int i = 0; i < values.Count; i++)
        {
            Elements[i].SetResult(values[i]);
        }

        Conformed.Invoke(player);
    }

    public override void Show(ServerPlayer player)
    {
        throw new NotImplementedException();
    }

    public void ShowOnSettings(ServerPlayer player)
    {
        PropertyInfo[] properties = value.GetType().GetProperties();
        foreach (PropertyInfo property in properties)
        {
            if (property.GetValue(value) is not ModalElementBase element)
            {
                continue;
            }

            Elements.Add(element);
        }

        throw new NotImplementedException();
    }
}