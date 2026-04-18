namespace WillowMaze.Wasm.Decompiled;


class p10497fe1$p223f51d7 : p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$pa96e7a38 {
    protected readonly int f0957d7a4;
    protected readonly int f3d8a5869;
    protected readonly int f4bea7ff7;
    protected readonly int f77f44e98;
    protected readonly int fa4cce0cd;

    protected p10497fe1$p223f51d7(p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var, int i, bool z, int i2) {
        super(p51c74e65Var, i, z);
        this.f4bea7ff7 = i2;
    }

    public override int EstimatePrintedLength() {
        return this.fc90a27fe;
    }

    public override void PrintTo(java.lang.Appendable appendable, long j, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar, int i, p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var, java.util.Locale locale) throws java.io.IOException {
        try {
            p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p4e9a5fbb.mde5af069(appendable, this.ffb699f8c.getField(p7bf898deVar)[j), this.f4bea7ff7);
        } catch (java.lang.Exception unused) {
            p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1.m09cad532(appendable, this.f4bea7ff7);
        }
    }

    public override void PrintTo(java.lang.Appendable appendable, p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, java.util.Locale locale) throws java.io.IOException {
        if (!p774107a9Var.isSupported(this.ffb699f8c)) {
            p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1.m09cad532(appendable, this.f4bea7ff7);
            return;
        }
        try {
            p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p4e9a5fbb.mde5af069(appendable, p774107a9Var[this.ffb699f8c), this.f4bea7ff7);
        } catch (java.lang.Exception unused) {
            p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1.m09cad532(appendable, this.f4bea7ff7);
        }
    }
}

