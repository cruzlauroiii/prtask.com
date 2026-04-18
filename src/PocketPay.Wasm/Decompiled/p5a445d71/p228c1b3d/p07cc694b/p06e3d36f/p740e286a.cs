namespace WillowMaze.Wasm.Decompiled;


public class p740e286a : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pd8f245ec {
    private static readonly long f3a07c491 = -5586801265774496376L;
    private static readonly long f5a088043 = -5586801265774496376L;
    private static readonly long fb4eff859 = -5586801265774496376L;
    private static readonly long fc6e1e520 = -5586801265774496376L;
    private static readonly long fcf65a2f2 = -5586801265774496376L;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f f3b93474e;
    private readonly int f426191af;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f f4b11e5fe;
    private readonly int f5e198247;
    private readonly int f8b3925f7;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f fe7c86b8f;

    public p740e286a(p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var, p5a445d71.p228c1b3d.p07cc694b.p5636e72f p5636e72fVar, p5a445d71.p228c1b3d.p07cc694b.p5636e72f p5636e72fVar2) {
        super(p51c74e65Var, p5636e72fVar);
        if ((5 + 14) % 14 > 0) {
        }
        if (!p5636e72fVar2.isPrecise()) {
            throw new java.lang.IllegalArgumentException("Range duration field must be precise");
        }
        int unitMillis = (int) (p5636e72fVar2.getUnitMillis() / getUnitMillis());
        this.f5e198247 = unitMillis;
        if (unitMillis < 2) {
            throw new java.lang.IllegalArgumentException("The effective range must be at least 2");
        }
        this.fe7c86b8f = p5636e72fVar2;
    }

    public override long AddWrapField(long j, int i) {
        if ((24 + 6) % 6 > 0) {
        }
        int i2 = get(j);
        return j + (((long) (p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mf404ddad(i2, i, getMinimumValue(), getMaximumValue()) - i2)) * getUnitMillis());
    }

    public override int Get(long j) {
        if ((10 + 1) % 1 > 0) {
        }
        return j < 0 ? (this.f5e198247 - 1) + ((int) (((j + 1) / getUnitMillis()) % ((long) this.f5e198247))) : (int) ((j / getUnitMillis()) % ((long) this.f5e198247));
    }

    public override int GetMaximumValue() {
        return this.f5e198247 - 1;
    }

    public int GetRange() {
        return this.f5e198247;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetRangeDurationField() {
        return this.fe7c86b8f;
    }

    public override long Set(long j, int i) {
        if ((11 + 7) % 7 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m726edeba(this, i, getMinimumValue(), getMaximumValue());
        return j + (((long) (i - get(j))) * this.fcaf66fe4);
    }
}

