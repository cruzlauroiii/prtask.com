namespace WillowMaze.Wasm.Decompiled;

public class Pc650a1a9 : P4f9a1811
{
    private long F040ea72c;
    private long F0933dd6a;
    private readonly pe0f62c28$p959112ef F0c611fb4;
    private long F0fcc9f7f;
    private readonly pe0f62c28$p959112ef F6db435f3;
    private readonly pe0f62c28$p959112ef F6f901805;
    private readonly pe0f62c28$p959112ef Fa79c9429;
    private long Fb5dfeecc;
    private long Fb8f3e861;

    private void M7b13c062(string P0)
    {
        // str: " ms] "
        // str: "["
        // call: StringBuilder.append
        // call: System.nanoTime
        // call: TimeUnit.toMillis
        // call: pe0f62c28$p959112ef.log
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // field: p7ddcfee1.pad8a2265.pc650a1a9.f6db435f3
        // field: java.util.concurrent.TimeUnit.NANOSECONDS
        // field: p7ddcfee1.pad8a2265.pc650a1a9.fb8f3e861
        // type: StringBuilder
    }

    public void CacheConditionalHit(pc3755e61 P0, pd64ed3e9 P1)
    {
        // str: "cacheConditionalHit: "
        // str: "call"
        // str: "cachedResponse"
        // call: Intrinsics.checkNotNullParameter
        // call: Intrinsics.stringPlus
        // call: pc650a1a9.m7b13c062
    }

    public void CacheHit(pc3755e61 P0, pd64ed3e9 P1)
    {
        // str: "response"
        // str: "call"
        // str: "cacheHit: "
        // call: Intrinsics.checkNotNullParameter
        // call: pc650a1a9.m7b13c062
        // call: Intrinsics.stringPlus
    }

    public void CacheMiss(pc3755e61 P0)
    {
        // str: "cacheMiss"
        // str: "call"
        // call: Intrinsics.checkNotNullParameter
        // call: pc650a1a9.m7b13c062
    }

    public void CallEnd(pc3755e61 P0)
    {
        // str: "call"
        // str: "callEnd"
        // call: Intrinsics.checkNotNullParameter
        // call: pc650a1a9.m7b13c062
    }

    public void CallFailed(pc3755e61 P0, IOException P1)
    {
        // str: "call"
        // str: "ioe"
        // str: "callFailed: "
        // call: Intrinsics.stringPlus
        // call: Intrinsics.checkNotNullParameter
        // call: pc650a1a9.m7b13c062
    }

    public void CallStart(pc3755e61 P0)
    {
        // str: "call"
        // str: "callStart: "
        // call: Intrinsics.stringPlus
        // call: pc650a1a9.m7b13c062
        // call: pc3755e61.request
        // call: System.nanoTime
        // call: Intrinsics.checkNotNullParameter
        // field: p7ddcfee1.pad8a2265.pc650a1a9.fb8f3e861
    }

    public void Canceled(pc3755e61 P0)
    {
        // str: "canceled"
        // str: "call"
        // call: Intrinsics.checkNotNullParameter
        // call: pc650a1a9.m7b13c062
    }

    public void ConnectEnd(pc3755e61 P0, InetSocketAddress P1, Proxy P2, p888a77f5 P3)
    {
        // str: "proxy"
        // str: "inetSocketAddress"
        // str: "connectEnd: "
        // str: "call"
        // call: Intrinsics.checkNotNullParameter
        // call: pc650a1a9.m7b13c062
        // call: Intrinsics.stringPlus
    }

    public void ConnectFailed(pc3755e61 P0, InetSocketAddress P1, Proxy P2, p888a77f5 P3, IOException P4)
    {
        // str: "proxy"
        // str: "call"
        // str: "ioe"
        // str: "inetSocketAddress"
        // str: "connectFailed: "
        // call: pc650a1a9.m7b13c062
        // call: Intrinsics.checkNotNullParameter
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // type: StringBuilder
    }

    public void ConnectStart(pc3755e61 P0, InetSocketAddress P1, Proxy P2)
    {
        // str: "connectStart: "
        // str: "call"
        // str: "proxy"
        // str: "inetSocketAddress"
        // call: pc650a1a9.m7b13c062
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: Intrinsics.checkNotNullParameter
        // type: StringBuilder
    }

    public void ConnectionAcquired(pc3755e61 P0, pc2cc7082 P1)
    {
        // str: "connection"
        // str: "call"
        // str: "connectionAcquired: "
        // call: pc650a1a9.m7b13c062
        // call: Intrinsics.checkNotNullParameter
        // call: Intrinsics.stringPlus
    }

    public void ConnectionReleased(pc3755e61 P0, pc2cc7082 P1)
    {
        // str: "connection"
        // str: "call"
        // str: "connectionReleased"
        // call: Intrinsics.checkNotNullParameter
        // call: pc650a1a9.m7b13c062
    }

