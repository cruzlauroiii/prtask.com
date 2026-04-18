using Android.App;
using Android.Runtime;
namespace PrTask.Maui.Platforms.Android;
[Application]
public class MainApplication(nint Handle, JniHandleOwnership Ownership)
    : MauiApplication(Handle, Ownership)
{
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
