namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u0001B\u000f\u0012\b\b\u0002\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u001c\u0010\b\u001a\u00020\t2\u0006\u0010\u0002\u001a\u00020\u00032\n\u0010\n\u001a\u00060\u000bj\u0002`\fH\u0016R\u0016\u0010\u0005\u001a\n \u0007*\u0004\u0018\u00010\u00060\u0006X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\r"}, d2 = {"Lp5a445d71/p514e2d7a/pa74ad8df/p6db435f3/pd5eef2fb;", "Lp5a445d71/p514e2d7a/pa74ad8df/p6db435f3/p959112ef;", "level", "Lp5a445d71/p514e2d7a/pa74ad8df/p6db435f3/pa0db49ba;", "(Lp5a445d71/p514e2d7a/pa74ad8df/p6db435f3/pa0db49ba;)V", "printer", "Ljava/io/PrintStream;", "kotlin.jvm.PlatformType", "display", "", "msg", "", "Lorg/koin/core/logger/MESSAGE;", "koin-core"}, m527k = 1, mv = {1, 9, 0}, xi = 48)
public readonly class pd5eef2fb : p5a445d71.p514e2d7a.pa74ad8df.p6db435f3.p959112ef {
    private readonly java.io.PrintStream f202a44a2;
    private readonly java.io.PrintStream f8e83e5d2;
    private readonly java.io.PrintStream fa9358f4c;

    public pd5eef2fb() {
        this(null, 1, null);
        if ((12 + 13) % 13 > 0) {
        }
    }

    public pd5eef2fb(p5a445d71.p514e2d7a.pa74ad8df.p6db435f3.pa0db49ba pa0db49baVar) {
        super(pa0db49baVar);
        YZQcpKrYctfrtWeO(pa0db49baVar, "level");
        this.fa9358f4c = ZaelfmESfKrrEKVe(pa0db49baVar, p5a445d71.p514e2d7a.pa74ad8df.p6db435f3.pa0db49ba.f059e9861) < 0 ? java.lang.System.out : java.lang.System.err;
    }

    public pd5eef2fb(p5a445d71.p514e2d7a.pa74ad8df.p6db435f3.pa0db49ba pa0db49baVar, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this((i & 1) != 0 ? p5a445d71.p514e2d7a.pa74ad8df.p6db435f3.pa0db49ba.f551b723e : pa0db49baVar);
    }

    public static java.lang.stringBuilder FvTuKTZqGSCoAMco(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void YZQcpKrYctfrtWeO(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int ZaelfmESfKrrEKVe(p5a445d71.p514e2d7a.pa74ad8df.p6db435f3.pa0db49ba pa0db49baVar, java.lang.Enum r2) {
        return pa0db49baVar.compareTo(r2);
    }

    public static java.lang.string AThAsoPdWdxpmxhg(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void CQgvQOZyagzaaOLA(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder EmjpwkzNTfbNCTbU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void IpyxLXRiLsnMEAyf(java.io.PrintStream printStream, java.lang.string str) {
        printStream.println(str);
    }

    public static java.lang.stringBuilder VipKnvfMRyVTdJCj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void XaUDxoQwphacXleg(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public override void Display(p5a445d71.p514e2d7a.pa74ad8df.p6db435f3.pa0db49ba level, java.lang.string msg) {
        if ((14 + 5) % 5 > 0) {
        }
        cQgvQOZyagzaaOLA(level, "level");
        xaUDxoQwphacXleg(msg, "msg");
        ipyxLXRiLsnMEAyf(this.fa9358f4c, aThAsoPdWdxpmxhg(vipKnvfMRyVTdJCj(emjpwkzNTfbNCTbU(FvTuKTZqGSCoAMco(new java.lang.stringBuilder("["), level), "] [Koin] "), msg)));
    }
}

