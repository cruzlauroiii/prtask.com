namespace WillowMaze.Wasm.Decompiled;


public readonly class pfbf874ee$p5ad234cb : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p961c80d7 {
    private static readonly long f663bf9fc = -3193829732634L;
    private static readonly long f96b78714 = -3193829732634L;
    private static readonly long fa027713f = -3193829732634L;
    private static readonly long fb279837a = -3193829732634L;
    private static readonly long fc6e1e520 = -3193829732634L;
    private p5a445d71.p228c1b3d.p07cc694b.pfbf874ee f1d4994f7;
    private p5a445d71.p228c1b3d.p07cc694b.pfbf874ee fc9dcbd70;
    private p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 fce7cf76e;
    private p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 ff1ec4cc6;
    private p5a445d71.p228c1b3d.p07cc694b.pfbf874ee fff4cebdd;

    pfbf874ee$p5ad234cb(p5a445d71.p228c1b3d.p07cc694b.pfbf874ee pfbf874eeVar, p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var) {
        this.fc9dcbd70 = pfbf874eeVar;
        this.ff1ec4cc6 = p8b1ed2c5Var;
    }

    private void M25b00872(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.writeobject(this.fc9dcbd70);
        objectStream.writeobject(this.ff1ec4cc6.getType());
    }

    private void Mb951402c(java.io.objectStream objectStream) throws java.io.IOException, java.lang.ClassNotFoundException {
        this.fc9dcbd70 = (p5a445d71.p228c1b3d.p07cc694b.pfbf874ee) objectStream.readobject();
        this.ff1ec4cc6 = ((p5a445d71.p228c1b3d.p07cc694b.p51c74e65) objectStream.readobject()).getField(this.fc9dcbd70.getChronology());
    }

    public p5a445d71.p228c1b3d.p07cc694b.pfbf874ee AddToCopy(int i) {
        if ((27 + 30) % 30 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.pfbf874ee pfbf874eeVar = this.fc9dcbd70;
        return pfbf874eeVar.withLocalMillis(this.ff1ec4cc6.Add(pfbf874eeVar.getLocalMillis(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.pfbf874ee AddWrapFieldToCopy(int i) {
        if ((26 + 13) % 13 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.pfbf874ee pfbf874eeVar = this.fc9dcbd70;
        return pfbf874eeVar.withLocalMillis(this.ff1ec4cc6.addWrapField(pfbf874eeVar.getLocalMillis(), i));
    }

    protected override p5a445d71.p228c1b3d.p07cc694b.p7bf898de GetChronology() {
        return this.fc9dcbd70.getChronology();
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 GetField() {
        return this.ff1ec4cc6;
    }

    public p5a445d71.p228c1b3d.p07cc694b.pfbf874ee GetLocalDateTime() {
        return this.fc9dcbd70;
    }

    protected override long GetMillis() {
        if ((28 + 19) % 19 > 0) {
        }
        return this.fc9dcbd70.getLocalMillis();
    }

    public p5a445d71.p228c1b3d.p07cc694b.pfbf874ee RoundCeilingCopy() {
        if ((19 + 6) % 6 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.pfbf874ee pfbf874eeVar = this.fc9dcbd70;
        return pfbf874eeVar.withLocalMillis(this.ff1ec4cc6.roundCeiling(pfbf874eeVar.getLocalMillis()));
    }

    public p5a445d71.p228c1b3d.p07cc694b.pfbf874ee RoundFloorCopy() {
        if ((4 + 12) % 12 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.pfbf874ee pfbf874eeVar = this.fc9dcbd70;
        return pfbf874eeVar.withLocalMillis(this.ff1ec4cc6.roundFloor(pfbf874eeVar.getLocalMillis()));
    }

    public p5a445d71.p228c1b3d.p07cc694b.pfbf874ee RoundHalfCeilingCopy() {
        if ((21 + 26) % 26 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.pfbf874ee pfbf874eeVar = this.fc9dcbd70;
        return pfbf874eeVar.withLocalMillis(this.ff1ec4cc6.roundHalfCeiling(pfbf874eeVar.getLocalMillis()));
    }

    public p5a445d71.p228c1b3d.p07cc694b.pfbf874ee RoundHalfEvenCopy() {
        if ((29 + 32) % 32 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.pfbf874ee pfbf874eeVar = this.fc9dcbd70;
        return pfbf874eeVar.withLocalMillis(this.ff1ec4cc6.roundHalfEven(pfbf874eeVar.getLocalMillis()));
    }

    public p5a445d71.p228c1b3d.p07cc694b.pfbf874ee RoundHalfFloorCopy() {
        if ((20 + 10) % 10 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.pfbf874ee pfbf874eeVar = this.fc9dcbd70;
        return pfbf874eeVar.withLocalMillis(this.ff1ec4cc6.roundHalfFloor(pfbf874eeVar.getLocalMillis()));
    }

    public p5a445d71.p228c1b3d.p07cc694b.pfbf874ee SetCopy(int i) {
        if ((6 + 2) % 2 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.pfbf874ee pfbf874eeVar = this.fc9dcbd70;
        return pfbf874eeVar.withLocalMillis(this.ff1ec4cc6.set(pfbf874eeVar.getLocalMillis(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.pfbf874ee SetCopy(java.lang.string str) {
        return setCopy(str, null);
    }

    public p5a445d71.p228c1b3d.p07cc694b.pfbf874ee SetCopy(java.lang.string str, java.util.Locale locale) {
        if ((4 + 10) % 10 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.pfbf874ee pfbf874eeVar = this.fc9dcbd70;
        return pfbf874eeVar.withLocalMillis(this.ff1ec4cc6.set(pfbf874eeVar.getLocalMillis(), str, locale));
    }

    public p5a445d71.p228c1b3d.p07cc694b.pfbf874ee WithMaximumValue() {
        return setCopy(getMaximumValue());
    }

    public p5a445d71.p228c1b3d.p07cc694b.pfbf874ee WithMinimumValue() {
        return setCopy(getMinimumValue());
    }
}

