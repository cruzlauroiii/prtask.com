namespace PocketPay.Companion.Services;

public sealed class LogcatReader : System.IDisposable
{
    private static readonly System.Threading.Lock LogLock = new();
    private static readonly System.Collections.Generic.List<string> CapturedLogsList = [];
    private const int MaxLogs = 500;
    private static int TotalLinesRead;

    private Java.Lang.Thread? ReaderThread;
    private volatile bool IsRunning;
    private Java.Lang.Process? LogcatProcess;

    public void Start()
    {
        IsRunning = true;
        ReaderThread = new Java.Lang.Thread(new Java.Lang.Runnable(() =>
        {
            Android.Util.Log.Info("Companion", "LogcatReader started");
            ReadLogcat();
        }));
        ReaderThread.Start();
    }

    public void Stop()
    {
        IsRunning = false;
        LogcatProcess?.Destroy();
        ReaderThread?.Interrupt();
    }

    public void Dispose()
    {
        Stop();
        ReaderThread?.Dispose();
        ReaderThread = null;
    }

    public static System.Collections.Generic.IReadOnlyList<string> Logs
    {
        get
        {
            lock (LogLock)
            {
                return [.. CapturedLogsList];
            }
        }
    }

    public static int TotalLines => TotalLinesRead;

    public static string? Token { get; private set; }

    public static string? DeviceToken { get; private set; }

    public static void ClearLogs()
    {
        lock (LogLock)
        {
            CapturedLogsList.Clear();
            Token = null;
            DeviceToken = null;
        }
    }

    private void ReadLogcat()
    {
        try
        {
            Android.Util.Log.Info("Companion", "LogcatReader starting via ProcessBuilder");

            var CmdList = new System.Collections.Generic.List<string> { "logcat", "-v", "time" };
            var Pb = new Java.Lang.ProcessBuilder((System.Collections.Generic.IList<string>)CmdList);
            Pb.RedirectErrorStream(true);
            LogcatProcess = Pb.Start();
            var Stream = LogcatProcess!.InputStream;
            var Reader = new Java.IO.BufferedReader(new Java.IO.InputStreamReader(Stream));

            Android.Util.Log.Info("Companion", "LogcatReader reading started");

            while (IsRunning)
            {
                var Line = Reader.ReadLine();
                if (Line == null)
                {
                    Android.Util.Log.Info("Companion", "LogcatReader EOF");
                    break;
                }

                System.Threading.Interlocked.Increment(ref TotalLinesRead);
                ProcessLine(Line);
            }
        }
        catch (Java.Lang.InterruptedException)
        {
            Android.Util.Log.Info("Companion", "LogcatReader interrupted");
        }
        catch (System.Exception Ex)
        {
            Android.Util.Log.Error("Companion", $"LogcatReader error: {Ex.Message}");

            Android.Util.Log.Info("Companion", "LogcatReader falling back to Runtime.exec");
            ReadLogcatFallback();
        }
    }

    private void ReadLogcatFallback()
    {
        try
        {
            var Runtime = Java.Lang.Runtime.GetRuntime();
            LogcatProcess = Runtime!.Exec(["logcat", "-v", "time"]);
            var Stream = LogcatProcess!.InputStream;
            var Reader = new Java.IO.BufferedReader(new Java.IO.InputStreamReader(Stream));

            while (IsRunning)
            {
                var Line = Reader.ReadLine();
                if (Line == null) break;
                System.Threading.Interlocked.Increment(ref TotalLinesRead);
                ProcessLine(Line);
            }
        }
        catch (System.Exception Ex)
        {
            Android.Util.Log.Error("Companion", $"LogcatReader fallback error: {Ex.Message}");
        }
    }

    private static void ProcessLine(string Line)
    {
        var IsOkHttp = Line.Contains("okhttp.OkHttpClient", System.StringComparison.Ordinal) ||
                       Line.Contains("OkHttp", System.StringComparison.Ordinal);
        var IsError = Line.Contains("E/", System.StringComparison.Ordinal);
        var IsInteresting = Line.Contains("Bearer", System.StringComparison.OrdinalIgnoreCase) ||
                            Line.Contains("psr-it.com", System.StringComparison.OrdinalIgnoreCase) ||
                            Line.Contains("authorize", System.StringComparison.OrdinalIgnoreCase) ||
                            Line.Contains("receipt", System.StringComparison.OrdinalIgnoreCase);

        if (!IsOkHttp && !IsError && !IsInteresting)
        {
            return;
        }

        lock (LogLock)
        {
            if (CapturedLogsList.Count >= MaxLogs)
            {
                CapturedLogsList.RemoveAt(0);
            }

            CapturedLogsList.Add(Line);
        }

        if (Line.Contains("Bearer eyJ", System.StringComparison.Ordinal))
        {
            var BearerIndex = Line.IndexOf("Bearer eyJ", System.StringComparison.Ordinal);
            var TokenStart = BearerIndex + 7;
            var TokenEnd = Line.Length;
            for (var I = TokenStart; I < Line.Length; I++)
            {
                var C = Line[I];
                if (C is '"' or '\'' or ' ' or ',' or '}')
                {
                    TokenEnd = I;
                    break;
                }
            }

            Token = Line[TokenStart..TokenEnd];
            Android.Util.Log.Info("Companion", $"JWT captured: {Token[..20]}...");
        }

        ExtractDeviceToken(Line);
    }

    private static void ExtractDeviceToken(string Line)
    {
        if (!Line.Contains("device/info", System.StringComparison.OrdinalIgnoreCase) &&
            !Line.Contains("deviceToken", System.StringComparison.OrdinalIgnoreCase) &&
            !Line.Contains("device_token", System.StringComparison.OrdinalIgnoreCase))
        {
            return;
        }

        var TokenKey = "deviceToken";
        var Idx = Line.IndexOf(TokenKey, System.StringComparison.OrdinalIgnoreCase);
        if (Idx < 0)
        {
            TokenKey = "device_token";
            Idx = Line.IndexOf(TokenKey, System.StringComparison.OrdinalIgnoreCase);
        }

        if (Idx < 0)
        {
            return;
        }

        var AfterKey = Idx + TokenKey.Length;
        var ValueStart = -1;
        for (var I = AfterKey; I < Line.Length; I++)
        {
            var C = Line[I];
            if (C is not (':' or '"' or ' ' or '='))
            {
                ValueStart = I;
                break;
            }
        }

        if (ValueStart < 0)
        {
            return;
        }

        var ValueEnd = Line.Length;
        for (var I = ValueStart; I < Line.Length; I++)
        {
            var C = Line[I];
            if (C is '"' or ',' or '}' or ' ')
            {
                ValueEnd = I;
                break;
            }
        }

        DeviceToken = Line[ValueStart..ValueEnd];
        Android.Util.Log.Info("Companion", $"DeviceToken captured: {DeviceToken[..System.Math.Min(20, DeviceToken.Length)]}...");
    }
}
