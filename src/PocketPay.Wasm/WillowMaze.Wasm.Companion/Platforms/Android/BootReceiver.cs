using Android.App;
using Android.Content;
using WillowMaze.Wasm.Companion.Services;

namespace WillowMaze.Wasm.Companion.Platforms.Android;

[BroadcastReceiver(Enabled = true, Exported = true, DirectBootAware = true)]
[IntentFilter(new[] { Intent.ActionBootCompleted, Intent.ActionLockedBootCompleted })]
public class BootReceiver : BroadcastReceiver
{
    public override void OnReceive(Context? Ctx, Intent? ReceivedIntent)
    {
        if (Ctx == null) return;
        global::Android.Util.Log.Info("Companion", "Boot received — starting service");
        var ServiceIntent = new Intent(Ctx, typeof(CompanionService));
        Ctx.StartForegroundService(ServiceIntent);
    }
}
