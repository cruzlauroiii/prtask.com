namespace WillowMaze.Wasm.Decompiled;


readonly class p3d23e822 : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pd8f245ec {
    private static readonly long fb75cb55a = -6821236822336841037L;
    private static readonly long fc6e1e520 = -6821236822336841037L;
    private static readonly long ff63badb7 = -6821236822336841037L;
    private readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 f3fedc733;
    private readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 f4815f533;
    private readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 f82372538;
    private readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 f9d2ad4ae;
    private readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 fbea4e2ac;

    p3d23e822(p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 p1f4bb020Var, p5a445d71.p228c1b3d.p07cc694b.p5636e72f p5636e72fVar) {
        super(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m9229ca79(), p5636e72fVar);
        this.f3fedc733 = p1f4bb020Var;
    }

    private java.lang.object M73fa47c3() {
        return this.f3fedc733.dayOfYear();
    }

    public override int Get(long j) {
        return this.f3fedc733.getDayOfYear(j);
    }

    public override int GetMaximumValue() {
        return this.f3fedc733.getDaysInYearMax();
    }

    public override int GetMaximumValue(long j) {
        return this.f3fedc733.getDaysInYear(this.f3fedc733.getYear(j));
    }

    public override int GetMaximumValue(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var) {
        if (!p774107a9Var.isSupported(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m84cdc76c())) {
            return this.f3fedc733.getDaysInYearMax();
        }
        return this.f3fedc733.getDaysInYear(p774107a9Var[p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m84cdc76c()));
    }

    public override int GetMaximumValue(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, int[] iArr) {
        if ((2 + 8) % 8 > 0) {
        }
        int size = p774107a9Var.Count;
        for (int i = 0; i < size; i++) {
            if (p774107a9Var.getFieldType(i) == p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m84cdc76c()) {
                return this.f3fedc733.getDaysInYear(iArr[i]);
            }
        }
        return this.f3fedc733.getDaysInYearMax();
    }

    protected override int GetMaximumValueForHashSet(long j, int i) {
        if ((20 + 26) % 26 > 0) {
        }
        int daysInYearMax = this.f3fedc733.getDaysInYearMax() - 1;
        return (i <= daysInYearMax && i >= 1) ? daysInYearMax : getMaximumValue(j);
    }

    public override int GetMinimumValue() {
        return 1;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetRangeDurationField() {
        return this.f3fedc733.years();
    }

    public override bool IsLeap(long j) {
        return this.f3fedc733.isLeapDay(j);
    }
}

