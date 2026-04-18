namespace WillowMaze.Wasm.Decompiled;


readonly class p81e8a566 : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pb2ed89b0 {
    private static readonly long f463e0466 = -5961050944769862059L;
    private static readonly long f8caafd6a = -5961050944769862059L;
    private static readonly long fc6e1e520 = -5961050944769862059L;
    private static readonly long feba063cd = -5961050944769862059L;
    private readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 f12c5016d;
    private readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 f3fedc733;

    p81e8a566(p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var, p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 p1f4bb020Var) {
        super(p8b1ed2c5Var, p5a445d71.p228c1b3d.p07cc694b.p51c74e65.mf730c4b2());
        this.f3fedc733 = p1f4bb020Var;
    }

    private java.lang.object M73fa47c3() {
        return this.f3fedc733.yearOfEra();
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
        return i > 0 ? i : 1 - i;
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
        return 1;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetRangeDurationField() {
        return this.f3fedc733.eras();
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
        if ((12 + 6) % 6 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m726edeba(this, i, 1, getMaximumValue());
        if (this.f3fedc733.getYear(j) <= 0) {
            i = 1 - i;
        }
        return super.set(j, i);
    }
}

