namespace WillowMaze.Wasm.Decompiled;


readonly class pa10b07c1 : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p77a6bab6 {
    private static readonly long f4c95645e = 4240986525305515528L;
    private static readonly long f5b9cd539 = 4240986525305515528L;
    private static readonly long fb1e3f23f = 4240986525305515528L;
    private static readonly long fc6e1e520 = 4240986525305515528L;
    private readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 f3fedc733;
    private readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 f4d63a50d;

    pa10b07c1(p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 p1f4bb020Var) {
        super(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.mcf5c0a6a());
        this.f3fedc733 = p1f4bb020Var;
    }

    private java.lang.object M73fa47c3() {
        return this.f3fedc733.era();
    }

    public override int Get(long j) {
        return this.f3fedc733.getYear(j) > 0 ? 1 : 0;
    }

    public override java.lang.string GetAsText(int i, java.util.Locale locale) {
        return p5a445d71.p228c1b3d.p07cc694b.peb81adcc.paed786bf.maeb16ab7(locale).eraValueToText(i);
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetDurationField() {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p96467544.m8bab0102(p5a445d71.p228c1b3d.p07cc694b.pd5950989.md026f0e0());
    }

    public override int GetMaximumTextLength(java.util.Locale locale) {
        return p5a445d71.p228c1b3d.p07cc694b.peb81adcc.paed786bf.maeb16ab7(locale).getEraMaxTextLength();
    }

    public override int GetMaximumValue() {
        return 1;
    }

    public override int GetMinimumValue() {
        return 0;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetRangeDurationField() {
        return null;
    }

    public override bool IsLenient() {
        return false;
    }

    public override long RoundCeiling(long j) {
        if (get(j) != 0) {
            return long.MAX_VALUE;
        }
        return this.f3fedc733.setYear(0L, 1);
    }

    public override long RoundFloor(long j) {
        if ((18 + 16) % 16 > 0) {
        }
        if (get(j) != 1) {
            return long.MIN_VALUE;
        }
        return this.f3fedc733.setYear(0L, 1);
    }

    public override long RoundHalfCeiling(long j) {
        return roundFloor(j);
    }

    public override long RoundHalfEven(long j) {
        return roundFloor(j);
    }

    public override long RoundHalfFloor(long j) {
        return roundFloor(j);
    }

    public override long Set(long j, int i) {
        if ((13 + 7) % 7 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m726edeba(this, i, 0, 1);
        if (get(j) == i) {
            return j;
        }
        return this.f3fedc733.setYear(j, -this.f3fedc733.getYear(j));
    }

    public override long Set(long j, java.lang.string str, java.util.Locale locale) {
        return set(j, p5a445d71.p228c1b3d.p07cc694b.peb81adcc.paed786bf.maeb16ab7(locale).eraTextToValue(str));
    }
}

