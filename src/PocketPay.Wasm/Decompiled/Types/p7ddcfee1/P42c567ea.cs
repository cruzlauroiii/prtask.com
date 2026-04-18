namespace WillowMaze.Wasm.Decompiled;

public abstract class P42c567ea : IDisposable
{
    public static p42c567ea$p910eef8c F6418e627;
    public static p42c567ea$p910eef8c F910eef8c;
    public static p42c567ea$p910eef8c Ff5f3a1a5;
    private Reader F1de9b0a3;
    private Reader F6b93a39e;
    private Reader Fa09812d3;
    private Reader Fa5635130;

    public static p42c567ea M76ea0beb(string P0, pba07c23c P1)
    {
        // call: p42c567ea$p910eef8c.create
        // field: p7ddcfee1.p42c567ea.f910eef8c
        return default!;
    }

    public static p42c567ea M76ea0beb(p58efa9e8 P0, pba07c23c P1)
    {
        // call: p42c567ea$p910eef8c.create
        // field: p7ddcfee1.p42c567ea.f910eef8c
        return default!;
    }

    public static p42c567ea M76ea0beb(pcc81e3f6 P0, pba07c23c P1, long P2)
    {
        // call: p42c567ea$p910eef8c.create
        // field: p7ddcfee1.p42c567ea.f910eef8c
        return default!;
    }

    public static p42c567ea M76ea0beb(pba07c23c P0, long P1, pcc81e3f6 P2)
    {
        // call: p42c567ea$p910eef8c.create
        // field: p7ddcfee1.p42c567ea.f910eef8c
        return default!;
    }

    public static p42c567ea M76ea0beb(pba07c23c P0, string P1)
    {
        // call: p42c567ea$p910eef8c.create
        // field: p7ddcfee1.p42c567ea.f910eef8c
        return default!;
    }

    public static p42c567ea M76ea0beb(pba07c23c P0, p58efa9e8 P1)
    {
        // call: p42c567ea$p910eef8c.create
        // field: p7ddcfee1.p42c567ea.f910eef8c
        return default!;
    }

    public static p42c567ea M76ea0beb(pba07c23c P0, byte[] P1)
    {
        // call: p42c567ea$p910eef8c.create
        // field: p7ddcfee1.p42c567ea.f910eef8c
        return default!;
    }

    public static p42c567ea M76ea0beb(byte[] P0, pba07c23c P1)
    {
        // call: p42c567ea$p910eef8c.create
        // field: p7ddcfee1.p42c567ea.f910eef8c
        return default!;
    }

    private System.Text.Encoding Mdbd15349()
    {
        // call: pba07c23c.charset
        // call: p42c567ea.contentType
        // field: kotlin.text.Charsets.UTF_8
        return default!;
    }

    private object Mee4cfa9b(Func<object, object> P0, Func<object, object> P1)
    {
        // str: "Cannot buffer entire body for content length: "
        // str: ") and stream length ("
        // str: ") disagree"
        // str: "Content-Length ("
        // call: CloseableKt.closeFinally
        // call: StringBuilder.append
        // call: IOException.<init>
        // call: long.valueOf
        // call: Intrinsics.stringPlus
        // call: Func<object, object>.invoke
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: p42c567ea.source
        // call: System.Numerics.BigInteger.intValue
        // call: p42c567ea.contentLength
        // type: StringBuilder
        // type: IOException
        return default!;
    }

    public Stream ByteStream()
    {
        // call: p42c567ea.source
        // call: pcc81e3f6.inputStream
        return default!;
    }

    public p58efa9e8 ByteString()
    {
        // str: "Content-Length ("
        // str: ") and stream length ("
        // str: "Cannot buffer entire body for content length: "
        // str: ") disagree"
        // call: IOException.<init>
        // call: p42c567ea.source
        // call: pcc81e3f6.readByteString
        // call: StringBuilder.append
        // call: p58efa9e8.size
        // call: StringBuilder.toString
        // call: CloseableKt.closeFinally
        // call: StringBuilder.<init>
        // call: long.valueOf
        // call: p42c567ea.contentLength
        // call: Intrinsics.stringPlus
        // type: IOException
        // type: StringBuilder
        return default!;
    }

    public byte[] Bytes()
    {
        // str: ") disagree"
        // str: ") and stream length ("
        // str: "Cannot buffer entire body for content length: "
        // str: "Content-Length ("
        // call: StringBuilder.append
        // call: CloseableKt.closeFinally
        // call: long.valueOf
        // call: p42c567ea.source
        // call: IOException.<init>
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: p42c567ea.contentLength
        // call: Intrinsics.stringPlus
        // call: pcc81e3f6.readByteArray
        // type: StringBuilder
        // type: IOException
        return default!;
    }

    public Reader CharStream()
    {
        // call: p42c567ea.mdbd15349
        // call: p42c567ea$pc6330a8a.<init>
        // call: p42c567ea.source
        // field: p7ddcfee1.p42c567ea.f1de9b0a3
        // type: p42c567ea$pc6330a8a
        return default!;
    }

    public void Close()
    {
        // call: p23e8a4b4.closeQuietly
        // call: p42c567ea.source
    }

    public long ContentLength()
    {
        return 0;
    }

    public pba07c23c ContentType()
    {
        return default!;
    }

    public pcc81e3f6 Source()
    {
        return default!;
    }

    public string String()
    {
        // call: CloseableKt.closeFinally
        // call: p42c567ea.mdbd15349
        // call: p23e8a4b4.readBomAsCharset
        // call: pcc81e3f6.readString
        // call: p42c567ea.source
        return string.Empty;
    }

}
