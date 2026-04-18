using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using PrTask.Domain.Constants;
namespace PrTask.Maui.Platforms.Android;
[Activity(
    Theme = MauiConstants.AndroidThemeTransparent,
    NoHistory = true,
    LaunchMode = LaunchMode.SingleTop,
    Exported = true)]
public class TransparentLauncherActivity : Activity
{
    protected override void OnCreate(Bundle? SavedInstanceState)
    {
        base.OnCreate(SavedInstanceState);
        var LaunchIntent = new Intent(this, typeof(MainActivity));
        LaunchIntent.PutExtra(MauiConstants.InvisibleLaunchExtra, true);
        StartActivity(LaunchIntent);
        Finish();
    }
}
