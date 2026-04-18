namespace PocketPay.Companion.Services;

public sealed class NetworkDiscovery : System.IDisposable
{
    private Java.Lang.Thread? BroadcastThread;
    private volatile bool IsRunning;
    private Java.Net.DatagramSocket? Socket;

    public void Start()
    {
        IsRunning = true;
        BroadcastThread = new Java.Lang.Thread(new Java.Lang.Runnable(() =>
        {
            Android.Util.Log.Info("Companion", "NetworkDiscovery started");
            RunBroadcast();
        }));
        BroadcastThread.Start();
    }

    public void Stop()
    {
        IsRunning = false;
        Socket?.Close();
        BroadcastThread?.Interrupt();
    }

    public void Dispose()
    {
        Stop();
        BroadcastThread?.Dispose();
        BroadcastThread = null;
        Socket?.Dispose();
        Socket = null;
    }

    private void RunBroadcast()
    {
        try
        {
            Socket = new Java.Net.DatagramSocket { Broadcast = true };

            var Message = System.Text.Encoding.UTF8.GetBytes("{\"Service\":\"TranspilerCompanion\",\"Port\":8769}");
            var BroadcastAddress = Java.Net.InetAddress.GetByName("255.255.255.255");

            while (IsRunning)
            {
                try
                {
                    var Packet = new Java.Net.DatagramPacket(
                        Message, Message.Length, BroadcastAddress, 8770);
                    Socket.Send(Packet);
                    Java.Lang.Thread.Sleep(5000);
                }
                catch (Java.Lang.InterruptedException)
                {
                    break;
                }
                catch (System.Exception Ex)
                {
                    Android.Util.Log.Error("Companion", $"Broadcast error: {Ex.Message}");
                    Java.Lang.Thread.Sleep(10000);
                }
            }
        }
        catch (System.Exception Ex)
        {
            Android.Util.Log.Error("Companion", $"NetworkDiscovery error: {Ex.Message}");
        }
    }
}
