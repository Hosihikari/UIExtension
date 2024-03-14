using Hosihikari.NativeInterop.Hook.ObjectOriented;
using Hosihikari.NativeInterop.Unmanaged;
using Hosihikari.NativeInterop.Unmanaged.STL;

namespace Hosihikari.Minecraft.Extension.UI.Handler;

public sealed class ServerSettingsResponseHook() : HookBase<ServerSettingsResponseHook.HookDelegateType>(
    "?handle@?$PacketHandlerDispatcherInstance@VServerSettingsResponsePacket@@$0A@@@UEBAXAEBVNetworkIdentifier@@AEAVNetEventCallback@@AEAV?$shared_ptr@VPacket@@@std@@@Z")
{
    public delegate void HookDelegateType(
        Reference<NetworkIdentifier> a1,
        Reference<NetEventCallback> a2,
        StdSharedPtr /*Packet*/ a3);

    protected override HookDelegateType HookDelegate => (@this, a2, a3) =>
    {
        Original(@this, a2, a3);
        // TODO: Handle form
    };
}