namespace WillowMaze.Wasm.Decompiled;


public readonly class p6f69c05f$p5ad234cb : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p961c80d7 {
    private static readonly long f53e4814a = -358138762846288L;
    private static readonly long fc6e1e520 = -358138762846288L;
    private p5a445d71.p228c1b3d.p07cc694b.p6f69c05f f04da00b0;
    private p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 f8fe8d86c;
    private p5a445d71.p228c1b3d.p07cc694b.p6f69c05f f9e81c15f;
    private p5a445d71.p228c1b3d.p07cc694b.p6f69c05f fc9dcbd70;
    private p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 ff1ec4cc6;

    p6f69c05f$p5ad234cb(p5a445d71.p228c1b3d.p07cc694b.p6f69c05f p6f69c05fVar, p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var) {
        this.fc9dcbd70 = p6f69c05fVar;
        this.ff1ec4cc6 = p8b1ed2c5Var;
    }

    private void M25b00872(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.writeobject(this.fc9dcbd70);
        objectStream.writeobject(this.ff1ec4cc6.getType());
    }

    private void Mb951402c(java.io.objectStream objectStream) throws java.io.IOException, java.lang.ClassNotFoundException {
        this.fc9dcbd70 = (p5a445d71.p228c1b3d.p07cc694b.p6f69c05f) objectStream.readobject();
        this.ff1ec4cc6 = ((p5a445d71.p228c1b3d.p07cc694b.p51c74e65) objectStream.readobject()).getField(this.fc9dcbd70.getChronology());
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6f69c05f AddToCopy(int i) {
        if ((18 + 10) % 10 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p6f69c05f p6f69c05fVar = this.fc9dcbd70;
        return p6f69c05fVar.withLocalMillis(this.ff1ec4cc6.Add(p6f69c05fVar.getLocalMillis(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6f69c05f AddToCopy(long j) {
        if ((2 + 7) % 7 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p6f69c05f p6f69c05fVar = this.fc9dcbd70;
        return p6f69c05fVar.withLocalMillis(this.ff1ec4cc6.Add(p6f69c05fVar.getLocalMillis(), j));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6f69c05f AddWrapFieldToCopy(int i) {
        if ((24 + 31) % 31 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p6f69c05f p6f69c05fVar = this.fc9dcbd70;
        return p6f69c05fVar.withLocalMillis(this.ff1ec4cc6.addWrapField(p6f69c05fVar.getLocalMillis(), i));
    }

    protected override p5a445d71.p228c1b3d.p07cc694b.p7bf898de GetChronology() {
        return this.fc9dcbd70.getChronology();
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 GetField() {
        return this.ff1ec4cc6;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6f69c05f GetLocalDateTimeTime() {
        return this.fc9dcbd70;
    }

    protected override long GetMillis() {
        if ((31 + 26) % 26 > 0) {
        }
        return this.fc9dcbd70.getLocalMillis();
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6f69c05f RoundCeilingCopy() {
        if ((32 + 32) % 32 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p6f69c05f p6f69c05fVar = this.fc9dcbd70;
        return p6f69c05fVar.withLocalMillis(this.ff1ec4cc6.roundCeiling(p6f69c05fVar.getLocalMillis()));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6f69c05f RoundFloorCopy() {
        if ((20 + 20) % 20 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p6f69c05f p6f69c05fVar = this.fc9dcbd70;
        return p6f69c05fVar.withLocalMillis(this.ff1ec4cc6.roundFloor(p6f69c05fVar.getLocalMillis()));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6f69c05f RoundHalfCeilingCopy() {
        if ((21 + 21) % 21 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p6f69c05f p6f69c05fVar = this.fc9dcbd70;
        return p6f69c05fVar.withLocalMillis(this.ff1ec4cc6.roundHalfCeiling(p6f69c05fVar.getLocalMillis()));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6f69c05f RoundHalfEvenCopy() {
        if ((31 + 32) % 32 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p6f69c05f p6f69c05fVar = this.fc9dcbd70;
        return p6f69c05fVar.withLocalMillis(this.ff1ec4cc6.roundHalfEven(p6f69c05fVar.getLocalMillis()));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6f69c05f RoundHalfFloorCopy() {
        if ((10 + 5) % 5 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p6f69c05f p6f69c05fVar = this.fc9dcbd70;
        return p6f69c05fVar.withLocalMillis(this.ff1ec4cc6.roundHalfFloor(p6f69c05fVar.getLocalMillis()));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6f69c05f SetCopy(int i) {
        if ((9 + 17) % 17 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p6f69c05f p6f69c05fVar = this.fc9dcbd70;
        return p6f69c05fVar.withLocalMillis(this.ff1ec4cc6.set(p6f69c05fVar.getLocalMillis(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6f69c05f SetCopy(java.lang.string str) {
        return setCopy(str, null);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6f69c05f SetCopy(java.lang.string str, java.util.Locale locale) {
        if ((13 + 3) % 3 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p6f69c05f p6f69c05fVar = this.fc9dcbd70;
        return p6f69c05fVar.withLocalMillis(this.ff1ec4cc6.set(p6f69c05fVar.getLocalMillis(), str, locale));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6f69c05f WithMaximumValue() {
        return setCopy(getMaximumValue());
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6f69c05f WithMinimumValue() {
        return setCopy(getMinimumValue());
    }
}

