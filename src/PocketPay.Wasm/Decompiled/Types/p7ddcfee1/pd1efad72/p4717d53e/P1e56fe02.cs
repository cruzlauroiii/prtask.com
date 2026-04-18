namespace WillowMaze.Wasm.Decompiled;

public class P1e56fe02
{
    public static p1e56fe02$p910eef8c F2398e576;
    public static p1e56fe02$p910eef8c F910eef8c;
    public static p1e56fe02$p910eef8c Faf7d8127;
    public static p1e56fe02$p910eef8c Fc0b7420e;
    private readonly p4f9a1811 F09d7ec30;
    private readonly pc3755e61 F12990081;
    private List<object> F13b39dfe;
    private readonly pe81f325d F171c83c1;
    private readonly List<object> F1a577bab;
    private readonly List<object> F21b1e336;
    private readonly pc3755e61 F29b07b22;
    private readonly pdd7bf230 F39c34bcd;
    private List<object> F408fafd4;
    private int F4d70e4a7;
    private readonly pc3755e61 F53b9e967;
    private readonly p4f9a1811 F5726f6ff;
    private List<object> F77fc4304;
    private readonly pdd7bf230 F884d9804;
    private int F889b99f7;
    private readonly List<object> F9623782d;
    private List<object> Fa49db5c7;
    private readonly p4f9a1811 Fa97c64ef;
    private List<object> Fac59ed2b;
    private int Fbcf076ba;
    private readonly List<object> Fcbfe8a37;
    private readonly List<object> Fd19e2094;
    private List<object> Fdc7a1ac1;
    private int Fdda1ec24;
    private List<object> Fe2a6fe7f;
    private readonly pc3755e61 Fe709f2ca;
    private readonly pe81f325d Ff6fa509c;

    private bool HasNextProxy()
    {
        // call: List<object>.size
        // field: p7ddcfee1.pd1efad72.p4717d53e.p1e56fe02.fe2a6fe7f
        // field: p7ddcfee1.pd1efad72.p4717d53e.p1e56fe02.fbcf076ba
        return false;
    }

    private Proxy NextProxy()
    {
        // str: "; exhausted proxy configurations: "
        // str: "No route to "
        // call: p1e56fe02.resetNextInetSocketAddress
        // call: StringBuilder.append
        // call: p1e56fe02.hasNextProxy
        // call: StringBuilder.<init>
        // call: pdd7bf230.url
        // call: StringBuilder.toString
        // call: pdfadebdd.host
        // call: SocketException.<init>
        // call: List<object>.get
        // field: p7ddcfee1.pd1efad72.p4717d53e.p1e56fe02.f884d9804
        // field: p7ddcfee1.pd1efad72.p4717d53e.p1e56fe02.fe2a6fe7f
        // field: p7ddcfee1.pd1efad72.p4717d53e.p1e56fe02.fbcf076ba
        // type: SocketException
        // type: StringBuilder
        return default!;
    }

    private void ResetNextInetSocketAddress(Proxy P0)
    {
        // str: "No route to "
        // str: "proxyAddress"
        // str: " returned no addresses for "
        // str: "Proxy.address() is not an InetSocketAddress: "
        // str: "; port is out of range"
        // call: StringBuilder.append
        // call: p4f9a1811.dnsEnd
        // call: Intrinsics.stringPlus
        // call: Proxy.address
        // call: InetSocketAddress.<init>
        // call: SocketException.<init>
        // call: pdd7bf230.dns
        // call: p4f9a1811.dnsStart
        // call: object.toString
        // call: pdd7bf230.url
        // call: Proxy.type
        // call: pdfadebdd.host
        // call: ICollection<object>.add
        // call: List<object>.iterator
        // call: IEnumerator<object>.hasNext
        // call: pdfadebdd.port
        // call: InetSocketAddress.createUnresolved
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.<init>
        // call: p1e56fe02$p910eef8c.getSocketHost
        // field: java.net.Proxy$Type.SOCKS
        // field: p7ddcfee1.pd1efad72.p4717d53e.p1e56fe02.f09d7ec30
        // field: p7ddcfee1.pd1efad72.p4717d53e.p1e56fe02.f53b9e967
        // field: p7ddcfee1.pd1efad72.p4717d53e.p1e56fe02.f884d9804
        // field: p7ddcfee1.pd1efad72.p4717d53e.p1e56fe02.f910eef8c
        // field: p7ddcfee1.pd1efad72.p4717d53e.p1e56fe02.fac59ed2b
        // field: java.net.Proxy$Type.DIRECT
        // type: IllegalArgumentException
        // type: SocketException
        // type: List<object>
        // type: UnknownHostException
        // type: InetSocketAddress
        // type: StringBuilder
    }

