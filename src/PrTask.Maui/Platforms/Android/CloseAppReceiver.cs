using Android.App;
using Android.Content;
using Android.Runtime;
using PrTask.Domain.Constants;
namespace PrTask.Maui.Platforms.Android;
[BroadcastReceiver(Exported = false)]
[IntentFilter([MauiConstants.NotificationCloseAction])]
public class CloseAppReceiver : BroadcastReceiver
{
    public override void OnReceive(Context? Context, Intent? Intent)
    {
        if (Context is null)
        {
            return;
        }
        PersistentNotificationService.IsClosing = true;
        Context.StopService(new Intent(Context, typeof(PersistentNotificationService)));
        var ActivityManager = Context.GetSystemService(Activity.ActivityService)
            ?.JavaCast<ActivityManager>();
        if (ActivityManager?.AppTasks is { } Tasks)
        {
            foreach (var Task in Tasks)
            {
                Task.FinishAndRemoveTask();
            }
        }
        Java.Lang.JavaSystem.Exit(0);
    }
}
