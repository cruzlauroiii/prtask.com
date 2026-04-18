using Android.App;
using Android.Content;
using Android.OS;
using PocketPay.Companion.Services;

namespace PocketPay.Companion.Platforms.Android;

[Activity(
    MainLauncher = true,
    Theme = "@android:style/Theme.Translucent.NoTitleBar",
    Exported = true)]
public class MainActivity : Activity
{
    protected override void OnCreate(Bundle? SavedInstanceState)
    {
        base.OnCreate(SavedInstanceState);
        global::Android.Util.Log.Info("Companion", "MainActivity starting service");

        var ServiceIntent = new Intent(this, typeof(CompanionService));
        StartForegroundService(ServiceIntent);

        FinishAndRemoveTask();
    }
}
