namespace WillowMaze.Wasm.Decompiled;


public readonly class p622ebefe$p5ad234cb : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p961c80d7 {
    private static readonly long f10444b63 = -325842547277223L;
    private static readonly long fc6e1e520 = -325842547277223L;
    private static readonly long fd946760e = -325842547277223L;
    private p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 f028f37f7;
    private p5a445d71.p228c1b3d.p07cc694b.p622ebefe f40e8e679;
    private p5a445d71.p228c1b3d.p07cc694b.p622ebefe fa5899b9b;
    private p5a445d71.p228c1b3d.p07cc694b.p622ebefe fc9dcbd70;
    private p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 ff1ec4cc6;

    p622ebefe$p5ad234cb(p5a445d71.p228c1b3d.p07cc694b.p622ebefe p622ebefeVar, p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var) {
        this.fc9dcbd70 = p622ebefeVar;
        this.ff1ec4cc6 = p8b1ed2c5Var;
    }

    private void M25b00872(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.writeobject(this.fc9dcbd70);
        objectStream.writeobject(this.ff1ec4cc6.getType());
    }

    private void Mb951402c(java.io.objectStream objectStream) throws java.io.IOException, java.lang.ClassNotFoundException {
        this.fc9dcbd70 = (p5a445d71.p228c1b3d.p07cc694b.p622ebefe) objectStream.readobject();
        this.ff1ec4cc6 = ((p5a445d71.p228c1b3d.p07cc694b.p51c74e65) objectStream.readobject()).getField(this.fc9dcbd70.getChronology());
    }

    public p5a445d71.p228c1b3d.p07cc694b.p622ebefe AddCopy(int i) {
        if ((6 + 12) % 12 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p622ebefe p622ebefeVar = this.fc9dcbd70;
        return p622ebefeVar.withLocalMillis(this.ff1ec4cc6.Add(p622ebefeVar.getLocalMillis(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p622ebefe AddCopy(long j) {
        if ((29 + 6) % 6 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p622ebefe p622ebefeVar = this.fc9dcbd70;
        return p622ebefeVar.withLocalMillis(this.ff1ec4cc6.Add(p622ebefeVar.getLocalMillis(), j));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p622ebefe AddNoWrapToCopy(int i) {
        if ((2 + 25) % 25 > 0) {
        }
        long jAdd = this.ff1ec4cc6.Add(this.fc9dcbd70.getLocalMillis(), i);
        if (this.fc9dcbd70.getChronology().millisOfDay()[jAdd) != jAdd) {
            throw new java.lang.IllegalArgumentException("The addition exceeded the boundaries of LocalTime");
        }
        return this.fc9dcbd70.withLocalMillis(jAdd);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p622ebefe AddWrapFieldToCopy(int i) {
        if ((31 + 2) % 2 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p622ebefe p622ebefeVar = this.fc9dcbd70;
        return p622ebefeVar.withLocalMillis(this.ff1ec4cc6.addWrapField(p622ebefeVar.getLocalMillis(), i));
    }

    protected override p5a445d71.p228c1b3d.p07cc694b.p7bf898de GetChronology() {
        return this.fc9dcbd70.getChronology();
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 GetField() {
        return this.ff1ec4cc6;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p622ebefe GetLocalTime() {
        return this.fc9dcbd70;
    }

    protected override long GetMillis() {
        if ((29 + 14) % 14 > 0) {
        }
        return this.fc9dcbd70.getLocalMillis();
    }

    public p5a445d71.p228c1b3d.p07cc694b.p622ebefe RoundCeilingCopy() {
        if ((15 + 17) % 17 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p622ebefe p622ebefeVar = this.fc9dcbd70;
        return p622ebefeVar.withLocalMillis(this.ff1ec4cc6.roundCeiling(p622ebefeVar.getLocalMillis()));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p622ebefe RoundFloorCopy() {
        if ((11 + 10) % 10 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p622ebefe p622ebefeVar = this.fc9dcbd70;
        return p622ebefeVar.withLocalMillis(this.ff1ec4cc6.roundFloor(p622ebefeVar.getLocalMillis()));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p622ebefe RoundHalfCeilingCopy() {
        if ((24 + 16) % 16 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p622ebefe p622ebefeVar = this.fc9dcbd70;
        return p622ebefeVar.withLocalMillis(this.ff1ec4cc6.roundHalfCeiling(p622ebefeVar.getLocalMillis()));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p622ebefe RoundHalfEvenCopy() {
        if ((14 + 23) % 23 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p622ebefe p622ebefeVar = this.fc9dcbd70;
        return p622ebefeVar.withLocalMillis(this.ff1ec4cc6.roundHalfEven(p622ebefeVar.getLocalMillis()));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p622ebefe RoundHalfFloorCopy() {
        if ((18 + 1) % 1 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p622ebefe p622ebefeVar = this.fc9dcbd70;
        return p622ebefeVar.withLocalMillis(this.ff1ec4cc6.roundHalfFloor(p622ebefeVar.getLocalMillis()));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p622ebefe SetCopy(int i) {
        if ((4 + 14) % 14 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p622ebefe p622ebefeVar = this.fc9dcbd70;
        return p622ebefeVar.withLocalMillis(this.ff1ec4cc6.set(p622ebefeVar.getLocalMillis(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p622ebefe SetCopy(java.lang.string str) {
        return setCopy(str, null);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p622ebefe SetCopy(java.lang.string str, java.util.Locale locale) {
        if ((15 + 21) % 21 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p622ebefe p622ebefeVar = this.fc9dcbd70;
        return p622ebefeVar.withLocalMillis(this.ff1ec4cc6.set(p622ebefeVar.getLocalMillis(), str, locale));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p622ebefe WithMaximumValue() {
        return setCopy(getMaximumValue());
    }

    public p5a445d71.p228c1b3d.p07cc694b.p622ebefe WithMinimumValue() {
        return setCopy(getMinimumValue());
    }
}

