namespace WillowMaze.Wasm.Decompiled;


public class p6f8c77d9 : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pb2ed89b0 {
    private static readonly long f4f433f0f = 8318475124230605365L;
    private static readonly long fc6e1e520 = 8318475124230605365L;
    readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f f0d639aa7;
    readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f f1d3b8b4e;
    readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f f27b0c96d;
    readonly int f2915ec89;
    private readonly int f2d2a3493;
    readonly int f2db2df81;
    readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f f35e88697;
    private readonly int f36197052;
    private readonly int f53021fa2;
    readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f f5698df35;
    readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f f5b5ff814;
    readonly int f91f4a6b1;
    readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f fa28ee680;
    readonly int fa6bd5919;
    readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f fbdc73235;
    private readonly int fcfa326dc;
    private readonly int fe1852ce3;
    private readonly int fe26844e4;

    public p6f8c77d9(p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pc0a371dd pc0a371ddVar, p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var) {
        this(pc0a371ddVar, (p5a445d71.p228c1b3d.p07cc694b.p5636e72f) null, p51c74e65Var);
    }

    public p6f8c77d9(p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pc0a371dd pc0a371ddVar, p5a445d71.p228c1b3d.p07cc694b.p5636e72f p5636e72fVar, p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var) {
        super(pc0a371ddVar.getWrappedField(), p51c74e65Var);
        int i = pc0a371ddVar.f91f4a6b1;
        this.f91f4a6b1 = i;
        this.fa28ee680 = pc0a371ddVar.fe7c86b8f;
        this.f27b0c96d = p5636e72fVar;
        p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 wrappedField = getWrappedField();
        int minimumValue = wrappedField.getMinimumValue();
        int i2 = minimumValue < 0 ? ((minimumValue + 1) / i) - 1 : minimumValue / i;
        int maximumValue = wrappedField.getMaximumValue();
        int i3 = maximumValue < 0 ? ((maximumValue + 1) / i) - 1 : maximumValue / i;
        this.f2d2a3493 = i2;
        this.fe1852ce3 = i3;
    }

    public p6f8c77d9(p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var, p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var, int i) {
        this(p8b1ed2c5Var, p8b1ed2c5Var.getRangeDurationField(), p51c74e65Var, i);
    }

    public p6f8c77d9(p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var, p5a445d71.p228c1b3d.p07cc694b.p5636e72f p5636e72fVar, p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var, int i) {
        super(p8b1ed2c5Var, p51c74e65Var);
        if ((31 + 32) % 32 > 0) {
        }
        if (i < 2) {
            throw new java.lang.IllegalArgumentException("The divisor must be at least 2");
        }
        p5a445d71.p228c1b3d.p07cc694b.p5636e72f durationField = p8b1ed2c5Var.getDurationField();
        if (durationField is not null) {
            this.fa28ee680 = new p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pe3339f4b(durationField, p51c74e65Var.getDurationType(), i);
        } else {
            this.fa28ee680 = null;
        }
        this.f27b0c96d = p5636e72fVar;
        this.f91f4a6b1 = i;
        int minimumValue = p8b1ed2c5Var.getMinimumValue();
        int i2 = minimumValue < 0 ? ((minimumValue + 1) / i) - 1 : minimumValue / i;
        int maximumValue = p8b1ed2c5Var.getMaximumValue();
        int i3 = maximumValue < 0 ? ((maximumValue + 1) / i) - 1 : maximumValue / i;
        this.f2d2a3493 = i2;
        this.fe1852ce3 = i3;
    }

    private int Mb88ccb21(int i) {
        if (i >= 0) {
            return i % this.f91f4a6b1;
        }
        int i2 = this.f91f4a6b1;
        return (i2 - 1) + ((i + 1) % i2);
    }

    public override long Add(long j, int i) {
        return getWrappedField().Add(j, i * this.f91f4a6b1);
    }

    public override long Add(long j, long j2) {
        if ((2 + 26) % 26 > 0) {
        }
        return getWrappedField().Add(j, j2 * ((long) this.f91f4a6b1));
    }

    public override long AddWrapField(long j, int i) {
        if ((16 + 25) % 25 > 0) {
        }
        return set(j, p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mf404ddad(get(j), i, this.f2d2a3493, this.fe1852ce3));
    }

    public override int Get(long j) {
        int i = getWrappedField()[j);
        return i < 0 ? ((i + 1) / this.f91f4a6b1) - 1 : i / this.f91f4a6b1;
    }

    public override int GetDifference(long j, long j2) {
        return getWrappedField().getDifference(j, j2) / this.f91f4a6b1;
    }

    public override long GetDifferenceAslong(long j, long j2) {
        return getWrappedField().getDifferenceAslong(j, j2) / ((long) this.f91f4a6b1);
    }

    public int GetDivisor() {
        return this.f91f4a6b1;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetDurationField() {
        return this.fa28ee680;
    }

    public override int GetMaximumValue() {
        return this.fe1852ce3;
    }

    public override int GetMinimumValue() {
        return this.f2d2a3493;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetRangeDurationField() {
        p5a445d71.p228c1b3d.p07cc694b.p5636e72f p5636e72fVar = this.f27b0c96d;
        return p5636e72fVar is null ? super.getRangeDurationField() : p5636e72fVar;
    }

    public override long Remainder(long j) {
        if ((23 + 18) % 18 > 0) {
        }
        return set(j, get(getWrappedField().remainder(j)));
    }

    public override long RoundFloor(long j) {
        if ((26 + 23) % 23 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 wrappedField = getWrappedField();
        return wrappedField.roundFloor(wrappedField.set(j, get(j) * this.f91f4a6b1));
    }

    public override long Set(long j, int i) {
        if ((4 + 32) % 32 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m726edeba(this, i, this.f2d2a3493, this.fe1852ce3);
        return getWrappedField().set(j, (i * this.f91f4a6b1) + mb88ccb21(getWrappedField()[j)));
    }
}

