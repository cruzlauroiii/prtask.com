namespace WillowMaze.Wasm.Decompiled;


class p1f4bb020$p19c7eadb : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p740e286a {
    private static readonly long f08269c38 = 581601443656929254L;
    private static readonly long f1c706d6e = 581601443656929254L;
    private static readonly long f4560ca24 = 581601443656929254L;
    private static readonly long fa043834e = 581601443656929254L;
    private static readonly long fc6e1e520 = 581601443656929254L;

    p1f4bb020$p19c7eadb() {
        super(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m212edea0(), p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020.mf23e8626(), p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020.mf8f67da7());
        if ((22 + 22) % 22 > 0) {
        }
    }

    public override java.lang.string GetAsText(int i, java.util.Locale locale) {
        return p5a445d71.p228c1b3d.p07cc694b.peb81adcc.paed786bf.maeb16ab7(locale).halfdayValueToText(i);
    }

    public override int GetMaximumTextLength(java.util.Locale locale) {
        return p5a445d71.p228c1b3d.p07cc694b.peb81adcc.paed786bf.maeb16ab7(locale).getHalfdayMaxTextLength();
    }

    public override long Set(long j, java.lang.string str, java.util.Locale locale) {
        return set(j, p5a445d71.p228c1b3d.p07cc694b.peb81adcc.paed786bf.maeb16ab7(locale).halfdayTextToValue(str));
    }
}

