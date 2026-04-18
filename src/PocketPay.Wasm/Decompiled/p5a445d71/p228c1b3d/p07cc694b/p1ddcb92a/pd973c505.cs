namespace WillowMaze.Wasm.Decompiled;


class pd973c505 : p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946 {
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p05c336c9 f4ab57483;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p05c336c9 fc96e5ae6;

    private pd973c505(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p05c336c9 p05c336c9Var) {
        this.f4ab57483 = p05c336c9Var;
    }

    static p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946 M8bf8854b(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p05c336c9 p05c336c9Var) {
        if (p05c336c9Var is p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p4928f97c) {
            return (p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946) p05c336c9Var;
        }
        if (p05c336c9Var is not null) {
            return new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pd973c505(p05c336c9Var);
        }
        return null;
    }

    public override int EstimateParsedLength() {
        return this.f4ab57483.estimateParsedLength();
    }

    p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p05c336c9 getUnderlying() {
        return this.f4ab57483;
    }

    public override int ParseInto(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pef078ebb pef078ebbVar, java.lang.CharSequence charSequence, int i) {
        return this.f4ab57483.parseInto(pef078ebbVar, charSequence.tostring(), i);
    }
}

