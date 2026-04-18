using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using PrTask.Domain.Constants;
namespace PrTask.Maui.Platforms.Android;
[Service(ForegroundServiceType = global::Android.Content.PM.ForegroundService.TypeDataSync)]
public class PersistentNotificationService : Service
{
    internal static bool IsClosing { get; set; }
    private string? ServerUrl { get; set; }
    public override IBinder? OnBind(Intent? Intent) => null;
    public override StartCommandResult OnStartCommand(Intent? Intent, StartCommandFlags Flags, int StartId)
    {
        CreateNotificationChannel();
        var UrlExtra = Intent?.GetStringExtra(MauiConstants.KestrelUrlExtra);
        if (!string.IsNullOrEmpty(UrlExtra))
        {
            ServerUrl = UrlExtra;
        }
        ShowNotification();
        return StartCommandResult.Sticky;
    }
    private void ShowNotification()
    {
        PendingIntent? ContentIntent;
        string ContentText;
        if (!string.IsNullOrEmpty(ServerUrl))
        {
            var BrowserIntent = new Intent(Intent.ActionView, global::Android.Net.Uri.Parse(ServerUrl));
            BrowserIntent.AddFlags(ActivityFlags.NewTask);
            ContentIntent = PendingIntent.GetActivity(this, 0, BrowserIntent,
                PendingIntentFlags.UpdateCurrent | PendingIntentFlags.Immutable);
            ContentText = FormatStrings.MauiServerNotificationText(ServerUrl);
        }
        else
        {
            var LaunchIntent = PendingIntent.GetActivity(this, 0,
                new Intent(this, typeof(MainActivity)).AddFlags(ActivityFlags.SingleTop),
                PendingIntentFlags.UpdateCurrent | PendingIntentFlags.Immutable);
            ContentIntent = LaunchIntent;
            ContentText = MauiConstants.NotificationServerStarting;
        }
        var CloseIntent = new Intent(MauiConstants.NotificationCloseAction)
            .SetPackage(PackageName);
        var ClosePendingIntent = PendingIntent.GetBroadcast(this, MauiConstants.CloseNotificationRequestCode,
            CloseIntent, PendingIntentFlags.UpdateCurrent | PendingIntentFlags.Immutable);
        var CloseIcon = Icon.CreateWithResource(this,
            global::Android.Resource.Drawable.IcMenuCloseClearCancel);
        var CloseAction = new Notification.Action.Builder(
            CloseIcon,
            new Java.Lang.String(MauiConstants.NotificationCloseText),
            ClosePendingIntent).Build();
        var RestartIntent = new Intent(this, typeof(PersistentNotificationService));
        var RestartPendingIntent = PendingIntent.GetService(this, MauiConstants.RestartNotificationRequestCode,
            RestartIntent, PendingIntentFlags.UpdateCurrent | PendingIntentFlags.Immutable);
        var NotificationTitle = string.IsNullOrEmpty(ServerUrl)
            ? AppConstants.AppName
            : MauiConstants.NotificationServerTitle;
        var SubText = string.IsNullOrEmpty(ServerUrl)
            ? null
            : MauiConstants.NotificationServerReady;
        var NotificationBuilder = new Notification.Builder(this, MauiConstants.NotificationChannelId)
            .SetContentTitle(NotificationTitle)
            .SetContentText(ContentText)
            .SetSmallIcon(global::Android.Resource.Drawable.IcDialogInfo)
            .SetContentIntent(ContentIntent)
            .SetOngoing(true)
            .SetDeleteIntent(RestartPendingIntent)
            .AddAction(CloseAction);
        if (SubText is not null)
        {
            NotificationBuilder.SetSubText(SubText);
        }
        var Notification = NotificationBuilder.Build();
        StartForeground(MauiConstants.ServerNotificationId, Notification,
            global::Android.Content.PM.ForegroundService.TypeDataSync);
    }
    public override void OnTaskRemoved(Intent? RootIntent)
    {
        base.OnTaskRemoved(RootIntent);
        StartForegroundService(new Intent(this, typeof(PersistentNotificationService)));
    }
    public override void OnDestroy()
    {
        base.OnDestroy();
        if (!IsClosing)
        {
            StartForegroundService(new Intent(this, typeof(PersistentNotificationService)));
        }
    }
    private void CreateNotificationChannel()
    {
        var Channel = new NotificationChannel(MauiConstants.NotificationChannelId, MauiConstants.NotificationServerTitle,
            NotificationImportance.Low)
        {
            Description = MauiConstants.NotificationChannelDescription
        };
        GetSystemService(NotificationService)?.JavaCast<NotificationManager>()?.CreateNotificationChannel(Channel);
    }
}
