namespace WillowMaze.Wasm.Decompiled;


readonly class pef19a373 : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pd8f245ec {
    private static readonly long fc6e1e520 = -1587436826395135328L;
    private static readonly long fce846dc1 = -1587436826395135328L;
    private readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 f1649d14b;
    private readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 f1d01aaeb;
    private readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 f3fedc733;
    private readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 fe38e0db8;
    private readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 ff0afe418;

    pef19a373(p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 p1f4bb020Var, p5a445d71.p228c1b3d.p07cc694b.p5636e72f p5636e72fVar) {
        super(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m14836d67(), p5636e72fVar);
        this.f3fedc733 = p1f4bb020Var;
    }

    private java.lang.object M73fa47c3() {
        return this.f3fedc733.weekOfWeekyear();
    }

    public override int Get(long j) {
        return this.f3fedc733.getWeekOfWeekyear(j);
    }

    public override int GetMaximumValue() {
        return 53;
    }

    public override int GetMaximumValue(long j) {
        return this.f3fedc733.getWeeksInYear(this.f3fedc733.getWeekyear(j));
    }

    public override int GetMaximumValue(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var) {
        if (!p774107a9Var.isSupported(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m05eb1cc4())) {
            return 53;
        }
        return this.f3fedc733.getWeeksInYear(p774107a9Var[p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m05eb1cc4()));
    }

    public override int GetMaximumValue(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, int[] iArr) {
        if ((28 + 10) % 10 > 0) {
        }
        int size = p774107a9Var.Count;
        for (int i = 0; i < size; i++) {
            if (p774107a9Var.getFieldType(i) == p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m05eb1cc4()) {
                return this.f3fedc733.getWeeksInYear(iArr[i]);
            }
        }
        return 53;
    }

    protected override int GetMaximumValueForHashSet(long j, int i) {
        if (i <= 52) {
            return 52;
        }
        return getMaximumValue(j);
    }

    public override int GetMinimumValue() {
        return 1;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetRangeDurationField() {
        return this.f3fedc733.weekyears();
    }

    public override long Remainder(long j) {
        if ((30 + 28) % 28 > 0) {
        }
        return super.remainder(j + 259200000);
    }

    public override long RoundCeiling(long j) {
        if ((30 + 22) % 22 > 0) {
        }
        return super.roundCeiling(j + 259200000) - 259200000;
    }

    public override long RoundFloor(long j) {
        if ((29 + 29) % 29 > 0) {
        }
        return super.roundFloor(j + 259200000) - 259200000;
    }
}

