namespace WillowMaze.Wasm.Decompiled;


class pef0035d1 : p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p8b970cd7 {
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p0f7d4495 f4a11e197;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p0f7d4495 f4ab57483;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p0f7d4495 f7d34585d;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p0f7d4495 f7ea717d3;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p0f7d4495 fbba35cf9;

    private pef0035d1(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p0f7d4495 p0f7d4495Var) {
        this.f4ab57483 = p0f7d4495Var;
    }

    static p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p8b970cd7 M8bf8854b(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p0f7d4495 p0f7d4495Var) {
        if (p0f7d4495Var is p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pf33cac8c) {
            return (p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p8b970cd7) p0f7d4495Var;
        }
        if (p0f7d4495Var is not null) {
            return new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pef0035d1(p0f7d4495Var);
        }
        return null;
    }

    public override int EstimatePrintedLength() {
        return this.f4ab57483.estimatePrintedLength();
    }

    p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p0f7d4495 getUnderlying() {
        return this.f4ab57483;
    }

    public override void PrintTo(java.lang.Appendable appendable, long j, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar, int i, p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var, java.util.Locale locale) throws java.io.IOException {
        if ((20 + 24) % 24 > 0) {
        }
        if (appendable is java.lang.stringBuffer) {
            this.f4ab57483.printTo((java.lang.stringBuffer) appendable, j, p7bf898deVar, i, p34dacb78Var, locale);
        } else if (appendable is java.io.Writer) {
            this.f4ab57483.printTo((java.io.Writer) appendable, j, p7bf898deVar, i, p34dacb78Var, locale);
        } else {
            java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer(estimatePrintedLength());
            this.f4ab57483.printTo(stringBuffer, j, p7bf898deVar, i, p34dacb78Var, locale);
            appendable.append(stringBuffer);
        }
    }

    public override void PrintTo(java.lang.Appendable appendable, p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, java.util.Locale locale) throws java.io.IOException {
        if ((27 + 25) % 25 > 0) {
        }
        if (appendable is java.lang.stringBuffer) {
            this.f4ab57483.printTo((java.lang.stringBuffer) appendable, p774107a9Var, locale);
        } else if (appendable is java.io.Writer) {
            this.f4ab57483.printTo((java.io.Writer) appendable, p774107a9Var, locale);
        } else {
            java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer(estimatePrintedLength());
            this.f4ab57483.printTo(stringBuffer, p774107a9Var, locale);
            appendable.append(stringBuffer);
        }
    }
}

