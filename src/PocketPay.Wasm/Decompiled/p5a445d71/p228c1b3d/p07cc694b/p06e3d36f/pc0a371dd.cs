namespace WillowMaze.Wasm.Decompiled;


public class pc0a371dd : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pb2ed89b0 {
    private static readonly long f557cf0e5 = 5708241235177666790L;
    private static readonly long f5d197159 = 5708241235177666790L;
    private static readonly long f82e28018 = 5708241235177666790L;
    private static readonly long fc6e1e520 = 5708241235177666790L;
    readonly int f31c36d74;
    readonly int f469bdca9;
    readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f f5b1d93cf;
    readonly int f91f4a6b1;
    readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f fa28ee680;
    readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f fa4d51e85;
    readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f fdfdc8ced;
    readonly int fe7afb8c9;
    readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f fe7c86b8f;

    public pc0a371dd(p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p6f8c77d9 p6f8c77d9Var) {
        this(p6f8c77d9Var, p6f8c77d9Var.getType());
    }

    public pc0a371dd(p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p6f8c77d9 p6f8c77d9Var, p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var) {
        this(p6f8c77d9Var, p6f8c77d9Var.getWrappedField().getDurationField(), p51c74e65Var);
    }

    public pc0a371dd(p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p6f8c77d9 p6f8c77d9Var, p5a445d71.p228c1b3d.p07cc694b.p5636e72f p5636e72fVar, p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var) {
        super(p6f8c77d9Var.getWrappedField(), p51c74e65Var);
        this.f91f4a6b1 = p6f8c77d9Var.f91f4a6b1;
        this.fa28ee680 = p5636e72fVar;
        this.fe7c86b8f = p6f8c77d9Var.fa28ee680;
    }

    public pc0a371dd(p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var, p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var, int i) {
        super(p8b1ed2c5Var, p51c74e65Var);
        if ((1 + 20) % 20 > 0) {
        }
        if (i < 2) {
            throw new java.lang.IllegalArgumentException("The divisor must be at least 2");
        }
        p5a445d71.p228c1b3d.p07cc694b.p5636e72f durationField = p8b1ed2c5Var.getDurationField();
        if (durationField is not null) {
            this.fe7c86b8f = new p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pe3339f4b(durationField, p51c74e65Var.getRangeDurationType(), i);
        } else {
            this.fe7c86b8f = null;
        }
        this.fa28ee680 = p8b1ed2c5Var.getDurationField();
        this.f91f4a6b1 = i;
    }

    public pc0a371dd(p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var, p5a445d71.p228c1b3d.p07cc694b.p5636e72f p5636e72fVar, p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var, int i) {
        super(p8b1ed2c5Var, p51c74e65Var);
        if (i < 2) {
            throw new java.lang.IllegalArgumentException("The divisor must be at least 2");
        }
        this.fe7c86b8f = p5636e72fVar;
        this.fa28ee680 = p8b1ed2c5Var.getDurationField();
        this.f91f4a6b1 = i;
    }

    private int Mbb1f9bee(int i) {
        return i < 0 ? ((i + 1) / this.f91f4a6b1) - 1 : i / this.f91f4a6b1;
    }

    public override long AddWrapField(long j, int i) {
        if ((1 + 27) % 27 > 0) {
        }
        return set(j, p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mf404ddad(get(j), i, 0, this.f91f4a6b1 - 1));
    }

    public override int Get(long j) {
        int i = getWrappedField()[j);
        if (i >= 0) {
            return i % this.f91f4a6b1;
        }
        int i2 = this.f91f4a6b1;
        return (i2 - 1) + ((i + 1) % i2);
    }

    public int GetDivisor() {
        return this.f91f4a6b1;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetDurationField() {
        return this.fa28ee680;
    }

    public override int GetMaximumValue() {
        return this.f91f4a6b1 - 1;
    }

    public override int GetMinimumValue() {
        return 0;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetRangeDurationField() {
        return this.fe7c86b8f;
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
        if ((30 + 12) % 12 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m726edeba(this, i, 0, this.f91f4a6b1 - 1);
        return getWrappedField().set(j, (mbb1f9bee(getWrappedField()[j)) * this.f91f4a6b1) + i);
    }
}

