using Android.Content;
using Android.Net;
using Android.OS;

namespace PocketPay.Companion.Services;

[Android.App.Service(
    Permission = "android.permission.BIND_VPN_SERVICE",
    Exported = false)]
[Android.App.IntentFilter(["android.net.VpnService"])]
public class TrafficInterceptor : VpnService
{
    private ParcelFileDescriptor? TunInterface;
    private Java.Lang.Thread? ReadThread;
    private volatile bool IsRunning;

    private static readonly System.Threading.Lock HeadersLock = new();
    private static readonly System.Collections.Generic.List<string> CapturedHeaders = [];
    private const int MaxHeaders = 200;

    public static System.Collections.Generic.IReadOnlyList<string> Headers
    {
        get
        {
            lock (HeadersLock)
            {
                return [.. CapturedHeaders];
            }
        }
    }

    public static void ClearHeaders()
    {
        lock (HeadersLock)
        {
            CapturedHeaders.Clear();
        }
    }

    public override StartCommandResult OnStartCommand(Intent? Intent, StartCommandFlags Flags, int StartId)
    {
        if (IsRunning) return StartCommandResult.Sticky;

        TunInterface = new Builder(this)
            .SetSession("Companion Traffic Interceptor")
            .AddAddress("10.0.0.2", 32)
            .AddRoute("0.0.0.0", 0)
            .AddDnsServer("8.8.8.8")
            .Establish();
        if (TunInterface == null)
        {
            Android.Util.Log.Error("Companion", "VPN: Failed to establish TUN interface");
            return StartCommandResult.NotSticky;
        }

        IsRunning = true;
        Android.Util.Log.Info("Companion", "VPN: Traffic interceptor started");

        ReadThread = new Java.Lang.Thread(new Java.Lang.Runnable(ReadPackets));
        ReadThread.Start();

        return StartCommandResult.Sticky;
    }

    public override void OnDestroy()
    {
        IsRunning = false;
        ReadThread?.Interrupt();
        TunInterface?.Close();
        TunInterface = null;
        Android.Util.Log.Info("Companion", "VPN: Traffic interceptor stopped");
        base.OnDestroy();
    }

    public override IBinder? OnBind(Intent? Intent) => null;

    private void ReadPackets()
    {
        var Buffer = new byte[32768];
        var Fd = TunInterface!.FileDescriptor;
        var Input = new Java.IO.FileInputStream(Fd);
        var Output = new Java.IO.FileOutputStream(Fd);

        while (IsRunning)
        {
            try
            {
                var Length = Input.Read(Buffer, 0, Buffer.Length);
                if (Length <= 0) continue;

                ExtractHttpHeaders(Buffer, Length);

                Output.Write(Buffer, 0, Length);
            }
            catch (Java.Lang.InterruptedException) { break; }
            catch (System.Exception Ex)
            {
                Android.Util.Log.Error("Companion", $"VPN read error: {Ex.Message}");
                break;
            }
        }
    }

    private static void ExtractHttpHeaders(byte[] Packet, int Length)
    {
        if (Length < 40) return;

        var Data = System.Text.Encoding.ASCII.GetString(Packet, 0, System.Math.Min(Length, 2048));

        if (!Data.Contains("x-merchant-api-key", System.StringComparison.OrdinalIgnoreCase) &&
            !Data.Contains("mobilecashier", System.StringComparison.OrdinalIgnoreCase) &&
            !Data.Contains("Authorization:", System.StringComparison.OrdinalIgnoreCase))
        {
            return;
        }

        Android.Util.Log.Info("Companion", $"VPN: Intercepted relevant traffic ({Length} bytes)");

        lock (HeadersLock)
        {
            if (CapturedHeaders.Count >= MaxHeaders)
            {
                CapturedHeaders.RemoveAt(0);
            }

            CapturedHeaders.Add(Data[..System.Math.Min(Data.Length, 1000)]);
        }
    }
}
