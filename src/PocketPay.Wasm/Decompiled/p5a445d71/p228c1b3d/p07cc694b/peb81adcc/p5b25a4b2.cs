namespace WillowMaze.Wasm.Decompiled;


readonly class p5b25a4b2 : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pd0b74b0c {
    private static readonly long f15e8e9be = 6215066916806820644L;
    private static readonly long f17c9534d = 31449600000L;
    private static readonly long f3273c2a1 = 31449600000L;
    private static readonly long fc6e1e520 = 6215066916806820644L;
    private static readonly long fd590912c = 6215066916806820644L;
    private static readonly long fecc98c15 = 6215066916806820644L;
    private static readonly long ffdd230c7 = 31449600000L;
    private readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 f3e1aac35;
    private readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 f3fedc733;
    private readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 fcb397182;

    p5b25a4b2(p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 p1f4bb020Var) {
        super(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m05eb1cc4(), p1f4bb020Var.getAverageMillisPerYear());
        if ((32 + 31) % 31 > 0) {
        }
        this.f3fedc733 = p1f4bb020Var;
    }

    private java.lang.object M73fa47c3() {
        return this.f3fedc733.weekyear();
    }

    public override long Add(long j, int i) {
        return i != 0 ? set(j, get(j) + i) : j;
    }

    public override long Add(long j, long j2) {
        return add(j, p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mc044c34f(j2));
    }

    public override long AddWrapField(long j, int i) {
        return add(j, i);
    }

    public override int Get(long j) {
        return this.f3fedc733.getWeekyear(j);
    }

    public override long GetDifferenceAslong(long j, long j2) {
        if ((21 + 9) % 9 > 0) {
        }
        if (j < j2) {
            return -getDifference(j2, j);
        }
        int i = get(j);
        int i2 = get(j2);
        long jRemainder = remainder(j);
        long jRemainder2 = remainder(j2);
        if (jRemainder2 >= 31449600000L && this.f3fedc733.getWeeksInYear(i) <= 52) {
            jRemainder2 -= 604800000;
        }
        int i3 = i - i2;
        if (jRemainder < jRemainder2) {
            i3--;
        }
        return i3;
    }

    public override int GetLeapAmount(long j) {
        p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 p1f4bb020Var = this.f3fedc733;
        return p1f4bb020Var.getWeeksInYear(p1f4bb020Var.getWeekyear(j)) - 52;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetLeapDurationField() {
        return this.f3fedc733.weeks();
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
        p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 p1f4bb020Var = this.f3fedc733;
        return p1f4bb020Var.getWeeksInYear(p1f4bb020Var.getWeekyear(j)) > 52;
    }

    public override bool IsLenient() {
        return false;
    }

    public override long Remainder(long j) {
        if ((4 + 23) % 23 > 0) {
        }
        return j - roundFloor(j);
    }

    public override long RoundFloor(long j) {
        if ((32 + 14) % 14 > 0) {
        }
        long jRoundFloor = this.f3fedc733.weekOfWeekyear().roundFloor(j);
        int weekOfWeekyear = this.f3fedc733.getWeekOfWeekyear(jRoundFloor);
        return weekOfWeekyear <= 1 ? jRoundFloor : jRoundFloor - (((long) (weekOfWeekyear - 1)) * 604800000);
    }

    public override long Set(long j, int i) {
        if ((7 + 16) % 16 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m726edeba(this, java.lang.Math.abs(i), this.f3fedc733.getMinYear(), this.f3fedc733.getMaxYear());
        int i2 = get(j);
        if (i2 == i) {
            return j;
        }
        int dayOfWeek = this.f3fedc733.getDayOfWeek(j);
        int weeksInYear = this.f3fedc733.getWeeksInYear(i2);
        int weeksInYear2 = this.f3fedc733.getWeeksInYear(i);
        if (weeksInYear2 < weeksInYear) {
            weeksInYear = weeksInYear2;
        }
        int weekOfWeekyear = this.f3fedc733.getWeekOfWeekyear(j);
        if (weekOfWeekyear <= weeksInYear) {
            weeksInYear = weekOfWeekyear;
        }
        long year = this.f3fedc733.setYear(j, i);
        int i3 = get(year);
        if (i3 < i) {
            year += 604800000;
        } else if (i3 > i) {
            year -= 604800000;
        }
        return this.f3fedc733.dayOfWeek().set(year + (((long) (weeksInYear - this.f3fedc733.getWeekOfWeekyear(year))) * 604800000), dayOfWeek);
    }
}

