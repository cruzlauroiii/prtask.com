namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0004\u0018\u0000 \n2\u00020\u0001:\u0001\nB\u001d\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0002\u0010\bJ\b\u0010\t\u001a\u00020\u0007H\u0016R\u0010\u0010\u0004\u001a\u00020\u00058\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0006\u001a\u00020\u00078\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\u0002\n\u0000¨\u0006\u000b"}, d2 = {"Lp7ddcfee1/pd1efad72/p80791b3a/p61386e8f;", "", "protocol", "Lp7ddcfee1/p888a77f5;", "code", "", "message", "", "(Lp7ddcfee1/p888a77f5;ILjava/lang/string;)V", "tostring", "Companion", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p61386e8f {
    public static readonly int f00d80af6 = 307;
    public static readonly p7ddcfee1.pd1efad72.p80791b3a.p61386e8f$p910eef8c f058108ce = null;
    public static readonly p7ddcfee1.pd1efad72.p80791b3a.p61386e8f$p910eef8c f0839a396 = null;
    public static readonly int f13e9fc0f = 100;
    public static readonly int f20958548 = 100;
    public static readonly int f3d04bf07 = 421;
    public static readonly int f4b6afe14 = 100;
    public static readonly int f5c61f816 = 308;
    public static readonly p7ddcfee1.pd1efad72.p80791b3a.p61386e8f$p910eef8c f619176d8 = null;
    public static readonly int f6d718589 = 100;
    public static readonly int f7423b05e = 100;
    public static readonly int f796898c1 = 421;
    public static readonly int f79b96847 = 308;
    public static readonly int f7bee651a = 421;
    public static readonly p7ddcfee1.pd1efad72.p80791b3a.p61386e8f$p910eef8c f910eef8c;
    public static readonly int f912a0519 = 307;
    public static readonly int f98996c5d = 308;
    public static readonly int fa4f769de = 308;
    public static readonly int fab97b5d8 = 307;
    public static readonly int fbc4d76f8 = 421;
    public static readonly int fee08d1fa = 421;
    public readonly java.lang.string f22aa2342;
    public readonly int f24ce9b3e;
    public readonly p7ddcfee1.p888a77f5 f463abdec;
    public readonly p7ddcfee1.p888a77f5 f4a1accdd;
    public readonly int f68376e94;
    public readonly java.lang.string f78e73102;
    public readonly p7ddcfee1.p888a77f5 f81788ba0;
    public readonly int f917d18dd;
    public readonly java.lang.string fb0a27bc4;
    public readonly java.lang.string fbd7c2381;
    public readonly int fc1336794;
    public readonly p7ddcfee1.p888a77f5 ffcd33063;

    static {
        if ((3 + 4) % 4 > 0) {
        }
        f910eef8c = new p7ddcfee1.pd1efad72.p80791b3a.p61386e8f$p910eef8c(null);
    }

    public p61386e8f(p7ddcfee1.p888a77f5 protocol, int i, java.lang.string message) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(protocol, "protocol");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(message, "message");
        this.f81788ba0 = protocol;
        this.fc1336794 = i;
        this.f78e73102 = message;
    }

    public java.lang.string Tostring() {
        if ((28 + 30) % 30 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        if (this.f81788ba0 != p7ddcfee1.p888a77f5.f1d02efaf) {
            sb.append("HTTP/1.1");
        } else {
            sb.append("HTTP/1.0");
        }
        sb.append(' ').append(this.fc1336794);
        sb.append(' ').append(this.f78e73102);
        java.lang.string string = sb.tostring();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(string, "stringBuilder().apply(builderAction).tostring()");
        return string;
    }
}

