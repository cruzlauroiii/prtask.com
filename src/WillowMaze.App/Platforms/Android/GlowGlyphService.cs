using Android.App;
using Android.Content;
using Android.Nfc.CardEmulators;
using Android.OS;
using WillowMaze.App.Services;

namespace WillowMaze.App;

[Service(
    Exported = true,
    Permission = Android.Manifest.Permission.BindNfcService,
    Name = "com.willowmaze.app.GlowGlyphService")]
[IntentFilter([HostApduService.ServiceInterface])]
[MetaData(HostApduService.ServiceMetaData, Resource = "@xml/willowmaze_apdu_service")]
public sealed class GlowGlyphService : HostApduService
{
    public override byte[]? ProcessCommandApdu(byte[]? commandApdu, Bundle? extras)
    {
        return HceAppletRuntime.ProcessCommandApdu(commandApdu, responseApdu =>
        {
            _ = Task.Run(async () =>
            {
                await Task.Delay(180).ConfigureAwait(false);
                SendResponseApdu(responseApdu);
            });
        });
    }

    public override void OnDeactivated(DeactivationReason reason)
    {
        HceAppletRuntime.LogDeactivated(reason);
    }

    public override void ProcessPollingFrames(IList<PollingFrame> frames)
    {
        HceAppletRuntime.LogPollingFrames(frames);
        base.ProcessPollingFrames(frames);
    }

}