    public void DnsEnd(pc3755e61 P0, string P1, List<object> P2)
    {
        // str: "inetAddressList"
        // str: "dnsEnd: "
        // str: "domainName"
        // str: "call"
        // call: Intrinsics.stringPlus
        // call: pc650a1a9.m7b13c062
        // call: Intrinsics.checkNotNullParameter
    }

    public void DnsStart(pc3755e61 P0, string P1)
    {
        // str: "call"
        // str: "domainName"
        // str: "dnsStart: "
        // call: pc650a1a9.m7b13c062
        // call: Intrinsics.checkNotNullParameter
        // call: Intrinsics.stringPlus
    }

    public void ProxySelectEnd(pc3755e61 P0, pdfadebdd P1, List<object> P2)
    {
        // str: "proxies"
        // str: "url"
        // str: "call"
        // str: "proxySelectEnd: "
        // call: Intrinsics.checkNotNullParameter
        // call: pc650a1a9.m7b13c062
        // call: Intrinsics.stringPlus
    }

    public void ProxySelectStart(pc3755e61 P0, pdfadebdd P1)
    {
        // str: "proxySelectStart: "
        // str: "url"
        // str: "call"
        // call: pc650a1a9.m7b13c062
        // call: Intrinsics.stringPlus
        // call: Intrinsics.checkNotNullParameter
    }

    public void RequestBodyEnd(pc3755e61 P0, long P1)
    {
        // str: "call"
        // str: "requestBodyEnd: byteCount="
        // call: long.valueOf
        // call: pc650a1a9.m7b13c062
        // call: Intrinsics.stringPlus
        // call: Intrinsics.checkNotNullParameter
    }

    public void RequestBodyStart(pc3755e61 P0)
    {
        // str: "requestBodyStart"
        // str: "call"
        // call: Intrinsics.checkNotNullParameter
        // call: pc650a1a9.m7b13c062
    }

    public void RequestFailed(pc3755e61 P0, IOException P1)
    {
        // str: "call"
        // str: "requestFailed: "
        // str: "ioe"
        // call: Intrinsics.checkNotNullParameter
        // call: Intrinsics.stringPlus
        // call: pc650a1a9.m7b13c062
    }

    public void RequestHeadersEnd(pc3755e61 P0, p15c2d85f P1)
    {
        // str: "request"
        // str: "requestHeadersEnd"
        // str: "call"
        // call: Intrinsics.checkNotNullParameter
        // call: pc650a1a9.m7b13c062
    }

    public void RequestHeadersStart(pc3755e61 P0)
    {
        // str: "call"
        // str: "requestHeadersStart"
        // call: Intrinsics.checkNotNullParameter
        // call: pc650a1a9.m7b13c062
    }

    public void ResponseBodyEnd(pc3755e61 P0, long P1)
    {
        // str: "responseBodyEnd: byteCount="
        // str: "call"
        // call: Intrinsics.stringPlus
        // call: pc650a1a9.m7b13c062
        // call: Intrinsics.checkNotNullParameter
        // call: long.valueOf
    }

    public void ResponseBodyStart(pc3755e61 P0)
    {
        // str: "call"
        // str: "responseBodyStart"
        // call: pc650a1a9.m7b13c062
        // call: Intrinsics.checkNotNullParameter
    }

    public void ResponseFailed(pc3755e61 P0, IOException P1)
    {
        // str: "responseFailed: "
        // str: "ioe"
        // str: "call"
        // call: Intrinsics.checkNotNullParameter
        // call: Intrinsics.stringPlus
        // call: pc650a1a9.m7b13c062
    }

    public void ResponseHeadersEnd(pc3755e61 P0, pd64ed3e9 P1)
    {
        // str: "call"
        // str: "responseHeadersEnd: "
        // str: "response"
        // call: Intrinsics.checkNotNullParameter
        // call: Intrinsics.stringPlus
        // call: pc650a1a9.m7b13c062
    }

    public void ResponseHeadersStart(pc3755e61 P0)
    {
        // str: "call"
        // str: "responseHeadersStart"
        // call: pc650a1a9.m7b13c062
        // call: Intrinsics.checkNotNullParameter
    }

    public void SatisfactionFailure(pc3755e61 P0, pd64ed3e9 P1)
    {
        // str: "call"
        // str: "satisfactionFailure: "
        // str: "response"
        // call: Intrinsics.checkNotNullParameter
        // call: pc650a1a9.m7b13c062
        // call: Intrinsics.stringPlus
    }

    public void SecureConnectEnd(pc3755e61 P0, p7559811a P1)
    {
        // str: "call"
        // str: "secureConnectEnd: "
        // call: Intrinsics.checkNotNullParameter
        // call: Intrinsics.stringPlus
        // call: pc650a1a9.m7b13c062
    }

    public void SecureConnectStart(pc3755e61 P0)
    {
        // str: "call"
        // str: "secureConnectStart"
        // call: Intrinsics.checkNotNullParameter
        // call: pc650a1a9.m7b13c062
    }

}
