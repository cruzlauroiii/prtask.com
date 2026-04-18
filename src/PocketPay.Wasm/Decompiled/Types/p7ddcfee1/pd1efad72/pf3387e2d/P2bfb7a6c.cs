namespace WillowMaze.Wasm.Decompiled;

public class P2bfb7a6c : P6eed9b4c
{
    private static int F05d66ccc;
    private static long F110661a3;
    private static int F23ece665;
    private static int F26f978f9;
    private static long F32724c1c;
    public static p2bfb7a6c$p910eef8c F339cc5c4;
    private static int F3e85c0d5;
    private static long F41587490;
    private static long F41ceaf00;
    private static int F44ffe7b9;
    private static int F4f38a987;
    private static int F5416ac5e;
    private static int F667adf17;
    private static int F6742005d;
    public static p2bfb7a6c$p910eef8c F6c909cba;
    private static int F73df325b;
    private static int F7bdb595e;
    private static int F825fd21a;
    private static int F8bd0783c;
    public static p2bfb7a6c$p910eef8c F910eef8c;
    private static int F9e2dc8e7;
    private static int Fa139f00d;
    private static int Fa4776868;
    private static int Fa5618369;
    private static int Fada59558;
    private static int Fc92f5e52;
    private static int Fcb7bfab2;
    private static int Fcc8ba64f;
    private static int Fe49c4575;
    public static p2bfb7a6c$p910eef8c Fe4ed6df7;
    private static int Fed91e7e8;
    private static int Ffecf756e;
    private int F2239b52f;
    private readonly pc2c7dd60 F267e3277;
    private readonly pcc81e3f6 F36cd38f4;
    private readonly p1cda7fcc F3a841b3b;
    private readonly pc2c7dd60 F4717d53e;
    private readonly p1cda7fcc F62608e08;
    private readonly p08d84bc6 F6a025688;
    private readonly p08d84bc6 F6c4a4086;
    private readonly pc2c7dd60 F6f3764af;
    private readonly pcc81e3f6 F73bd245f;
    private readonly pc2c7dd60 F8872ce97;
    private readonly p1cda7fcc F9a68780f;
    private int F9ed39e2e;
    private readonly pa559d6f1 Fa490a159;
    private readonly p1cda7fcc Fa4cb47a1;
    private readonly p1cda7fcc Fb41c8f25;
    private p883d7615 Fbb864789;
    private readonly pa559d6f1 Fbd9ba537;
    private p883d7615 Fc714a1bc;
    private readonly p08d84bc6 Fdc589128;
    private readonly pa559d6f1 Fe27d5ffe;
    private readonly p08d84bc6 Ff6e04117;
    private p883d7615 Ffbfe9809;
    private readonly pa559d6f1 Ffef7aef9;

    public static void Access$detachTimeout(p2bfb7a6c P0, p911250bb P1)
    {
        // call: p2bfb7a6c.detachTimeout
    }

    public static p1cda7fcc Access$getClient$p(p2bfb7a6c P0)
    {
        // field: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.f62608e08
        return default!;
    }

    public static pa559d6f1 Access$getHeadersReader$p(p2bfb7a6c P0)
    {
        // field: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.ffef7aef9
        return default!;
    }

    public static p08d84bc6 Access$getSink$p(p2bfb7a6c P0)
    {
        // field: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.ff6e04117
        return default!;
    }

    public static pcc81e3f6 Access$getSource$p(p2bfb7a6c P0)
    {
        // field: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.f36cd38f4
        return default!;
    }

    public static int Access$getState$p(p2bfb7a6c P0)
    {
        // field: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.f9ed39e2e
        return 0;
    }

    public static p883d7615 Access$getTrailers$p(p2bfb7a6c P0)
    {
        // field: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.ffbfe9809
        return default!;
    }

    public static void Access$setState$p(p2bfb7a6c P0, int P1)
    {
        // field: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.f9ed39e2e
    }

    public static void Access$setTrailers$p(p2bfb7a6c P0, p883d7615 P1)
    {
        // field: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.ffbfe9809
    }

    private void DetachTimeout(p911250bb P0)
    {
        // call: pc85a251c.clearTimeout
        // call: p911250bb.setDelegate
        // call: pc85a251c.clearDeadline
        // call: p911250bb.delegate
        // field: p38cb8f46.pc85a251c.fb50339a1
    }

