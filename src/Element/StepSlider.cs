namespace Hosihikari.Minecraft.Extension.UI.Element;

public class StepSlider : ModalElementBase
{
    public List<string>? Steps;
    public int DefaultValueIndex { get; set; }
    public string? Result { get; protected set; }

    internal override void SetResult(string value)
    {
        if (Steps is null)
        {
            return;
        }

        Result = Steps[Convert.ToInt32(value)];
    }
}