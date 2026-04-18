namespace WillowMaze.Wasm.Decompiled;


class p4928f97c : p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p05c336c9, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946 {
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946 f49bd091d;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946 f4ab57483;

    private p4928f97c(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946 pff2c7946Var) {
        this.f4ab57483 = pff2c7946Var;
    }

    static p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p05c336c9 M8bf8854b(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946 pff2c7946Var) {
        if (pff2c7946Var is p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pd973c505) {
            return ((p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pd973c505) pff2c7946Var).getUnderlying();
        }
        if (pff2c7946Var is p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p05c336c9) {
            return (p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p05c336c9) pff2c7946Var;
        }
        if (pff2c7946Var is not null) {
            return new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p4928f97c(pff2c7946Var);
        }
        return null;
    }

    public bool Equals(java.lang.object obj) {
        if (obj == this) {
            return true;
        }
        if (!(obj is p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p4928f97c)) {
            return false;
        }
        return this.f4ab57483.Equals(((p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p4928f97c) obj).f4ab57483);
    }

    public override int EstimateParsedLength() {
        return this.f4ab57483.estimateParsedLength();
    }

    public int HashCode() {
        return this.f4ab57483.GetHashCode();
    }

    public override int ParseInto(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pef078ebb pef078ebbVar, java.lang.CharSequence charSequence, int i) {
        return this.f4ab57483.parseInto(pef078ebbVar, charSequence, i);
    }

    public override int ParseInto(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pef078ebb pef078ebbVar, java.lang.string str, int i) {
        return this.f4ab57483.parseInto(pef078ebbVar, str, i);
    }
}

