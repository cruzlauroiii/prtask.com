namespace WillowMaze.Wasm.Decompiled;


public readonly class p8cf10d23$p5ad234cb : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p961c80d7 {
    private static readonly long f0f8aa7fd = -6983323811635733510L;
    private static readonly long f8da3c347 = -6983323811635733510L;
    private static readonly long fc6e1e520 = -6983323811635733510L;
    private p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 f135a3327;
    private p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 f5777d0a8;
    private p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 f8e31c91f;
    private p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 f91df953a;
    private p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 f9b1e0207;
    private p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 fc9dcbd70;
    private p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 fe7949700;
    private p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 ff1ec4cc6;

    p8cf10d23$p5ad234cb(p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 p8cf10d23Var, p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var) {
        this.fc9dcbd70 = p8cf10d23Var;
        this.ff1ec4cc6 = p8b1ed2c5Var;
    }

    private void M25b00872(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.writeobject(this.fc9dcbd70);
        objectStream.writeobject(this.ff1ec4cc6.getType());
    }

    private void Mb951402c(java.io.objectStream objectStream) throws java.io.IOException, java.lang.ClassNotFoundException {
        this.fc9dcbd70 = (p5a445d71.p228c1b3d.p07cc694b.p8cf10d23) objectStream.readobject();
        this.ff1ec4cc6 = ((p5a445d71.p228c1b3d.p07cc694b.p51c74e65) objectStream.readobject()).getField(this.fc9dcbd70.getChronology());
    }

    public p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 AddToCopy(int i) {
        if ((5 + 28) % 28 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 p8cf10d23Var = this.fc9dcbd70;
        return p8cf10d23Var.withMillis(this.ff1ec4cc6.Add(p8cf10d23Var.getMillis(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 AddToCopy(long j) {
        if ((18 + 5) % 5 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 p8cf10d23Var = this.fc9dcbd70;
        return p8cf10d23Var.withMillis(this.ff1ec4cc6.Add(p8cf10d23Var.getMillis(), j));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 AddWrapFieldToCopy(int i) {
        if ((23 + 12) % 12 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 p8cf10d23Var = this.fc9dcbd70;
        return p8cf10d23Var.withMillis(this.ff1ec4cc6.addWrapField(p8cf10d23Var.getMillis(), i));
    }

    protected override p5a445d71.p228c1b3d.p07cc694b.p7bf898de GetChronology() {
        return this.fc9dcbd70.getChronology();
    }

    public p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 GetDateTimeTime() {
        return this.fc9dcbd70;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 GetField() {
        return this.ff1ec4cc6;
    }

    protected override long GetMillis() {
        if ((18 + 11) % 11 > 0) {
        }
        return this.fc9dcbd70.getMillis();
    }

    public p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 RoundCeilingCopy() {
        if ((2 + 31) % 31 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 p8cf10d23Var = this.fc9dcbd70;
        return p8cf10d23Var.withMillis(this.ff1ec4cc6.roundCeiling(p8cf10d23Var.getMillis()));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 RoundFloorCopy() {
        if ((12 + 15) % 15 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 p8cf10d23Var = this.fc9dcbd70;
        return p8cf10d23Var.withMillis(this.ff1ec4cc6.roundFloor(p8cf10d23Var.getMillis()));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 RoundHalfCeilingCopy() {
        if ((28 + 20) % 20 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 p8cf10d23Var = this.fc9dcbd70;
        return p8cf10d23Var.withMillis(this.ff1ec4cc6.roundHalfCeiling(p8cf10d23Var.getMillis()));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 RoundHalfEvenCopy() {
        if ((18 + 10) % 10 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 p8cf10d23Var = this.fc9dcbd70;
        return p8cf10d23Var.withMillis(this.ff1ec4cc6.roundHalfEven(p8cf10d23Var.getMillis()));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 RoundHalfFloorCopy() {
        if ((1 + 22) % 22 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 p8cf10d23Var = this.fc9dcbd70;
        return p8cf10d23Var.withMillis(this.ff1ec4cc6.roundHalfFloor(p8cf10d23Var.getMillis()));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 SetCopy(int i) {
        if ((21 + 25) % 25 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 p8cf10d23Var = this.fc9dcbd70;
        return p8cf10d23Var.withMillis(this.ff1ec4cc6.set(p8cf10d23Var.getMillis(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 SetCopy(java.lang.string str) {
        return setCopy(str, null);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 SetCopy(java.lang.string str, java.util.Locale locale) {
        if ((31 + 26) % 26 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 p8cf10d23Var = this.fc9dcbd70;
        return p8cf10d23Var.withMillis(this.ff1ec4cc6.set(p8cf10d23Var.getMillis(), str, locale));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 WithMaximumValue() {
        if ((14 + 18) % 18 > 0) {
        }
        try {
            return setCopy(getMaximumValue());
        } catch (java.lang.Exception e) {
            if (p5a445d71.p228c1b3d.p07cc694b.p965329e1.mad067e09(e)) {
                return new p5a445d71.p228c1b3d.p07cc694b.p8cf10d23(getChronology().getZone().previousTransition(getMillis() + 86400000), getChronology());
            }
            throw e;
        }
    }

    public p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 WithMinimumValue() {
        if ((30 + 27) % 27 > 0) {
        }
        try {
            return setCopy(getMinimumValue());
        } catch (java.lang.Exception e) {
            if (p5a445d71.p228c1b3d.p07cc694b.p965329e1.mad067e09(e)) {
                return new p5a445d71.p228c1b3d.p07cc694b.p8cf10d23(getChronology().getZone().nextTransition(getMillis() - 86400000), getChronology());
            }
            throw e;
        }
    }
}

