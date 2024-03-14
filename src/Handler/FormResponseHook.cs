using Hosihikari.NativeInterop.Hook.ObjectOriented;
using Hosihikari.NativeInterop.Unmanaged;

namespace Hosihikari.Minecraft.Extension.UI.Handler;

public sealed class FormResponseHook()
    : HookBase<FormResponseHook.HookDelegateType>(
        "?handle@ServerNetworkHandler@@UEAAXAEBVNetworkIdentifier@@AEBVModalFormResponsePacket@@@Z")
{
    public delegate void HookDelegateType(
        Reference<ServerNetworkHandler> @this,
        Reference<NetworkIdentifier> a2,
        Reference<ModalFormResponsePacket> a3);

    protected override HookDelegateType HookDelegate => (@this, a2, a3) =>
    {
        Original(@this, a2, a3);
        ModalFormResponsePacket response = a3.Target;
        // TODO: Handle form
    };
}