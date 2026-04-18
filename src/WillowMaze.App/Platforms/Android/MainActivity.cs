using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Nfc;
using WillowMaze.App.Services;

namespace WillowMaze.App;

[Activity(
    Theme = "@style/Maui.SplashTheme",
    MainLauncher = true,
    LaunchMode = LaunchMode.SingleTop,
    Exported = true,
    ConfigurationChanges = ConfigChanges.ScreenSize
        | ConfigChanges.Orientation
        | ConfigChanges.UiMode
        | ConfigChanges.ScreenLayout
        | ConfigChanges.SmallestScreenSize
        | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnNewIntent(Intent? intent)
    {
        if (intent?.Action is not (NfcAdapter.ActionNdefDiscovered or NfcAdapter.ActionTechDiscovered or NfcAdapter.ActionTagDiscovered))
        {
            base.OnNewIntent(intent);
            return;
        }

        var service = IPlatformApplication.Current?.Services.GetService<INfcWorkbenchService>();
        if (service is NfcWorkbenchService workbench)
        {
            if (workbench.IsPreferredService)
            {
                return;
            }

            base.OnNewIntent(intent);
            Intent = intent;
            workbench.HandleForegroundDispatchIntent(intent);
        }
    }
}