    private bool IsChunked(p15c2d85f P0)
    {
        // str: "chunked"
        // str: "Transfer-Encoding"
        // call: p15c2d85f.header
        // call: StringsKt.equals
        return false;
    }

    private bool IsChunked(pd64ed3e9 P0)
    {
        // str: "chunked"
        // str: "Transfer-Encoding"
        // call: pd64ed3e9.m28ab1449
        // call: StringsKt.equals
        return false;
    }

    private p1eb558b5 NewChunkedSink()
    {
        // str: "state: "
        // call: object.toString
        // call: int.valueOf
        // call: p2bfb7a6c$pcb5f53af.<init>
        // call: IllegalStateException.<init>
        // call: Intrinsics.stringPlus
        // field: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.f9ed39e2e
        // type: p2bfb7a6c$pcb5f53af
        // type: IllegalStateException
        return default!;
    }

    private pf31bbdd1 NewChunkedSource(pdfadebdd P0)
    {
        // str: "state: "
        // call: IllegalStateException.<init>
        // call: object.toString
        // call: p2bfb7a6c$pc9b6f438.<init>
        // call: int.valueOf
        // call: Intrinsics.stringPlus
        // field: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.f9ed39e2e
        // type: IllegalStateException
        // type: p2bfb7a6c$pc9b6f438
        return default!;
    }

    private pf31bbdd1 NewFixedLengthSource(long P0)
    {
        // str: "state: "
        // call: object.toString
        // call: IllegalStateException.<init>
        // call: int.valueOf
        // call: p2bfb7a6c$p432b0cdb.<init>
        // call: Intrinsics.stringPlus
        // field: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.f9ed39e2e
        // type: IllegalStateException
        // type: p2bfb7a6c$p432b0cdb
        return default!;
    }

    private p1eb558b5 NewKnownLengthSink()
    {
        // str: "state: "
        // call: int.valueOf
        // call: p2bfb7a6c$p5731975f.<init>
        // call: Intrinsics.stringPlus
        // call: object.toString
        // call: IllegalStateException.<init>
        // field: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.f9ed39e2e
        // type: p2bfb7a6c$p5731975f
        // type: IllegalStateException
        return default!;
    }

    private pf31bbdd1 NewUnknownLengthSource()
    {
        // str: "state: "
        // call: IllegalStateException.<init>
        // call: Intrinsics.stringPlus
        // call: p2bfb7a6c.getConnection
        // call: int.valueOf
        // call: object.toString
        // call: p2bfb7a6c$p6aaee39f.<init>
        // call: pc2c7dd60.noNewExchanges$okhttp
        // field: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.f9ed39e2e
        // type: p2bfb7a6c$p6aaee39f
        // type: IllegalStateException
        return default!;
    }

    public void Cancel()
    {
        // call: pc2c7dd60.cancel
        // call: p2bfb7a6c.getConnection
    }

    public p1eb558b5 CreateRequestBody(p15c2d85f P0, long P1)
    {
        // str: "Cannot stream a request body without chunked encoding or a known content length!"
        // str: "request"
        // str: "Duplex connections are not supported for HTTP/1"
        // call: p0d3cf03b.isDuplex
        // call: Intrinsics.checkNotNullParameter
        // call: p15c2d85f.body
        // call: p2bfb7a6c.newChunkedSink
        // call: p2bfb7a6c.isChunked
        // call: ProtocolException.<init>
        // call: IllegalStateException.<init>
        // call: p2bfb7a6c.newKnownLengthSink
        // type: IllegalStateException
        // type: ProtocolException
        return default!;
    }

    public void FinishRequest()
    {
        // call: p08d84bc6.flush
        // field: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.ff6e04117
    }

    public void FlushRequest()
    {
        // call: p08d84bc6.flush
        // field: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.ff6e04117
    }

    public pc2c7dd60 GetConnection()
    {
        // field: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.f4717d53e
        return default!;
    }

    public bool IsClosed()
    {
        // field: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.f9ed39e2e
        return false;
    }

