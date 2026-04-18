using System.Net;
using PrTask.Domain.Constants;
namespace PrTask.Maui;
public partial class PrTaskApp : Microsoft.Maui.Controls.Application
{
    public PrTaskApp()
    {
        InitializeComponent();
    }
    protected override Window CreateWindow(IActivationState? ActivationState)
    {
        var Page = new ContentPage();
        _ = Task.Run(() => StartServerAsync());
        return new Window(Page);
    }
    private static async Task StartServerAsync()
    {
        try
        {
            var Port = GetAvailablePort();
            var Prefix = FormatStrings.HttpListenerPrefix(Port);
            var Listener = new HttpListener();
            Listener.Prefixes.Add(Prefix);
            Listener.Start();
            var Url = FormatStrings.HttpServerAddress(Port);
            Console.WriteLine(AppConstants.MauiKestrelRunningPrefix + Url);
#if ANDROID
            MainThread.BeginInvokeOnMainThread(() =>
            {
                var Context = Platform.CurrentActivity ?? Platform.AppContext;
                var Intent = new Android.Content.Intent(Context, typeof(Platforms.Android.PersistentNotificationService));
                Intent.PutExtra(MauiConstants.KestrelUrlExtra, Url);
                Context.StartForegroundService(Intent);
            });
#endif
            while (Listener.IsListening)
            {
                var Context = await Listener.GetContextAsync();
                await HandleRequestAsync(Context);
            }
        }
        catch (Exception Ex)
        {
            Console.WriteLine(FormatStrings.MauiKestrelError(Ex.Message));
        }
    }
    private static int GetAvailablePort()
    {
        var TcpListener = new System.Net.Sockets.TcpListener(IPAddress.Any, AppConstants.MauiKestrelAutoPort);
        TcpListener.Start();
        var Port = ((IPEndPoint)TcpListener.LocalEndpoint).Port;
        TcpListener.Stop();
        return Port;
    }
    private static async Task HandleRequestAsync(HttpListenerContext Context)
    {
        var RequestPath = Context.Request.Url?.AbsolutePath ?? RouteConstants.Home;
        if (RequestPath == RouteConstants.Home)
        {
            Context.Response.StatusCode = (int)HttpStatusCode.Redirect;
            Context.Response.RedirectLocation = AppConstants.MauiDefaultLocalePath;
            Context.Response.Close();
            return;
        }
        var WwwRoot = Path.Combine(FileSystem.AppDataDirectory, FingerprintConstants.WwwRootDir);
        var FilePath = Path.Combine(WwwRoot, RequestPath.TrimStart('/').Replace('/', Path.DirectorySeparatorChar));
        if (File.Exists(FilePath))
        {
            var ContentType = GetContentType(FilePath);
            Context.Response.ContentType = ContentType;
            Context.Response.StatusCode = (int)HttpStatusCode.OK;
            var FileBytes = await File.ReadAllBytesAsync(FilePath);
            Context.Response.ContentLength64 = FileBytes.Length;
            await Context.Response.OutputStream.WriteAsync(FileBytes);
        }
        else
        {
            var FallbackPath = Path.Combine(WwwRoot, AppConstants.MauiFallbackFile);
            if (File.Exists(FallbackPath))
            {
                Context.Response.ContentType = MauiConstants.ContentTypeHtml;
                Context.Response.StatusCode = (int)HttpStatusCode.OK;
                var FileBytes = await File.ReadAllBytesAsync(FallbackPath);
                Context.Response.ContentLength64 = FileBytes.Length;
                await Context.Response.OutputStream.WriteAsync(FileBytes);
            }
            else
            {
                Context.Response.StatusCode = (int)HttpStatusCode.NotFound;
            }
        }
        Context.Response.Close();
    }
    private static string GetContentType(string FilePath)
    {
        var Extension = Path.GetExtension(FilePath).ToLowerInvariant();
        return Extension switch
        {
            FingerprintConstants.HtmlExtension => MauiConstants.ContentTypeHtml,
            MauiConstants.ExtensionCss => MauiConstants.ContentTypeCss,
            MauiConstants.ExtensionJs => MauiConstants.ContentTypeJs,
            MauiConstants.ExtensionJson => AppConstants.ContentTypeJson,
            MauiConstants.ExtensionPng => MauiConstants.ContentTypePng,
            MauiConstants.ExtensionSvg => MauiConstants.ContentTypeSvg,
            MauiConstants.ExtensionWasm => MauiConstants.ContentTypeWasm,
            MauiConstants.ExtensionDat => MauiConstants.ContentTypeOctetStream,
            _ => MauiConstants.ContentTypeOctetStream,
        };
    }
}
