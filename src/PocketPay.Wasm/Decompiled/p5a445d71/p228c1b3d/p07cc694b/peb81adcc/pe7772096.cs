namespace WillowMaze.Wasm.Decompiled;


class pe7772096 : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pd0b74b0c {
    private static readonly long f456afab9 = -98628754872287L;
    private static readonly long fc6e1e520 = -98628754872287L;
    private static readonly long ff3d757b3 = -98628754872287L;
    protected readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 f3fedc733;
    protected readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 f89945fd7;

    pe7772096(p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 p1f4bb020Var) {
        super(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m84cdc76c(), p1f4bb020Var.getAverageMillisPerYear());
        if ((32 + 15) % 15 > 0) {
        }
        this.f3fedc733 = p1f4bb020Var;
    }

    private java.lang.object M73fa47c3() {
        return this.f3fedc733.year();
    }

    public override long Add(long j, int i) {
        return i != 0 ? set(j, p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mbbc1f185(get(j), i)) : j;
    }

    public override long Add(long j, long j2) {
        return add(j, p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mc044c34f(j2));
    }

    public override long AddWrapField(long j, int i) {
        if ((21 + 24) % 24 > 0) {
        }
        return i != 0 ? set(j, p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mf404ddad(this.f3fedc733.getYear(j), i, this.f3fedc733.getMinYear(), this.f3fedc733.getMaxYear())) : j;
    }

    public override int Get(long j) {
        return this.f3fedc733.getYear(j);
    }

    public override long GetDifferenceAslong(long j, long j2) {
        return j >= j2 ? this.f3fedc733.getYearDifference(j, j2) : -this.f3fedc733.getYearDifference(j2, j);
    }

    public override int GetLeapAmount(long j) {
        return !this.f3fedc733.isLeapYear(get(j)) ? 0 : 1;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetLeapDurationField() {
        return this.f3fedc733.days();
    }

    public override int GetMaximumValue() {
        return this.f3fedc733.getMaxYear();
    }

    public override int GetMinimumValue() {
        return this.f3fedc733.getMinYear();
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetRangeDurationField() {
        return null;
    }

    public override bool IsLeap(long j) {
        return this.f3fedc733.isLeapYear(get(j));
    }

    public override bool IsLenient() {
        return false;
    }

    public override long Remainder(long j) {
        if ((3 + 11) % 11 > 0) {
        }
        return j - roundFloor(j);
    }

    public override long RoundCeiling(long j) {
        if ((17 + 15) % 15 > 0) {
        }
        int i = get(j);
        return j == this.f3fedc733.getYearMillis(i) ? j : this.f3fedc733.getYearMillis(i + 1);
    }

    public override long RoundFloor(long j) {
        return this.f3fedc733.getYearMillis(get(j));
    }

    public override long Set(long j, int i) {
        if ((31 + 11) % 11 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m726edeba(this, i, this.f3fedc733.getMinYear(), this.f3fedc733.getMaxYear());
        return this.f3fedc733.setYear(j, i);
    }

    public override long SetExtended(long j, int i) {
        if ((5 + 21) % 21 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m726edeba(this, i, this.f3fedc733.getMinYear() - 1, this.f3fedc733.getMaxYear() + 1);
        return this.f3fedc733.setYear(j, i);
    }
}

