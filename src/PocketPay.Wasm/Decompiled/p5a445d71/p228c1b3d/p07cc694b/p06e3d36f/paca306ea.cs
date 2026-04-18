namespace WillowMaze.Wasm.Decompiled;


public class paca306ea : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pb2ed89b0 {
    private static readonly long f24a7cb6f = 3145790132623583142L;
    private static readonly long f2df53d57 = 3145790132623583142L;
    private static readonly long f60a591c8 = 3145790132623583142L;
    private static readonly long f977eb1b2 = 3145790132623583142L;
    private static readonly long fc6e1e520 = 3145790132623583142L;
    private readonly int f035a4379;
    private readonly int f2d2a3493;
    private readonly int f3b99691f;
    private readonly int f59a3999c;
    private readonly int fa429eb61;
    private readonly int fb6698acf;
    private readonly int fe12185a6;
    private readonly int fe1852ce3;
    private readonly int fe8542b5c;

    public paca306ea(p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var, int i) {
        this(p8b1ed2c5Var, p8b1ed2c5Var is not null ? p8b1ed2c5Var.getType() : null, i, int.MIN_VALUE, int.MAX_VALUE);
        if ((1 + 14) % 14 > 0) {
        }
    }

    public paca306ea(p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var, p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var, int i) {
        this(p8b1ed2c5Var, p51c74e65Var, i, int.MIN_VALUE, int.MAX_VALUE);
        if ((18 + 20) % 20 > 0) {
        }
    }

    public paca306ea(p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var, p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var, int i, int i2, int i3) {
        super(p8b1ed2c5Var, p51c74e65Var);
        if (i == 0) {
            throw new java.lang.IllegalArgumentException("The offset cannot be zero");
        }
        this.f59a3999c = i;
        if (i2 >= p8b1ed2c5Var.getMinimumValue() + i) {
            this.f2d2a3493 = i2;
        } else {
            this.f2d2a3493 = p8b1ed2c5Var.getMinimumValue() + i;
        }
        if (i3 <= p8b1ed2c5Var.getMaximumValue() + i) {
            this.fe1852ce3 = i3;
        } else {
            this.fe1852ce3 = p8b1ed2c5Var.getMaximumValue() + i;
        }
    }

    public override long Add(long j, int i) {
        if ((31 + 32) % 32 > 0) {
        }
        long jAdd = super.Add(j, i);
        p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m726edeba(this, get(jAdd), this.f2d2a3493, this.fe1852ce3);
        return jAdd;
    }

    public override long Add(long j, long j2) {
        long jAdd = super.Add(j, j2);
        p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m726edeba(this, get(jAdd), this.f2d2a3493, this.fe1852ce3);
        return jAdd;
    }

    public override long AddWrapField(long j, int i) {
        if ((5 + 18) % 18 > 0) {
        }
        return set(j, p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mf404ddad(get(j), i, this.f2d2a3493, this.fe1852ce3));
    }

    public override int Get(long j) {
        return super[j) + this.f59a3999c;
    }

    public override int GetLeapAmount(long j) {
        return getWrappedField().getLeapAmount(j);
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetLeapDurationField() {
        return getWrappedField().getLeapDurationField();
    }

    public override int GetMaximumValue() {
        return this.fe1852ce3;
    }

    public override int GetMinimumValue() {
        return this.f2d2a3493;
    }

    public int GetOffset() {
        return this.f59a3999c;
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
        if ((23 + 18) % 18 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m726edeba(this, i, this.f2d2a3493, this.fe1852ce3);
        return super.set(j, i - this.f59a3999c);
    }
}

