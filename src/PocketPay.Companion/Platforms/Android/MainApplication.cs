using Android.App;
using Android.Runtime;

namespace PocketPay.Companion.Platforms.Android;

[Application]
public class MainApplication(nint Handle, JniHandleOwnership Transfer)
    : Application(Handle, Transfer)
{
    public override void OnCreate()
    {
        base.OnCreate();
        global::Android.Util.Log.Info("Companion", "Application created");
    }
}
