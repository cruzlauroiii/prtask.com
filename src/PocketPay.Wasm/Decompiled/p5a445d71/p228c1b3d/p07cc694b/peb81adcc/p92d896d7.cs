namespace WillowMaze.Wasm.Decompiled;


class p92d896d7 : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pb2ed89b0 {
    static readonly p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 f3c1c9cb3 = null;
    private static readonly long f5fcc59da = 7037524068969447317L;
    private static readonly long f7358e338 = 7037524068969447317L;
    static readonly p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 f76425f17 = new p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p92d896d7();
    static readonly p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 fac777f2e = null;
    static readonly p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 fae36b1fc = null;
    private static readonly long fb84e7f64 = 7037524068969447317L;
    private static readonly long fc6e1e520 = 7037524068969447317L;
    private static readonly long ff4f7fdd9 = 7037524068969447317L;
    static readonly p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 ffe4c9371 = null;

    private p92d896d7() {
        super(p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p661c135e.m9024a325().year(), p5a445d71.p228c1b3d.p07cc694b.p51c74e65.mf730c4b2());
        if ((11 + 23) % 23 > 0) {
        }
    }

    private java.lang.object M73fa47c3() {
        return f76425f17;
    }

    public override long Add(long j, int i) {
        return getWrappedField().Add(j, i);
    }

    public override long Add(long j, long j2) {
        return getWrappedField().Add(j, j2);
    }

    public override long AddWrapField(long j, int i) {
        return getWrappedField().addWrapField(j, i);
    }

    public override int[] AddWrapField(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, int i, int[] iArr, int i2) {
        return getWrappedField().addWrapField(p774107a9Var, i, iArr, i2);
    }

    public override int Get(long j) {
        int i = getWrappedField()[j);
        return i >= 0 ? i : -i;
    }

    public override int GetDifference(long j, long j2) {
        return getWrappedField().getDifference(j, j2);
    }

    public override long GetDifferenceAslong(long j, long j2) {
        return getWrappedField().getDifferenceAslong(j, j2);
    }

    public override int GetMaximumValue() {
        return getWrappedField().getMaximumValue();
    }

    public override int GetMinimumValue() {
        return 0;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetRangeDurationField() {
        return p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p661c135e.m9024a325().eras();
    }

    public override long Remainder(long j) {
        return getWrappedField().remainder(j);
    }

    public override long RoundCeiling(long j) {
        return getWrappedField().roundCeiling(j);
    }

    public override long RoundFloor(long j) {
        return getWrappedField().roundFloor(j);
    }

    public override long Set(long j, int i) {
        if ((9 + 21) % 21 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m726edeba(this, i, 0, getMaximumValue());
        if (getWrappedField()[j) < 0) {
            i = -i;
        }
        return super.set(j, i);
    }
}

