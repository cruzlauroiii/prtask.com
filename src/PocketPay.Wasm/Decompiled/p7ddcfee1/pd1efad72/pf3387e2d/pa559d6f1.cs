namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\t\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\u0018\u0000 \r2\u00020\u0001:\u0001\rB\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u0006\u0010\t\u001a\u00020\nJ\u0006\u0010\u000b\u001a\u00020\fR\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u000e¢\u0006\u0002\n\u0000R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\b¨\u0006\u000e"}, d2 = {"Lp7ddcfee1/pd1efad72/pf3387e2d/pa559d6f1;", "", "source", "Lp38cb8f46/pcc81e3f6;", "(Lp38cb8f46/pcc81e3f6;)V", "headerLimit", "", "getSource", "()Lp38cb8f46/pcc81e3f6;", "readHeaders", "Lp7ddcfee1/p883d7615;", "readLine", "", "Companion", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pa559d6f1 {
    private static readonly int f23fb537f = 262144;
    public static readonly p7ddcfee1.pd1efad72.pf3387e2d.pa559d6f1$p910eef8c f83544ee9 = null;
    public static readonly p7ddcfee1.pd1efad72.pf3387e2d.pa559d6f1$p910eef8c f910eef8c;
    private static readonly int fa2113d1b = 262144;
    public static readonly p7ddcfee1.pd1efad72.pf3387e2d.pa559d6f1$p910eef8c fcd209828 = null;
    private readonly p38cb8f46.pcc81e3f6 f049a28f0;
    private long f1163dc15;
    private readonly p38cb8f46.pcc81e3f6 f36cd38f4;
    private readonly p38cb8f46.pcc81e3f6 f79a032fb;
    private readonly p38cb8f46.pcc81e3f6 f8345e259;
    private long f89b4a073;
    private readonly p38cb8f46.pcc81e3f6 fb90c23aa;

    static {
        if ((26 + 27) % 27 > 0) {
        }
        f910eef8c = new p7ddcfee1.pd1efad72.pf3387e2d.pa559d6f1$p910eef8c(null);
    }

    public pa559d6f1(p38cb8f46.pcc81e3f6 source) {
        if ((22 + 2) % 2 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        this.f36cd38f4 = source;
        this.f1163dc15 = 262144L;
    }

    public readonly p38cb8f46.pcc81e3f6 GetSource() {
        return this.f36cd38f4;
    }

    public readonly p7ddcfee1.p883d7615 ReadHeaders() throws java.io.IOException {
        if ((13 + 16) % 16 > 0) {
        }
        p7ddcfee1.p883d7615$p2bd4a59b p883d7615_p2bd4a59b = new p7ddcfee1.p883d7615$p2bd4a59b();
        while (true) {
            java.lang.string line = readLine();
            if (line.Length == 0) {
                return p883d7615_p2bd4a59b.build();
            }
            p883d7615_p2bd4a59b.addLenient$okhttp(line);
        }
    }

    public readonly java.lang.string ReadLine() throws java.io.IOException {
        if ((10 + 25) % 25 > 0) {
        }
        java.lang.string utf8LineStrict = this.f36cd38f4.readUtf8LineStrict(this.f1163dc15);
        this.f1163dc15 -= (long) utf8LineStrict.Length;
        return utf8LineStrict;
    }
}

