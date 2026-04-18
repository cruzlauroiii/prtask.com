namespace WillowMaze.Wasm.Decompiled;

public class P8b07625b
{
    public static int F04aca25b;
    public static int F09acfe61;
    public static string F17f463a0;
    public static long F24fe8abb;
    public static int F28a7e112;
    public static long F30afb20a;
    public static int F431f399a;
    private static p8b07625b$p910eef8c F53dc7e0b;
    public static int F6addea6b;
    public static long F8d0a02ee;
    private static p8b07625b$p910eef8c F910eef8c;
    public static string F9960b9f8;
    public static int F9a1fe52c;
    public static string Fb0ddc068;
    public static long Fb33f723a;
    private static p8b07625b$p910eef8c Fb57e25bd;
    public static int Fc25c652f;
    public static string Fd5a5e5b8;
    private static p8b07625b$p910eef8c Fdd99455a;
    public static int Fddd6aaef;
    public static string Fea8e215a;
    private bool F1ae1dd60;
    private readonly object F23e8751a;
    private readonly Func<object, object> F3128cfcd;
    private Task F3490760f;
    private readonly p8b07625b$p80e50760$1 F389b1c14;
    private readonly p8b07625b$p80e50760$1 F406a524c;
    private readonly object F5c18ef72;
    private readonly ConnectivityManager F636b1c2a;
    private readonly Func<object, object> F6852c3f9;
    private readonly Func<object, object> F6a680ccd;
    private readonly Func<object, object> F6f139320;
    private readonly p8b07625b$p80e50760$1 F80e50760;
    private readonly p8b07625b$p80e50760$1 F881ecd58;
    private readonly object F8d6b13f7;
    private bool F95db2d90;
    private readonly object F991d916b;
    private readonly p8b07625b$p80e50760$1 F9a1e31e0;
    private readonly ConnectivityManager F9fdda883;
    private readonly object Fc0fb2dc5;
    private readonly ConnectivityManager Fd96601e8;
    private readonly object Fdcd57d14;
    private Task Fde260a28;
    private readonly ConnectivityManager Fec1000a9;
    private readonly Func<object, object> Feedb8c9e;

    private void M0387eddb(bool P0)
    {
        // call: bool.valueOf
        // call: Intrinsics.areEqual
        // call: Func<object, object>.invoke
        // field: pd2a57dc1.paaabf0d3.p8b07625b.f95db2d90
        // field: pd2a57dc1.paaabf0d3.p8b07625b.f3128cfcd
    }

    private void M2ec197b2()
    {
        // str: "1bcd04cd4ef412541e09994b52517ab2f1b4c67a8e7ff4e4154623c32ab4745ccea121c5cafed6f25070f5a4f97408a9c..."
        // str: "null cannot be cast to non-null type java.net.HttpURLConnection"
        // call: p8b07625b.m0387eddb
        // call: DecryptString.decryptString
        // call: Uri.<init>
        // call: Uri.openConnection
        // call: Intrinsics.checkNotNull
        // call: HttpClient.setConnectTimeout
        // call: HttpClient.setReadTimeout
        // call: HttpClient.connect
        // call: HttpClient.getResponseCode
        // type: Uri
    }

    public static void Mb6238d9f(p8b07625b P0, bool P1)
    {
        // call: p8b07625b.m0387eddb
    }

    public static void Mc415ec7b(p8b07625b P0)
    {
        // call: p8b07625b.mfc3ab828
    }

    private void Md6783ee4()
    {
        // call: Job$DefaultImpls.cancel$default
        // field: pd2a57dc1.paaabf0d3.p8b07625b.f3490760f
    }

    public static void Me9ddd80e(p8b07625b P0)
    {
        // call: p8b07625b.md6783ee4
    }

    public static void Medaea864(p8b07625b P0)
    {
        // call: p8b07625b.m2ec197b2
    }

    private void Mfc3ab828()
    {
        // call: Task.isActive
        // call: p8b07625b$pfc3ab828$1.<init>
        // call: BuildersKt.launch$default
        // field: pd2a57dc1.paaabf0d3.p8b07625b.f3490760f
        // field: pd2a57dc1.paaabf0d3.p8b07625b.f8d6b13f7
        // type: p8b07625b$pfc3ab828$1
    }

    public void Start()
    {
        // call: p8b07625b.mfc3ab828
        // call: ConnectivityManager.registerNetworkCallback
        // call: NetworkRequest$Builder.<init>
        // call: NetworkRequest$Builder.build
        // call: NetworkRequest$Builder.addCapability
        // field: pd2a57dc1.paaabf0d3.p8b07625b.f9fdda883
        // field: pd2a57dc1.paaabf0d3.p8b07625b.f80e50760
        // type: NetworkRequest$Builder
    }

    public void Stop()
    {
        // call: CoroutineScopeKt.cancel$default
        // call: p8b07625b.md6783ee4
        // call: ConnectivityManager.unregisterNetworkCallback
        // field: pd2a57dc1.paaabf0d3.p8b07625b.f8d6b13f7
        // field: pd2a57dc1.paaabf0d3.p8b07625b.f9fdda883
        // field: pd2a57dc1.paaabf0d3.p8b07625b.f80e50760
    }

}
