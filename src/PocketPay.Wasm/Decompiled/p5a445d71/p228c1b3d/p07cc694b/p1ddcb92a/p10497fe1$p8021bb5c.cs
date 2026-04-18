namespace WillowMaze.Wasm.Decompiled;


class p10497fe1$p8021bb5c : p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$pa96e7a38 {
    protected p10497fe1$p8021bb5c(p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var, int i, bool z) {
        super(p51c74e65Var, i, z);
    }

    public override int EstimatePrintedLength() {
        return this.fc90a27fe;
    }

    public override void PrintTo(java.lang.Appendable appendable, long j, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar, int i, p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var, java.util.Locale locale) throws java.io.IOException {
        try {
            p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p4e9a5fbb.mc9813c4c(appendable, this.ffb699f8c.getField(p7bf898deVar)[j));
        } catch (java.lang.Exception unused) {
            appendable.append((char) 65533);
        }
    }

    public override void PrintTo(java.lang.Appendable appendable, p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, java.util.Locale locale) throws java.io.IOException {
        if (!p774107a9Var.isSupported(this.ffb699f8c)) {
            appendable.append((char) 65533);
            return;
        }
        try {
            p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p4e9a5fbb.mc9813c4c(appendable, p774107a9Var[this.ffb699f8c));
        } catch (java.lang.Exception unused) {
            appendable.append((char) 65533);
        }
    }
}

