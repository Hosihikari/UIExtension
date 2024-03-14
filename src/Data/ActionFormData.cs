using Hosihikari.Minecraft.Extension.UI.Element;
using System.Reflection;

namespace Hosihikari.Minecraft.Extension.UI.Data;

public class ActionFormData(dynamic value) : FormBase<Button>
{
    public string? Body { get; set; }

    public override void Show(ServerPlayer player)
    {
        PropertyInfo[] properties = value.GetType().GetProperties();
        foreach (PropertyInfo property in properties)
        {
            if (property.GetValue(value) is not Button element)
            {
                continue;
            }

            Elements.Add(element);
        }

        throw new NotImplementedException();
    }
}