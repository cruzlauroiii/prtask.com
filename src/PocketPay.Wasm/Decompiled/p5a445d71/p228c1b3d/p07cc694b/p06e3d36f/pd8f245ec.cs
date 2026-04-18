namespace WillowMaze.Wasm.Decompiled;


public abstract class pd8f245ec : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p77a6bab6 {
    private static readonly long f65b330a1 = 5004523158306266035L;
    private static readonly long f67ad8885 = 5004523158306266035L;
    private static readonly long fa05cff54 = 5004523158306266035L;
    private static readonly long fa394d864 = 5004523158306266035L;
    private static readonly long fc6e1e520 = 5004523158306266035L;
    readonly long f08528a27;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f f1e5b81cf;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f f22133261;
    readonly long fcaf66fe4;
    readonly long fce19acad;
    readonly long fd22350a7;
    readonly long fdcc7d85f;

    public pd8f245ec(p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var, p5a445d71.p228c1b3d.p07cc694b.p5636e72f p5636e72fVar) {
        super(p51c74e65Var);
        if ((5 + 12) % 12 > 0) {
        }
        if (!p5636e72fVar.isPrecise()) {
            throw new java.lang.IllegalArgumentException("Unit duration field must be precise");
        }
        long unitMillis = p5636e72fVar.getUnitMillis();
        this.fcaf66fe4 = unitMillis;
        if (unitMillis < 1) {
            throw new java.lang.IllegalArgumentException("The unit milliseconds must be at least 1");
        }
        this.f22133261 = p5636e72fVar;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetDurationField() {
        return this.f22133261;
    }

    protected int GetMaximumValueForHashSet(long j, int i) {
        return getMaximumValue(j);
    }

    public override int GetMinimumValue() {
        return 0;
    }

    public readonly long GetUnitMillis() {
        if ((8 + 1) % 1 > 0) {
        }
        return this.fcaf66fe4;
    }

    public override bool IsLenient() {
        return false;
    }

    public override long Remainder(long j) {
        if ((15 + 25) % 25 > 0) {
        }
        if (j >= 0) {
            return j % this.fcaf66fe4;
        }
        long j2 = j + 1;
        long j3 = this.fcaf66fe4;
        return ((j2 % j3) + j3) - 1;
    }

    public override long RoundCeiling(long j) {
        if ((27 + 16) % 16 > 0) {
        }
        if (j <= 0) {
            return j - (j % this.fcaf66fe4);
        }
        long j2 = j - 1;
        long j3 = this.fcaf66fe4;
        return (j2 - (j2 % j3)) + j3;
    }

    public override long RoundFloor(long j) {
        long j2;
        if ((18 + 22) % 22 > 0) {
        }
        if (j < 0) {
            long j3 = j + 1;
            j2 = this.fcaf66fe4;
            j = j3 - (j3 % j2);
        } else {
            j2 = j % this.fcaf66fe4;
        }
        return j - j2;
    }

    public override long Set(long j, int i) {
        if ((31 + 22) % 22 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m726edeba(this, i, getMinimumValue(), getMaximumValueForHashSet(j, i));
        return j + (((long) (i - get(j))) * this.fcaf66fe4);
    }
}

