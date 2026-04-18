using System.Net;
using System.Net.Sockets;
using System.Text;

namespace WillowMaze.App.Services;

internal static class ServerDiscovery
{
    private static readonly object Sync = new();
    private static bool _listening;
    private static string? _discoveredUrl;

    public static string? DiscoveredUrl
    {
        get { lock (Sync) { return _discoveredUrl; } }
    }

    public static event EventHandler? Found;

    public static void StartListening()
    {
        lock (Sync)
        {
            if (_listening) return;
            _listening = true;
        }

        _ = Task.Run(ListenLoop);
    }

    private static async Task ListenLoop()
    {
        Android.Net.Wifi.WifiManager.MulticastLock? multicastLock = null;
        try
        {
            var wifiManager = (Android.Net.Wifi.WifiManager?)Android.App.Application.Context
                .GetSystemService(Android.Content.Context.WifiService);
            if (wifiManager is not null)
            {
                multicastLock = wifiManager.CreateMulticastLock("WillowDiscovery");
                multicastLock!.Acquire();
            }

            using var udp = new UdpClient();
            udp.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            udp.Client.Bind(new IPEndPoint(IPAddress.Any, 19750));
            udp.EnableBroadcast = true;

            while (true)
            {
                var result = await udp.ReceiveAsync().ConfigureAwait(false);
                var message = Encoding.UTF8.GetString(result.Buffer);

                if (!message.StartsWith("WILLOW:"))
                {
                    continue;
                }

                var parts = message.Split(':');
                if (parts.Length != 3)
                {
                    continue;
                }

                var ip = parts[1];
                var port = parts[2];
                var url = $"wss://{ip}:{port}/ws";

                lock (Sync)
                {
                    if (_discoveredUrl == url)
                    {
                        if (TapRelayClient.IsConnected)
                            continue;
                    }

                    _discoveredUrl = url;
                }

                if (!TapRelayClient.IsConnected)
                {
                    Preferences.Default.Set("WillowServerUrl", url);
                    TapRelayClient.Configure(url);
                    Found?.Invoke(null, EventArgs.Empty);
                }
                else
                {
                    Preferences.Default.Set("WillowServerUrl", url);
                }
            }
        }
        catch
        {
        }
        finally
        {
            if (multicastLock is { IsHeld: true })
            {
                multicastLock.Release();
            }

            lock (Sync) { _listening = false; }
        }
    }
}
