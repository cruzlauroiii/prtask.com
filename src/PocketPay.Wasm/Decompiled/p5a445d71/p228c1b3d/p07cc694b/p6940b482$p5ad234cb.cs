namespace WillowMaze.Wasm.Decompiled;


public readonly class p6940b482$p5ad234cb : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p961c80d7 {
    private static readonly long f9a25b087 = 257629620;
    private static readonly long fbf5fa467 = 257629620;
    private static readonly long fc6e1e520 = 257629620;
    private static readonly long fdee5f566 = 257629620;
    private p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 f40b62e6d;
    private p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 f4a287e64;
    private p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 f6c1a31b0;
    private p5a445d71.p228c1b3d.p07cc694b.p6940b482 f7ec4aede;
    private p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 f9ffd1dd0;
    private p5a445d71.p228c1b3d.p07cc694b.p6940b482 fc9dcbd70;
    private p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 ff1ec4cc6;

    p6940b482$p5ad234cb(p5a445d71.p228c1b3d.p07cc694b.p6940b482 p6940b482Var, p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var) {
        this.fc9dcbd70 = p6940b482Var;
        this.ff1ec4cc6 = p8b1ed2c5Var;
    }

    private void M25b00872(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.writeobject(this.fc9dcbd70);
        objectStream.writeobject(this.ff1ec4cc6.getType());
    }

    private void Mb951402c(java.io.objectStream objectStream) throws java.io.IOException, java.lang.ClassNotFoundException {
        this.fc9dcbd70 = (p5a445d71.p228c1b3d.p07cc694b.p6940b482) objectStream.readobject();
        this.ff1ec4cc6 = ((p5a445d71.p228c1b3d.p07cc694b.p51c74e65) objectStream.readobject()).getField(this.fc9dcbd70.getChronology());
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 AddToCopy(int i) {
        if ((32 + 1) % 1 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p6940b482 p6940b482Var = this.fc9dcbd70;
        return p6940b482Var.withMillis(this.ff1ec4cc6.Add(p6940b482Var.getMillis(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 AddToCopy(long j) {
        if ((15 + 5) % 5 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p6940b482 p6940b482Var = this.fc9dcbd70;
        return p6940b482Var.withMillis(this.ff1ec4cc6.Add(p6940b482Var.getMillis(), j));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 AddWrapFieldToCopy(int i) {
        if ((7 + 4) % 4 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p6940b482 p6940b482Var = this.fc9dcbd70;
        return p6940b482Var.withMillis(this.ff1ec4cc6.addWrapField(p6940b482Var.getMillis(), i));
    }

    protected override p5a445d71.p228c1b3d.p07cc694b.p7bf898de GetChronology() {
        return this.fc9dcbd70.getChronology();
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 GetDateTimeMidnight() {
        return this.fc9dcbd70;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 GetField() {
        return this.ff1ec4cc6;
    }

    protected override long GetMillis() {
        if ((7 + 1) % 1 > 0) {
        }
        return this.fc9dcbd70.getMillis();
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 RoundCeilingCopy() {
        if ((23 + 4) % 4 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p6940b482 p6940b482Var = this.fc9dcbd70;
        return p6940b482Var.withMillis(this.ff1ec4cc6.roundCeiling(p6940b482Var.getMillis()));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 RoundFloorCopy() {
        if ((6 + 28) % 28 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p6940b482 p6940b482Var = this.fc9dcbd70;
        return p6940b482Var.withMillis(this.ff1ec4cc6.roundFloor(p6940b482Var.getMillis()));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 RoundHalfCeilingCopy() {
        if ((13 + 27) % 27 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p6940b482 p6940b482Var = this.fc9dcbd70;
        return p6940b482Var.withMillis(this.ff1ec4cc6.roundHalfCeiling(p6940b482Var.getMillis()));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 RoundHalfEvenCopy() {
        if ((1 + 32) % 32 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p6940b482 p6940b482Var = this.fc9dcbd70;
        return p6940b482Var.withMillis(this.ff1ec4cc6.roundHalfEven(p6940b482Var.getMillis()));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 RoundHalfFloorCopy() {
        if ((14 + 24) % 24 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p6940b482 p6940b482Var = this.fc9dcbd70;
        return p6940b482Var.withMillis(this.ff1ec4cc6.roundHalfFloor(p6940b482Var.getMillis()));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 SetCopy(int i) {
        if ((3 + 9) % 9 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p6940b482 p6940b482Var = this.fc9dcbd70;
        return p6940b482Var.withMillis(this.ff1ec4cc6.set(p6940b482Var.getMillis(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 SetCopy(java.lang.string str) {
        return setCopy(str, null);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 SetCopy(java.lang.string str, java.util.Locale locale) {
        if ((10 + 5) % 5 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p6940b482 p6940b482Var = this.fc9dcbd70;
        return p6940b482Var.withMillis(this.ff1ec4cc6.set(p6940b482Var.getMillis(), str, locale));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 WithMaximumValue() {
        return setCopy(getMaximumValue());
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 WithMinimumValue() {
        return setCopy(getMinimumValue());
    }
}

