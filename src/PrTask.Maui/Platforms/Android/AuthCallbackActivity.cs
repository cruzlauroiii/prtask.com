using Android.App;
using Android.Content.PM;
namespace PrTask.Maui.Platforms.Android;
[Activity(NoHistory = true, LaunchMode = LaunchMode.SingleTop, Exported = true)]
[IntentFilter(
    [global::Android.Content.Intent.ActionView],
    Categories = [global::Android.Content.Intent.CategoryDefault, global::Android.Content.Intent.CategoryBrowsable],
    DataScheme = "com.prtask.app",
    DataHost = "auth")]
public class AuthCallbackActivity : WebAuthenticatorCallbackActivity;
