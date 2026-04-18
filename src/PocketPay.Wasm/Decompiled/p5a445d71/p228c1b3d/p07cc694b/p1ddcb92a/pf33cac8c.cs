namespace WillowMaze.Wasm.Decompiled;


class pf33cac8c : p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p0f7d4495, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p8b970cd7 {
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p8b970cd7 f3b6807d8;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p8b970cd7 f4ab57483;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p8b970cd7 f805cdadc;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p8b970cd7 fdcd222f5;

    private pf33cac8c(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p8b970cd7 p8b970cd7Var) {
        this.f4ab57483 = p8b970cd7Var;
    }

    static p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p0f7d4495 M8bf8854b(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p8b970cd7 p8b970cd7Var) {
        if (p8b970cd7Var is p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pef0035d1) {
            return ((p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pef0035d1) p8b970cd7Var).getUnderlying();
        }
        if (p8b970cd7Var is p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p0f7d4495) {
            return (p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p0f7d4495) p8b970cd7Var;
        }
        if (p8b970cd7Var is not null) {
            return new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pf33cac8c(p8b970cd7Var);
        }
        return null;
    }

    public bool Equals(java.lang.object obj) {
        if (obj == this) {
            return true;
        }
        if (!(obj is p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pf33cac8c)) {
            return false;
        }
        return this.f4ab57483.Equals(((p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pf33cac8c) obj).f4ab57483);
    }

    public override int EstimatePrintedLength() {
        return this.f4ab57483.estimatePrintedLength();
    }

    public int HashCode() {
        return this.f4ab57483.GetHashCode();
    }

    public override void PrintTo(java.io.Writer writer, long j, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar, int i, p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var, java.util.Locale locale) throws java.io.IOException {
        this.f4ab57483.printTo(writer, j, p7bf898deVar, i, p34dacb78Var, locale);
    }

    public override void PrintTo(java.io.Writer writer, p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, java.util.Locale locale) throws java.io.IOException {
        this.f4ab57483.printTo(writer, p774107a9Var, locale);
    }

    public override void PrintTo(java.lang.Appendable appendable, long j, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar, int i, p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var, java.util.Locale locale) throws java.io.IOException {
        this.f4ab57483.printTo(appendable, j, p7bf898deVar, i, p34dacb78Var, locale);
    }

    public override void PrintTo(java.lang.Appendable appendable, p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, java.util.Locale locale) throws java.io.IOException {
        this.f4ab57483.printTo(appendable, p774107a9Var, locale);
    }

    public override void PrintTo(java.lang.stringBuffer stringBuffer, long j, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar, int i, p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var, java.util.Locale locale) {
        try {
            this.f4ab57483.printTo(stringBuffer, j, p7bf898deVar, i, p34dacb78Var, locale);
        } catch (java.io.IOException unused) {
        }
    }

    public override void PrintTo(java.lang.stringBuffer stringBuffer, p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, java.util.Locale locale) {
        try {
            this.f4ab57483.printTo(stringBuffer, p774107a9Var, locale);
        } catch (java.io.IOException unused) {
        }
    }
}

