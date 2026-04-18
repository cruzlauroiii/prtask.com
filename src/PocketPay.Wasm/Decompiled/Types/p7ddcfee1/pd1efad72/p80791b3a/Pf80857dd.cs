namespace WillowMaze.Wasm.Decompiled;

public class Pf80857dd : P06050a91
{
    private readonly bool F0815b072;
    private readonly bool F25528b85;
    private readonly bool F384a59fe;
    private readonly bool F578c56f2;

    public pd64ed3e9 Intercept(p06050a91$p53205501 P0)
    {
        // str: " had non-zero Content-Length: "
        // str: "close"
        // str: "100-continue"
        // str: "Connection"
        // str: "chain"
        // str: "HTTP "
        // str: "Expect"
        // call: pd64ed3e9$p2bd4a59b.body
        // call: p15c2d85f.header
        // call: Intrinsics.checkNotNull
        // call: p992374d8.flushRequest
        // call: p0d3cf03b.isDuplex
        // call: p992374d8.getConnection$okhttp
        // call: p992374d8.noRequestBody
        // call: p992374d8.createRequestBody
        // call: System.currentTimeMillis
        // call: p992374d8.writeRequestHeaders
        // call: p0d3cf03b.writeTo
        // call: pf22e0b0d.permitsRequestBody
        // call: pc2c7dd60.handshake
        // call: pd64ed3e9$p2bd4a59b.sentRequestAtMillis
        // call: pd64ed3e9$p2bd4a59b.handshake
        // call: pf1d5187f.getRequest$okhttp
        // call: p992374d8.responseHeadersStart
        // call: pf1d5187f.getExchange$okhttp
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // field: p7ddcfee1.pd1efad72.p80791b3a.pf80857dd.f578c56f2
        // field: p7ddcfee1.pd1efad72.p23e8a4b4.fafc9db28
        // type: ProtocolException
        // type: StringBuilder
        return default!;
    }

}
