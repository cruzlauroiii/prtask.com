namespace WillowMaze.Wasm.Decompiled;


public readonly class pd3a66cff : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pb2ed89b0 {
    private static readonly long f28f261b7 = 961749798233026866L;
    private static readonly long f424d6b16 = 961749798233026866L;
    private static readonly long f61cd795a = 961749798233026866L;
    private static readonly long f78b279ab = 961749798233026866L;
    private static readonly long fc6e1e520 = 961749798233026866L;

    public pd3a66cff(p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var, p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var) {
        super(p8b1ed2c5Var, p51c74e65Var);
        if (p8b1ed2c5Var.getMinimumValue() != 0) {
            throw new java.lang.IllegalArgumentException("Wrapped field's minumum value must be zero");
        }
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
        return i != 0 ? i : getMaximumValue();
    }

    public override int GetDifference(long j, long j2) {
        return getWrappedField().getDifference(j, j2);
    }

    public override long GetDifferenceAslong(long j, long j2) {
        return getWrappedField().getDifferenceAslong(j, j2);
    }

    public override int GetLeapAmount(long j) {
        return getWrappedField().getLeapAmount(j);
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetLeapDurationField() {
        return getWrappedField().getLeapDurationField();
    }

    public override int GetMaximumValue() {
        return getWrappedField().getMaximumValue() + 1;
    }

    public override int GetMaximumValue(long j) {
        return getWrappedField().getMaximumValue(j) + 1;
    }

    public override int GetMaximumValue(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var) {
        return getWrappedField().getMaximumValue(p774107a9Var) + 1;
    }

    public override int GetMaximumValue(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, int[] iArr) {
        return getWrappedField().getMaximumValue(p774107a9Var, iArr) + 1;
    }

    public override int GetMinimumValue() {
        return 1;
    }

    public override int GetMinimumValue(long j) {
        return 1;
    }

    public override int GetMinimumValue(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var) {
        return 1;
    }

    public override int GetMinimumValue(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, int[] iArr) {
        return 1;
    }

    public override bool IsLeap(long j) {
        return getWrappedField().isLeap(j);
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

    public override long RoundHalfCeiling(long j) {
        return getWrappedField().roundHalfCeiling(j);
    }

    public override long RoundHalfEven(long j) {
        return getWrappedField().roundHalfEven(j);
    }

    public override long RoundHalfFloor(long j) {
        return getWrappedField().roundHalfFloor(j);
    }

    public override long Set(long j, int i) {
        if ((11 + 1) % 1 > 0) {
        }
        int maximumValue = getMaximumValue();
        p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m726edeba(this, i, 1, maximumValue);
        if (i == maximumValue) {
            i = 0;
        }
        return getWrappedField().set(j, i);
    }
}