    private void ResetNextProxy(pdfadebdd P0, Proxy P1)
    {
        // call: p4f9a1811.proxySelectEnd
        // call: p1e56fe02.resetNextProxy$selectProxies
        // call: p4f9a1811.proxySelectStart
        // field: p7ddcfee1.pd1efad72.p4717d53e.p1e56fe02.f53b9e967
        // field: p7ddcfee1.pd1efad72.p4717d53e.p1e56fe02.fbcf076ba
        // field: p7ddcfee1.pd1efad72.p4717d53e.p1e56fe02.fe2a6fe7f
        // field: p7ddcfee1.pd1efad72.p4717d53e.p1e56fe02.f09d7ec30
    }

    private static List<object> ResetNextProxy$selectProxies(Proxy P0, pdfadebdd P1, p1e56fe02 P2)
    {
        // str: "proxiesOrNull"
        // call: pdfadebdd.uri
        // call: pdd7bf230.proxySelector
        // call: p23e8a4b4.immutableListOf
        // call: Intrinsics.checkNotNullExpressionValue
        // call: ICollection<object>.isEmpty
        // call: Uri.getHost
        // call: ProxySelector.select
        // call: p23e8a4b4.toImmutableList
        // call: CollectionsKt.listOf
        // field: p7ddcfee1.pd1efad72.p4717d53e.p1e56fe02.f884d9804
        // field: java.net.Proxy.NO_PROXY
        return default!;
    }

    public bool HasNext()
    {
        // call: ICollection<object>.isEmpty
        // call: p1e56fe02.hasNextProxy
        // field: p7ddcfee1.pd1efad72.p4717d53e.p1e56fe02.f1a577bab
        return false;
    }

    public p1e56fe02$p6ff9dd0d Next()
    {
        // call: ICollection<object>.isEmpty
        // call: IEnumerator<object>.next
        // call: p9405c3af.<init>
        // call: List<object>.iterator
        // call: CollectionsKt.addAll
        // call: List<object>.isEmpty
        // call: List<object>.clear
        // call: pe81f325d.shouldPostpone
        // call: NoSuchElementException.<init>
        // call: p1e56fe02.nextProxy
        // call: p1e56fe02.hasNext
        // call: ICollection<object>.add
        // call: List<object>.<init>
        // call: p1e56fe02.hasNextProxy
        // call: IEnumerator<object>.hasNext
        // call: p1e56fe02$p6ff9dd0d.<init>
        // field: p7ddcfee1.pd1efad72.p4717d53e.p1e56fe02.f1a577bab
        // field: p7ddcfee1.pd1efad72.p4717d53e.p1e56fe02.f884d9804
        // field: p7ddcfee1.pd1efad72.p4717d53e.p1e56fe02.fac59ed2b
        // field: p7ddcfee1.pd1efad72.p4717d53e.p1e56fe02.ff6fa509c
        // type: p9405c3af
        // type: List<object>
        // type: NoSuchElementException
        // type: p1e56fe02$p6ff9dd0d
        return default!;
    }

}
