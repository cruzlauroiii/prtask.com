namespace WillowMaze.Wasm.Decompiled;

public class P2bfb7a6c_pc9b6f438 : P2bfb7a6c$p7b0df7d7
{
    private readonly pdfadebdd F0d88f43c;
    private bool F39538500;
    private long F48a3baea;
    private readonly pdfadebdd F572d4e42;
    private bool F637e692d;
    private bool F7de17ce5;
    private long F893e7a68;
    private long F8ce4cbd1;
    private long Faa73cef3;
    private bool Faccd1c75;
    private long Fe8373387;
    private bool Fff1dc196;
    private readonly p2bfb7a6c This$0;

    private void ReadChunkSize()
    {
        // str: ";"
        // str: "expected chunk size and optional extensions but was \""
        // call: pcc81e3f6.readUtf8LineStrict
        // call: p2bfb7a6c.access$getSource$p
        // call: pcc81e3f6.readHexadecimalUnsignedLong
        // call: StringsKt.trim
        // call: object.toString
        // call: CharSequence.length
        // call: StringsKt.startsWith$default
        // call: p2bfb7a6c$pc9b6f438.responseBodyComplete
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: ProtocolException.<init>
        // call: p2bfb7a6c.access$getTrailers$p
        // call: pd896b5e6.receiveHeaders
        // call: p2bfb7a6c.access$getHeadersReader$p
        // call: pa559d6f1.readHeaders
        // call: p2bfb7a6c.access$setTrailers$p
        // call: Intrinsics.checkNotNull
        // call: NumberFormatException.getMessage
        // call: p1cda7fcc.cookieJar
        // field: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c$pc9b6f438.this$0
        // field: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c$pc9b6f438.f8ce4cbd1
        // field: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c$pc9b6f438.f637e692d
        // field: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c$pc9b6f438.f572d4e42
        // type: ProtocolException
        // type: StringBuilder
    }

    public void Close()
    {
        // call: p2bfb7a6c.getConnection
        // call: p2bfb7a6c$pc9b6f438.responseBodyComplete
        // call: p2bfb7a6c$pc9b6f438.getClosed
        // call: pc2c7dd60.noNewExchanges$okhttp
        // call: p2bfb7a6c$pc9b6f438.setClosed
        // call: p23e8a4b4.discard
        // field: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c$pc9b6f438.this$0
        // field: java.util.concurrent.TimeUnit.MILLISECONDS
        // field: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c$pc9b6f438.f637e692d
    }

    public long Read(p7e62bc34 P0, long P1)
    {
        // str: "unexpected end of stream"
        // str: "closed"
        // str: "byteCount < 0: "
        // str: "sink"
        // call: p2bfb7a6c$p7b0df7d7.read
        // call: long.valueOf
        // call: p2bfb7a6c$pc9b6f438.responseBodyComplete
        // call: p2bfb7a6c.getConnection
        // call: pc2c7dd60.noNewExchanges$okhttp
        // call: Intrinsics.checkNotNullParameter
        // call: IllegalArgumentException.<init>
        // call: object.toString
        // call: p2bfb7a6c$pc9b6f438.getClosed
        // call: Intrinsics.stringPlus
        // call: p2bfb7a6c$pc9b6f438.readChunkSize
        // call: Math.min
        // call: IllegalStateException.<init>
        // call: ProtocolException.<init>
        // field: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c$pc9b6f438.f637e692d
        // field: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c$pc9b6f438.f8ce4cbd1
        // field: p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c$pc9b6f438.this$0
        // type: ProtocolException
        // type: IllegalArgumentException
        // type: IllegalStateException
        return 0;
    }

}
