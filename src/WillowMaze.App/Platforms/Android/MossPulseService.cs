using Android.App;
using Android.Content;
using Android.Nfc.CardEmulators;
using Android.OS;
using WillowMaze.App.Services;

namespace WillowMaze.App;

[Service(
    Exported = true,
    Permission = Android.Manifest.Permission.BindNfcService,
    Name = "com.willowmaze.app.MossPulseService")]
[IntentFilter([HostNfcFService.ServiceInterface])]
[MetaData(HostNfcFService.ServiceMetaData, Resource = "@xml/willowmaze_flare_service")]
public sealed class MossPulseService : HostNfcFService
{
    public override byte[]? ProcessNfcFPacket(byte[]? commandPacket, Bundle? extras)
    {
        return HceFAppletRuntime.ProcessPacket(commandPacket, responsePacket =>
        {
            _ = Task.Run(async () =>
            {
                await Task.Delay(180).ConfigureAwait(false);
                SendResponsePacket(responsePacket);
            });
        });
    }

    public override void OnDeactivated(DeactivationReasonF reason)
    {
        HceFAppletRuntime.LogDeactivated(reason);
    }
}
