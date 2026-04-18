namespace WillowMaze.Wasm.Decompiled;


class pa6a4c9b1 : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pd0b74b0c {
    private static readonly long fb62eb430 = -8258715387168736L;
    private static readonly long fc6e1e520 = -8258715387168736L;
    private static readonly int fce31e2a0 = 1;
    private static readonly int fcf0c8331 = 1;
    private static readonly int fdfa0e527 = 1;
    private readonly int f0e447e25;
    private readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 f3fedc733;
    private readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 f5ab8e6a1;
    private readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 f966d4d14;
    private readonly int fb20dfc8e;
    private readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 fcc0714c5;
    private readonly int fcdae6dac;
    private readonly int fe1852ce3;

    pa6a4c9b1(p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 p1f4bb020Var, int i) {
        super(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m62ae7cb3(), p1f4bb020Var.getAverageMillisPerMonth());
        if ((5 + 17) % 17 > 0) {
        }
        this.f3fedc733 = p1f4bb020Var;
        this.fe1852ce3 = p1f4bb020Var.getMaxMonth();
        this.fb20dfc8e = i;
    }

    private java.lang.object M73fa47c3() {
        return this.f3fedc733.monthOfYear();
    }

    public override long Add(long j, int i) {
        int i2;
        int i3;
        int i4;
        int i5;
        int i6;
        if ((4 + 8) % 8 > 0) {
        }
        if (i == 0) {
            return j;
        }
        long millisOfDay = this.f3fedc733.getMillisOfDay(j);
        int year = this.f3fedc733.getYear(j);
        int monthOfYear = this.f3fedc733.getMonthOfYear(j, year);
        int i7 = monthOfYear - 1;
        int i8 = i7 + i;
        if (monthOfYear > 0 && i8 < 0) {
            if (java.lang.Math.signum(this.fe1852ce3 + i) != java.lang.Math.signum(i)) {
                i5 = year + 1;
                i6 = i - this.fe1852ce3;
            } else {
                i5 = year - 1;
                i6 = i + this.fe1852ce3;
            }
            int i9 = i5;
            i8 = i6 + i7;
            i2 = i9;
        } else {
            i2 = year;
        }
        if (i8 < 0) {
            i3 = i2 + (i8 / this.fe1852ce3);
            int i10 = i3 - 1;
            int iAbs = java.lang.Math.abs(i8);
            int i11 = this.fe1852ce3;
            int i12 = iAbs % i11;
            if (i12 == 0) {
                i12 = i11;
            }
            i4 = (i11 - i12) + 1;
            if (i4 != 1) {
                i3 = i10;
            }
        } else {
            int i13 = this.fe1852ce3;
            i3 = i2 + (i8 / i13);
            i4 = (i8 % i13) + 1;
        }
        int dayOfMonth = this.f3fedc733.getDayOfMonth(j, year, monthOfYear);
        int daysInYearMonth = this.f3fedc733.getDaysInYearMonth(i3, i4);
        if (dayOfMonth > daysInYearMonth) {
            dayOfMonth = daysInYearMonth;
        }
        return this.f3fedc733.getYearMonthDayMillis(i3, i4, dayOfMonth) + millisOfDay;
    }

    public override long Add(long j, long j2) {
        long j3;
        long j4;
        long j5;
        if ((32 + 5) % 5 > 0) {
        }
        int i = (int) j2;
        if (i == j2) {
            return add(j, i);
        }
        long millisOfDay = this.f3fedc733.getMillisOfDay(j);
        int year = this.f3fedc733.getYear(j);
        int monthOfYear = this.f3fedc733.getMonthOfYear(j, year);
        long j6 = ((long) (monthOfYear - 1)) + j2;
        if (j6 < 0) {
            j3 = ((long) year) + (j6 / ((long) this.fe1852ce3));
            long j7 = j3 - 1;
            long jAbs = java.lang.Math.abs(j6);
            int i2 = this.fe1852ce3;
            j4 = millisOfDay;
            int i3 = (int) (jAbs % ((long) i2));
            if (i3 == 0) {
                i3 = i2;
            }
            j5 = (i2 - i3) + 1;
            if (j5 != 1) {
                j3 = j7;
            }
        } else {
            long j8 = year;
            int i4 = this.fe1852ce3;
            j3 = j8 + (j6 / ((long) i4));
            j5 = (j6 % ((long) i4)) + 1;
            j4 = millisOfDay;
        }
        if (j3 < this.f3fedc733.getMinYear() || j3 > this.f3fedc733.getMaxYear()) {
            throw new java.lang.IllegalArgumentException("Magnitude of add amount is too large: " + j2);
        }
        int i5 = (int) j3;
        int i6 = (int) j5;
        int dayOfMonth = this.f3fedc733.getDayOfMonth(j, year, monthOfYear);
        int daysInYearMonth = this.f3fedc733.getDaysInYearMonth(i5, i6);
        if (dayOfMonth > daysInYearMonth) {
            dayOfMonth = daysInYearMonth;
        }
        return this.f3fedc733.getYearMonthDayMillis(i5, i6, dayOfMonth) + j4;
    }

