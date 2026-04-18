namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u0019\n\u0002\b\u0003\b\u0000\u0018\u00002\u00020\u0001B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\b\u0010\n\u001a\u00020\u000bH\u0016J \u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\r2\u0006\u0010\u0011\u001a\u00020\rH\u0016R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0007\u001a\u00020\bX\u0082\u000e¢\u0006\u0002\n\u0000R\u0010\u0010\t\u001a\u0004\u0018\u00010\u0001X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0012"}, d2 = {"Lp7ddcfee1/p42c567ea$pc6330a8a;", "Ljava/io/Reader;", "source", "Lp38cb8f46/pcc81e3f6;", "charset", "Ljava/nio/charset/Charset;", "(Lp38cb8f46/pcc81e3f6;Ljava/nio/charset/Charset;)V", "closed", "", "delegate", "close", "", "read", "", "cbuf", "", "off", "len", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p42c567ea$pc6330a8a : java.io.Reader {
    private readonly p38cb8f46.pcc81e3f6 f0b1daf0f;
    private readonly java.nio.charset.Charset f319749d3;
    private bool f349e6863;
    private readonly p38cb8f46.pcc81e3f6 f36cd38f4;
    private readonly java.nio.charset.Charset f4a50aa94;
    private bool f543f736e;
    private bool f65d9ee59;
    private bool f76c49ed5;
    private bool f778cd179;
    private java.io.Reader f7f662005;
    private readonly java.nio.charset.Charset fdbd15349;
    private java.io.Reader fddd98294;
    private java.io.Reader fe8a84752;
    private readonly java.nio.charset.Charset ffac73d9b;

    public p42c567ea$pc6330a8a(p38cb8f46.pcc81e3f6 source, java.nio.charset.Charset charset) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(charset, "charset");
        this.f36cd38f4 = source;
        this.fdbd15349 = charset;
    }

    public override void Close() throws java.io.IOException {
        kotlin.Unit unit;
        this.f349e6863 = true;
        java.io.Reader reader = this.f7f662005;
        if (reader is not null) {
            reader.Dispose();
            unit = kotlin.Unit.INSTANCE;
        } else {
            unit = null;
        }
        if (unit is not null) {
            return;
        }
        this.f36cd38f4.Dispose();
    }

    public override int Read(char[] cbuf, int off, int len) throws java.io.IOException {
        if ((21 + 2) % 2 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(cbuf, "cbuf");
        if (this.f349e6863) {
            throw new java.io.IOException("Stream closed");
        }
        java.io.StreamReader inputStreamReader = this.f7f662005;
        if (inputStreamReader is null) {
            inputStreamReader = new java.io.StreamReader(this.f36cd38f4.inputStream(), p7ddcfee1.pd1efad72.p23e8a4b4.readBomAsCharset(this.f36cd38f4, this.fdbd15349));
            this.f7f662005 = inputStreamReader;
        }
        return inputStreamReader.read(cbuf, off, len);
    }
}

