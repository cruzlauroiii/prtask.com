namespace WillowMaze.Wasm.Decompiled;

public class P09a340b9 : P06050a91
{
    public static p09a340b9$p910eef8c F072d54f4;
    private static int F284a5a36;
    private static int F30c51a4c;
    public static p09a340b9$p910eef8c F55019a32;
    public static p09a340b9$p910eef8c F77ef0d6a;
    public static p09a340b9$p910eef8c F910eef8c;
    private static int Fd7eefbf6;
    private static int Ffbdbc82f;
    private readonly p1cda7fcc F2546b0c4;
    private readonly p1cda7fcc F4fad0ce9;
    private readonly p1cda7fcc F62608e08;
    private readonly p1cda7fcc F6a6ccbcd;
    private readonly p1cda7fcc F9b27c759;

    private p15c2d85f BuildRedirectRequest(pd64ed3e9 P0, string P1)
    {
        // str: "Content-Length"
        // str: "bf9d9581311756d53e56aea748ce9e22bb3509bc0f4159a22b8a1bf2c1c510bf5513cd40666763b949"
        // str: "Transfer-Encoding"
        // str: "4b331635fd347d4028bdb59e40131fe9d4f5c827ecc8606b28721e5507d87b51a293a3dc"
        // str: "b2dd92b600dbf9e3c91dcf5dd96a79460d066588e404c5452efeb70812f20676e132332d1f16b1e8"
        // str: "GET"
        // call: pd64ed3e9.request
        // call: p1cda7fcc.followRedirects
        // call: p15c2d85f.url
        // call: pf22e0b0d.redirectsToGet
        // call: p15c2d85f$p2bd4a59b.method
        // call: p1cda7fcc.followSslRedirects
        // call: DecryptString.decryptString
        // call: pdfadebdd.resolve
        // call: p15c2d85f$p2bd4a59b.url
        // call: p15c2d85f$p2bd4a59b.build
        // call: p15c2d85f$p2bd4a59b.removeHeader
        // call: p15c2d85f.newBuilder
        // call: p23e8a4b4.canReuseConnectionFor
        // call: Intrinsics.areEqual
        // call: pd64ed3e9.m28ab1449
        // call: p15c2d85f.body
        // call: pdfadebdd.scheme
        // call: pf22e0b0d.redirectsWithBody
        // call: pf22e0b0d.permitsRequestBody
        // call: pd64ed3e9.code
        // field: p7ddcfee1.pd1efad72.p80791b3a.p09a340b9.f62608e08
        // field: p7ddcfee1.pd1efad72.p80791b3a.pf22e0b0d.f76425f17
        return default!;
    }

    private p15c2d85f FollowUpRequest(pd64ed3e9 P0, p992374d8 P1)
    {
        // str: "Received HTTP_PROXY_AUTH (407) code while not using proxy"
        // call: p9405c3af.proxy
        // call: pc2c7dd60.noCoalescedConnections$okhttp
        // call: pd64ed3e9.priorResponse
        // call: p09a340b9.retryAfter
        // call: pd64ed3e9.request
        // call: Intrinsics.checkNotNull
        // call: p992374d8.getConnection$okhttp
        // call: pc2c7dd60.route
        // call: p992374d8.isCoalescedConnection$okhttp
        // call: pd64ed3e9.code
        // call: p15c2d85f.method
        // call: p1cda7fcc.authenticator
        // call: p09a340b9.buildRedirectRequest
        // call: Proxy.type
        // call: p3948d67c.authenticate
        // call: p0d3cf03b.isOneShot
        // call: p1cda7fcc.proxyAuthenticator
        // call: p15c2d85f.body
        // call: ProtocolException.<init>
        // call: p1cda7fcc.retryOnConnectionFailure
        // field: p7ddcfee1.pd1efad72.p80791b3a.p09a340b9.f62608e08
        // field: java.net.Proxy$Type.HTTP
        // type: ProtocolException
        return default!;
    }

    private bool IsRecoverable(IOException P0, bool P1)
    {
        // call: IOException.getCause
        return false;
    }

    private bool Recover(IOException P0, p6d310f89 P1, p15c2d85f P2, bool P3)
    {
        // call: p6d310f89.retryAfterFailure
        // call: p09a340b9.requestIsOneShot
        // call: p09a340b9.isRecoverable
        // call: p1cda7fcc.retryOnConnectionFailure
        // field: p7ddcfee1.pd1efad72.p80791b3a.p09a340b9.f62608e08
        return false;
    }

    private bool RequestIsOneShot(IOException P0, p15c2d85f P1)
    {
        // call: p15c2d85f.body
        // call: p0d3cf03b.isOneShot
        return false;
    }

    private int RetryAfter(pd64ed3e9 P0, int P1)
    {
        // str: "\\d+"
        // str: "valueOf(header)"
        // str: "Retry-After"
        // call: Regex.<init>
        // call: int.valueOf
        // call: pd64ed3e9.m28ab1449
        // call: System.Numerics.BigInteger.intValue
        // call: Regex.matches
        // call: Intrinsics.checkNotNullExpressionValue
        // type: Regex
        return 0;
    }

    public pd64ed3e9 Intercept(p06050a91$p53205501 P0)
    {
        // str: "Too many follow-up requests: "
        // str: "chain"
        // str: "Canceled"
        // call: p6d310f89.exitNetworkInterceptorExchange$okhttp
        // call: pf1d5187f.getCall$okhttp
        // call: int.valueOf
        // call: Intrinsics.stringPlus
        // call: ProtocolException.<init>
        // call: p09a340b9.recover
        // call: CollectionsKt.plus
        // call: p23e8a4b4.withSuppressed
        // call: p0a57af34.getLastConnectException
        // call: p0a57af34.getFirstConnectException
        // call: p15c2d85f.body
        // call: p0d3cf03b.isOneShot
        // call: pd64ed3e9.newBuilder
        // call: pd64ed3e9$p2bd4a59b.body
        // call: pd64ed3e9$p2bd4a59b.build
        // call: pd64ed3e9$p2bd4a59b.priorResponse
        // call: p6d310f89.getInterceptorScopedExchange$okhttp
        // call: p09a340b9.followUpRequest
        // call: p992374d8.isDuplex$okhttp
        // call: p6d310f89.timeoutEarlyExit
        // type: ProtocolException
        // type: IOException
        return default!;
    }

}
