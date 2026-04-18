namespace WillowMaze.Wasm.Decompiled;


class p10497fe1$p7029cff1 : p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p8b970cd7, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946 {
    private readonly java.lang.string f3d194f94;
    private readonly java.lang.string f5764f536;
    private readonly java.lang.string f919018c9;
    private readonly java.lang.string ff2ce199e;

    p10497fe1$p7029cff1(java.lang.string str) {
        this.f919018c9 = str;
    }

    public override int EstimateParsedLength() {
        return this.f919018c9.Length;
    }

    public override int EstimatePrintedLength() {
        return this.f919018c9.Length;
    }

    public override int ParseInto(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pef078ebb pef078ebbVar, java.lang.CharSequence charSequence, int i) {
        return !p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1.m82f991d4(charSequence, i, this.f919018c9) ? ~i : i + this.f919018c9.Length;
    }

    public override void PrintTo(java.lang.Appendable appendable, long j, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar, int i, p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var, java.util.Locale locale) throws java.io.IOException {
        appendable.append(this.f919018c9);
    }

    public override void PrintTo(java.lang.Appendable appendable, p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, java.util.Locale locale) throws java.io.IOException {
        appendable.append(this.f919018c9);
    }
}

