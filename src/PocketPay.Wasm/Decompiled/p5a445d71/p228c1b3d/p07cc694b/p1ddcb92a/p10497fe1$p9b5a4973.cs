namespace WillowMaze.Wasm.Decompiled;


class p10497fe1$p9b5a4973 : p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p8b970cd7, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946 {
    private readonly char f49590abd;
    private readonly char f919018c9;

    p10497fe1$p9b5a4973(char c) {
        this.f919018c9 = c;
    }

    public override int EstimateParsedLength() {
        return 1;
    }

    public override int EstimatePrintedLength() {
        return 1;
    }

    public override int ParseInto(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pef078ebb pef078ebbVar, java.lang.CharSequence charSequence, int i) {
        if (i >= charSequence.Length) {
            return ~i;
        }
        char cCharAt = charSequence[i);
        char c = this.f919018c9;
        if (cCharAt != c) {
            char upperCase = java.lang.char.toUpperCase(cCharAt);
            char upperCase2 = java.lang.char.toUpperCase(c);
            if (upperCase != upperCase2 && java.lang.char.toLowerCase(upperCase) != java.lang.char.toLowerCase(upperCase2)) {
                return ~i;
            }
        }
        return i + 1;
    }

    public override void PrintTo(java.lang.Appendable appendable, long j, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar, int i, p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var, java.util.Locale locale) throws java.io.IOException {
        appendable.append(this.f919018c9);
    }

    public override void PrintTo(java.lang.Appendable appendable, p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, java.util.Locale locale) throws java.io.IOException {
        appendable.append(this.f919018c9);
    }
}

