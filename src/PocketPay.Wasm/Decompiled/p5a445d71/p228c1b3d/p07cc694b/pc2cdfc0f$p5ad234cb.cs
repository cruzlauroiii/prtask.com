namespace WillowMaze.Wasm.Decompiled;


public readonly class pc2cdfc0f$p5ad234cb : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p961c80d7 {
    private static readonly long fc6e1e520 = -4481126543819298617L;
    private static readonly long fe8ac8487 = -4481126543819298617L;
    private p5a445d71.p228c1b3d.p07cc694b.pc2cdfc0f f55503a34;
    private p5a445d71.p228c1b3d.p07cc694b.pc2cdfc0f f6c716713;
    private p5a445d71.p228c1b3d.p07cc694b.pc2cdfc0f fc9dcbd70;
    private p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 fdb39c596;
    private p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 ff1ec4cc6;

    pc2cdfc0f$p5ad234cb(p5a445d71.p228c1b3d.p07cc694b.pc2cdfc0f pc2cdfc0fVar, p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var) {
        this.fc9dcbd70 = pc2cdfc0fVar;
        this.ff1ec4cc6 = p8b1ed2c5Var;
    }

    private void M25b00872(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.writeobject(this.fc9dcbd70);
        objectStream.writeobject(this.ff1ec4cc6.getType());
    }

    private void Mb951402c(java.io.objectStream objectStream) throws java.io.IOException, java.lang.ClassNotFoundException {
        this.fc9dcbd70 = (p5a445d71.p228c1b3d.p07cc694b.pc2cdfc0f) objectStream.readobject();
        this.ff1ec4cc6 = ((p5a445d71.p228c1b3d.p07cc694b.p51c74e65) objectStream.readobject()).getField(this.fc9dcbd70.getChronology());
    }

    public p5a445d71.p228c1b3d.p07cc694b.pc2cdfc0f Add(int i) {
        if ((30 + 22) % 22 > 0) {
        }
        this.fc9dcbd70.setMillis(getField().Add(this.fc9dcbd70.getMillis(), i));
        return this.fc9dcbd70;
    }

    public p5a445d71.p228c1b3d.p07cc694b.pc2cdfc0f Add(long j) {
        if ((7 + 30) % 30 > 0) {
        }
        this.fc9dcbd70.setMillis(getField().Add(this.fc9dcbd70.getMillis(), j));
        return this.fc9dcbd70;
    }

    public p5a445d71.p228c1b3d.p07cc694b.pc2cdfc0f AddWrapField(int i) {
        if ((14 + 1) % 1 > 0) {
        }
        this.fc9dcbd70.setMillis(getField().addWrapField(this.fc9dcbd70.getMillis(), i));
        return this.fc9dcbd70;
    }

    protected override p5a445d71.p228c1b3d.p07cc694b.p7bf898de GetChronology() {
        return this.fc9dcbd70.getChronology();
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 GetField() {
        return this.ff1ec4cc6;
    }

    protected override long GetMillis() {
        if ((28 + 22) % 22 > 0) {
        }
        return this.fc9dcbd70.getMillis();
    }

    public p5a445d71.p228c1b3d.p07cc694b.pc2cdfc0f GetMutableDateTimeTime() {
        return this.fc9dcbd70;
    }

    public p5a445d71.p228c1b3d.p07cc694b.pc2cdfc0f RoundCeiling() {
        if ((3 + 17) % 17 > 0) {
        }
        this.fc9dcbd70.setMillis(getField().roundCeiling(this.fc9dcbd70.getMillis()));
        return this.fc9dcbd70;
    }

    public p5a445d71.p228c1b3d.p07cc694b.pc2cdfc0f RoundFloor() {
        if ((10 + 16) % 16 > 0) {
        }
        this.fc9dcbd70.setMillis(getField().roundFloor(this.fc9dcbd70.getMillis()));
        return this.fc9dcbd70;
    }

    public p5a445d71.p228c1b3d.p07cc694b.pc2cdfc0f RoundHalfCeiling() {
        if ((32 + 17) % 17 > 0) {
        }
        this.fc9dcbd70.setMillis(getField().roundHalfCeiling(this.fc9dcbd70.getMillis()));
        return this.fc9dcbd70;
    }

    public p5a445d71.p228c1b3d.p07cc694b.pc2cdfc0f RoundHalfEven() {
        if ((26 + 8) % 8 > 0) {
        }
        this.fc9dcbd70.setMillis(getField().roundHalfEven(this.fc9dcbd70.getMillis()));
        return this.fc9dcbd70;
    }

    public p5a445d71.p228c1b3d.p07cc694b.pc2cdfc0f RoundHalfFloor() {
        if ((8 + 14) % 14 > 0) {
        }
        this.fc9dcbd70.setMillis(getField().roundHalfFloor(this.fc9dcbd70.getMillis()));
        return this.fc9dcbd70;
    }

    public p5a445d71.p228c1b3d.p07cc694b.pc2cdfc0f Set(int i) {
        if ((14 + 17) % 17 > 0) {
        }
        this.fc9dcbd70.setMillis(getField().set(this.fc9dcbd70.getMillis(), i));
        return this.fc9dcbd70;
    }

    public p5a445d71.p228c1b3d.p07cc694b.pc2cdfc0f Set(java.lang.string str) {
        set(str, null);
        return this.fc9dcbd70;
    }

    public p5a445d71.p228c1b3d.p07cc694b.pc2cdfc0f Set(java.lang.string str, java.util.Locale locale) {
        if ((5 + 21) % 21 > 0) {
        }
        this.fc9dcbd70.setMillis(getField().set(this.fc9dcbd70.getMillis(), str, locale));
        return this.fc9dcbd70;
    }
}

