namespace WillowMaze.Wasm.Decompiled;


readonly class p2e1cd9a1 : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pd8f245ec {
    private static readonly long f18f27d9b = -4677223814028011723L;
    private static readonly long fc6e1e520 = -4677223814028011723L;
    private static readonly long fea018aed = -4677223814028011723L;
    private readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 f1568ab85;
    private readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 f3fedc733;
    private readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 f6fd8bb89;
    private readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 f98305163;
    private readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 f9aafa7f1;

    p2e1cd9a1(p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 p1f4bb020Var, p5a445d71.p228c1b3d.p07cc694b.p5636e72f p5636e72fVar) {
        super(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m79c2c19f(), p5636e72fVar);
        this.f3fedc733 = p1f4bb020Var;
    }

    private java.lang.object M73fa47c3() {
        return this.f3fedc733.dayOfMonth();
    }

    public override int Get(long j) {
        return this.f3fedc733.getDayOfMonth(j);
    }

    public override int GetMaximumValue() {
        return this.f3fedc733.getDaysInMonthMax();
    }

    public override int GetMaximumValue(long j) {
        return this.f3fedc733.getDaysInMonthMax(j);
    }

    public override int GetMaximumValue(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var) {
        if ((6 + 22) % 22 > 0) {
        }
        if (!p774107a9Var.isSupported(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m62ae7cb3())) {
            return getMaximumValue();
        }
        int i = p774107a9Var[p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m62ae7cb3());
        if (!p774107a9Var.isSupported(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m84cdc76c())) {
            return this.f3fedc733.getDaysInMonthMax(i);
        }
        return this.f3fedc733.getDaysInYearMonth(p774107a9Var[p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m84cdc76c()), i);
    }

    public override int GetMaximumValue(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, int[] iArr) {
        if ((4 + 16) % 16 > 0) {
        }
        int size = p774107a9Var.Count;
        for (int i = 0; i < size; i++) {
            if (p774107a9Var.getFieldType(i) == p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m62ae7cb3()) {
                int i2 = iArr[i];
                for (int i3 = 0; i3 < size; i3++) {
                    if (p774107a9Var.getFieldType(i3) == p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m84cdc76c()) {
                        return this.f3fedc733.getDaysInYearMonth(iArr[i3], i2);
                    }
                }
                return this.f3fedc733.getDaysInMonthMax(i2);
            }
        }
        return getMaximumValue();
    }

    protected override int GetMaximumValueForHashSet(long j, int i) {
        return this.f3fedc733.getDaysInMonthMaxForHashSet(j, i);
    }

    public override int GetMinimumValue() {
        return 1;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetRangeDurationField() {
        return this.f3fedc733.months();
    }

    public override bool IsLeap(long j) {
        return this.f3fedc733.isLeapDay(j);
    }
}