    public pf31bbdd1 OpenResponseBodySource(pd64ed3e9 P0)
    {
        // str: "response"
        // call: p2bfb7a6c.newFixedLengthSource
        // call: p2bfb7a6c.isChunked
        // call: p2bfb7a6c.newChunkedSource
        // call: p23e8a4b4.headersContentLength
        // call: p15c2d85f.url
        // call: p2bfb7a6c.newUnknownLengthSource
        // call: pd896b5e6.promisesBody
        // call: Intrinsics.checkNotNullParameter
        // call: pd64ed3e9.request
        return default!;
    }

    public pd64ed3e9$p2bd4a59b ReadResponseHeaders(bool P0)
    {
        // str: "state: "
        // str: "unexpected end of stream on "
        // call: p2bfb7a6c.getConnection
        // call: pc2c7dd60.route
        // call: IllegalStateException.<init>
        // call: Intrinsics.stringPlus
        // call: int.valueOf
        // call: pdfadebdd.redact
        // call: object.toString
        // call: pdd7bf230.url
        // call: pa559d6f1.readLine
        // call: p61386e8f$p910eef8c.parse
        // call: pd64ed3e9$p2bd4a59b.<init>
        // call: pd64ed3e9$p2bd4a59b.protocol
        // call: pd64ed3e9$p2bd4a59b.code
        // call: pd64ed3e9$p2bd4a59b.message
        // call: pa559d6f1.readHeaders
        // call: pd64ed3e9$p2bd4a59b.headers
        // call: IOException.<init>
        // call: p9405c3af.address
        // field: p7ddcfee1.pd1efad72.p80791b3a.p61386e8f.f910eef8c
        // field: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.ffef7aef9
        // field: p7ddcfee1.pd1efad72.p80791b3a.p61386e8f.f81788ba0
        // field: p7ddcfee1.pd1efad72.p80791b3a.p61386e8f.fc1336794
        // field: p7ddcfee1.pd1efad72.p80791b3a.p61386e8f.f78e73102
        // field: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.f9ed39e2e
        // type: pd64ed3e9$p2bd4a59b
        // type: IOException
        // type: IllegalStateException
        return default!;
    }

    public long ReportedContentLength(pd64ed3e9 P0)
    {
        // str: "response"
        // call: pd896b5e6.promisesBody
        // call: p23e8a4b4.headersContentLength
        // call: p2bfb7a6c.isChunked
        // call: Intrinsics.checkNotNullParameter
        return 0;
    }

    public void SkipConnectBody(pd64ed3e9 P0)
    {
        // str: "response"
        // call: pf31bbdd1.close
        // call: p23e8a4b4.headersContentLength
        // call: Intrinsics.checkNotNullParameter
        // call: p23e8a4b4.skipAll
        // call: p2bfb7a6c.newFixedLengthSource
        // field: java.util.concurrent.TimeUnit.MILLISECONDS
    }

    public p883d7615 Trailers()
    {
        // str: "too early; can't read the trailers yet"
        // call: IllegalStateException.<init>
        // call: object.toString
        // field: p7ddcfee1.pd1efad72.p23e8a4b4.f12ea5829
        // field: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.ffbfe9809
        // field: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.f9ed39e2e
        // type: IllegalStateException
        return default!;
    }

    public void WriteRequest(p883d7615 P0, string P1)
    {
        // str: "state: "
        // str: "requestLine"
        // str: ": "
        // str: "\r\n"
        // str: "headers"
        // call: IllegalStateException.<init>
        // call: Intrinsics.stringPlus
        // call: p08d84bc6.writeUtf8
        // call: object.toString
        // call: p883d7615.name
        // call: p883d7615.size
        // call: Intrinsics.checkNotNullParameter
        // call: p883d7615.value
        // call: int.valueOf
        // field: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.ff6e04117
        // field: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.f9ed39e2e
        // type: IllegalStateException
    }

    public void WriteRequestHeaders(p15c2d85f P0)
    {
        // str: "request"
        // str: "connection.route().proxy.type()"
        // call: p2bfb7a6c.writeRequest
        // call: Intrinsics.checkNotNullExpressionValue
        // call: p6c333899.get
        // call: Intrinsics.checkNotNullParameter
        // call: Proxy.type
        // call: p2bfb7a6c.getConnection
        // call: p9405c3af.proxy
        // call: pc2c7dd60.route
        // call: p15c2d85f.headers
        // field: p7ddcfee1.pd1efad72.p80791b3a.p6c333899.f76425f17
    }

}