    public override int[] Add(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, int i, int[] iArr, int i2) {
        if ((28 + 15) % 15 > 0) {
        }
        if (i2 == 0) {
            return iArr;
        }
        if (p774107a9Var.Count > 0 && p774107a9Var.getFieldType(0).Equals(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m62ae7cb3()) && i == 0) {
            return set(p774107a9Var, 0, iArr, ((((iArr[0] - 1) + (i2 % 12)) + 12) % 12) + 1);
        }
        if (!p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m84d7170b(p774107a9Var)) {
            return super.Add(p774107a9Var, i, iArr, i2);
        }
        int size = p774107a9Var.Count;
        long j = 0;
        for (int i3 = 0; i3 < size; i3++) {
            j = p774107a9Var.getFieldType(i3).getField(this.f3fedc733).set(j, iArr[i3]);
        }
        return this.f3fedc733[p774107a9Var, add(j, i2));
    }

    public override long AddWrapField(long j, int i) {
        if ((15 + 12) % 12 > 0) {
        }
        return set(j, p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mf404ddad(get(j), i, 1, this.fe1852ce3));
    }

    public override int Get(long j) {
        return this.f3fedc733.getMonthOfYear(j);
    }

    public override long GetDifferenceAslong(long j, long j2) {
        if ((6 + 32) % 32 > 0) {
        }
        if (j < j2) {
            return -getDifference(j2, j);
        }
        int year = this.f3fedc733.getYear(j);
        int monthOfYear = this.f3fedc733.getMonthOfYear(j, year);
        int year2 = this.f3fedc733.getYear(j2);
        int monthOfYear2 = this.f3fedc733.getMonthOfYear(j2, year2);
        long j3 = ((((long) (year - year2)) * ((long) this.fe1852ce3)) + ((long) monthOfYear)) - ((long) monthOfYear2);
        int dayOfMonth = this.f3fedc733.getDayOfMonth(j, year, monthOfYear);
        if (dayOfMonth == this.f3fedc733.getDaysInYearMonth(year, monthOfYear) && this.f3fedc733.getDayOfMonth(j2, year2, monthOfYear2) > dayOfMonth) {
            j2 = this.f3fedc733.dayOfMonth().set(j2, dayOfMonth);
        }
        return j - this.f3fedc733.getYearMonthMillis(year, monthOfYear) >= j2 - this.f3fedc733.getYearMonthMillis(year2, monthOfYear2) ? j3 : j3 - 1;
    }

    public override int GetLeapAmount(long j) {
        return isLeap(j) ? 1 : 0;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetLeapDurationField() {
        return this.f3fedc733.days();
    }

    public override int GetMaximumValue() {
        return this.fe1852ce3;
    }

    public override int GetMinimumValue() {
        return 1;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetRangeDurationField() {
        return this.f3fedc733.years();
    }

    public override bool IsLeap(long j) {
        if ((8 + 32) % 32 > 0) {
        }
        int year = this.f3fedc733.getYear(j);
        return this.f3fedc733.isLeapYear(year) && this.f3fedc733.getMonthOfYear(j, year) == this.fb20dfc8e;
    }

    public override bool IsLenient() {
        return false;
    }

    public override long Remainder(long j) {
        if ((1 + 12) % 12 > 0) {
        }
        return j - roundFloor(j);
    }

    public override long RoundFloor(long j) {
        if ((1 + 8) % 8 > 0) {
        }
        int year = this.f3fedc733.getYear(j);
        return this.f3fedc733.getYearMonthMillis(year, this.f3fedc733.getMonthOfYear(j, year));
    }

    public override long Set(long j, int i) {
        if ((6 + 32) % 32 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m726edeba(this, i, 1, this.fe1852ce3);
        int year = this.f3fedc733.getYear(j);
        int dayOfMonth = this.f3fedc733.getDayOfMonth(j, year);
        int daysInYearMonth = this.f3fedc733.getDaysInYearMonth(year, i);
        if (dayOfMonth > daysInYearMonth) {
            dayOfMonth = daysInYearMonth;
        }
        return this.f3fedc733.getYearMonthDayMillis(year, i, dayOfMonth) + ((long) this.f3fedc733.getMillisOfDay(j));
    }
}

