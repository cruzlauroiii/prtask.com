namespace WillowMaze.Wasm.Decompiled;

public class P992374d8
{
    private readonly p4f9a1811 F09d7ec30;
    private readonly p6eed9b4c F153d0edc;
    private readonly p24a07cca F234d8046;
    private bool F2c7468db;
    private bool F2d21070c;
    private readonly p24a07cca F31f035e8;
    private readonly pc2c7dd60 F4717d53e;
    private readonly pc2c7dd60 F4d7fa9b3;
    private readonly p6d310f89 F53b9e967;
    private readonly p4f9a1811 F53e688c2;
    private readonly p24a07cca F5b9bd37a;
    private readonly pc2c7dd60 F5d47e124;
    private readonly p6eed9b4c F6f0dcb64;
    private readonly p4f9a1811 F7f8687cb;
    private readonly p24a07cca F956dcaaf;
    private bool Fa30c7678;
    private bool Fa991746b;
    private readonly p6d310f89 Fae181b28;
    private readonly p4f9a1811 Fe9a3289e;
    private readonly p24a07cca Ff0e37026;
    private bool Ff7bed343;

    private void TrackFailure(IOException P0)
    {
        // call: pc2c7dd60.trackFailure$okhttp
        // call: p6eed9b4c.getConnection
        // call: p24a07cca.trackFailure
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f6f0dcb64
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f53b9e967
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f5b9bd37a
    }

    public IOException BodyComplete(long P0, bool P1, bool P2, IOException P3)
    {
        // call: p4f9a1811.requestBodyEnd
        // call: p6d310f89.messageDone$okhttp
        // call: p992374d8.trackFailure
        // call: p4f9a1811.responseBodyEnd
        // call: p4f9a1811.responseFailed
        // call: p4f9a1811.requestFailed
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f09d7ec30
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f53b9e967
        return default!;
    }

    public void Cancel()
    {
        // call: p6eed9b4c.cancel
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f6f0dcb64
    }

    public p1eb558b5 CreateRequestBody(p15c2d85f P0, bool P1)
    {
        // str: "request"
        // call: p6eed9b4c.createRequestBody
        // call: Intrinsics.checkNotNullParameter
        // call: p15c2d85f.body
        // call: p0d3cf03b.contentLength
        // call: p992374d8$p55247216.<init>
        // call: p4f9a1811.requestBodyStart
        // call: Intrinsics.checkNotNull
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f09d7ec30
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.ff7bed343
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f6f0dcb64
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f53b9e967
        // type: p992374d8$p55247216
        return default!;
    }

    public void DetachWithViolence()
    {
        // call: p6d310f89.messageDone$okhttp
        // call: p6eed9b4c.cancel
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f6f0dcb64
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f53b9e967
    }

    public void FinishRequest()
    {
        // call: p4f9a1811.requestFailed
        // call: p992374d8.trackFailure
        // call: p6eed9b4c.finishRequest
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f53b9e967
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f09d7ec30
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f6f0dcb64
    }

    public void FlushRequest()
    {
        // call: p4f9a1811.requestFailed
        // call: p992374d8.trackFailure
        // call: p6eed9b4c.flushRequest
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f09d7ec30
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f53b9e967
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f6f0dcb64
    }

    public p6d310f89 GetCall$okhttp()
    {
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f53b9e967
        return default!;
    }

    public pc2c7dd60 GetConnection$okhttp()
    {
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f4717d53e
        return default!;
    }

    public p4f9a1811 GetEventListener$okhttp()
    {
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f09d7ec30
        return default!;
    }

    public p24a07cca GetFinder$okhttp()
    {
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f5b9bd37a
        return default!;
    }

    public bool IsCoalescedConnection$okhttp()
    {
        // call: pdfadebdd.host
        // call: pc2c7dd60.route
        // call: pdd7bf230.url
        // call: p9405c3af.address
        // call: Intrinsics.areEqual
        // call: p24a07cca.getAddress$okhttp
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f4717d53e
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f5b9bd37a
        return false;
    }

    public bool IsDuplex$okhttp()
    {
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.ff7bed343
        return false;
    }

    public p3ee6e472$p21b3cb64 NewWebSocketStreams()
    {
        // call: p6eed9b4c.getConnection
        // call: pc2c7dd60.newWebSocketStreams$okhttp
        // call: p6d310f89.timeoutEarlyExit
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f53b9e967
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f6f0dcb64
        return default!;
    }

    public void NoNewExchangesOnConnection()
    {
        // call: p6eed9b4c.getConnection
        // call: pc2c7dd60.noNewExchanges$okhttp
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f6f0dcb64
    }

    public void NoRequestBody()
    {
        // call: p6d310f89.messageDone$okhttp
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f53b9e967
    }

    public p42c567ea OpenResponseBody(pd64ed3e9 P0)
    {
        // str: "response"
        // str: "c943a7e6f4aaa3e72a9211343bb7c14fade7bbd39c2a2609da07a017b1c2611f30604969217b3185"
        // call: p4f9a1811.responseFailed
        // call: Intrinsics.checkNotNullParameter
        // call: DecryptString.decryptString
        // call: pd64ed3e9.m28ab1449
        // call: p6eed9b4c.reportedContentLength
        // call: p6eed9b4c.openResponseBodySource
        // call: p992374d8$p8ab31844.<init>
        // call: p0af9afa4.m7f2db423
        // call: pb5d3c5d3.<init>
        // call: p992374d8.trackFailure
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f6f0dcb64
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f53b9e967
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f09d7ec30
        // type: p992374d8$p8ab31844
        // type: pb5d3c5d3
        return default!;
    }

    public pd64ed3e9$p2bd4a59b ReadResponseHeaders(bool P0)
    {
        // call: p4f9a1811.responseFailed
        // call: p6eed9b4c.readResponseHeaders
        // call: pd64ed3e9$p2bd4a59b.initExchange$okhttp
        // call: p992374d8.trackFailure
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f53b9e967
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f6f0dcb64
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f09d7ec30
        return default!;
    }

    public void ResponseHeadersEnd(pd64ed3e9 P0)
    {
        // str: "response"
        // call: p4f9a1811.responseHeadersEnd
        // call: Intrinsics.checkNotNullParameter
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f09d7ec30
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f53b9e967
    }

    public void ResponseHeadersStart()
    {
        // call: p4f9a1811.responseHeadersStart
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f09d7ec30
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f53b9e967
    }

    public p883d7615 Trailers()
    {
        // call: p6eed9b4c.trailers
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f6f0dcb64
        return default!;
    }

    public void WebSocketUpgradeFailed()
    {
        // call: p992374d8.bodyComplete
    }

    public void WriteRequestHeaders(p15c2d85f P0)
    {
        // str: "request"
        // call: p992374d8.trackFailure
        // call: p4f9a1811.requestFailed
        // call: Intrinsics.checkNotNullParameter
        // call: p4f9a1811.requestHeadersStart
        // call: p6eed9b4c.writeRequestHeaders
        // call: p4f9a1811.requestHeadersEnd
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f09d7ec30
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f53b9e967
        // field: p7ddcfee1.pd1efad72.p4717d53e.p992374d8.f6f0dcb64
    }

}
