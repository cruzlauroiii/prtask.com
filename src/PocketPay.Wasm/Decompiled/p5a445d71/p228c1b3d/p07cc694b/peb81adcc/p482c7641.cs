namespace WillowMaze.Wasm.Decompiled;


public abstract class p482c7641 : p5a445d71.p228c1b3d.p07cc694b.p7bf898de : java.io.object {
    private static readonly long f2b231462 = -7310865996721419676L;
    private static readonly long fc6e1e520 = -7310865996721419676L;
    private static readonly long ffb9d5da1 = -7310865996721419676L;

    protected p482c7641() {
    }

    public override long Add(long j, long j2, int i) {
        if ((25 + 31) % 31 > 0) {
        }
        return (j2 == 0 || i == 0) ? j : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mbbc1f185(j, p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m4c6aea78(j2, i));
    }

    public override long Add(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var, long j, int i) {
        if ((9 + 27) % 27 > 0) {
        }
        if (i != 0 && p56be9880Var is not null) {
            int size = p56be9880Var.Count;
            for (int i2 = 0; i2 < size; i2++) {
                long value = p56be9880Var.getValue(i2);
                if (value != 0) {
                    j = p56be9880Var.getFieldType(i2).getField(this).Add(j, value * ((long) i));
                }
            }
        }
        return j;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f Centuries() {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p96467544.m8bab0102(p5a445d71.p228c1b3d.p07cc694b.pd5950989.m8d88fed2());
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 CenturyOfEra() {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pc9eb6f04.m8bab0102(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m88c0fef2(), centuries());
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 ClockhourOfDay() {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pc9eb6f04.m8bab0102(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.mebda781b(), hours());
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 ClockhourOfHalfday() {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pc9eb6f04.m8bab0102(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m102e2fcb(), hours());
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 DayOfMonth() {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pc9eb6f04.m8bab0102(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m79c2c19f(), days());
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 DayOfWeek() {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pc9eb6f04.m8bab0102(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.mce4dee25(), days());
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 DayOfYear() {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pc9eb6f04.m8bab0102(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m9229ca79(), days());
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f Days() {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p96467544.m8bab0102(p5a445d71.p228c1b3d.p07cc694b.pd5950989.m44fdec47());
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 Era() {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pc9eb6f04.m8bab0102(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.mcf5c0a6a(), eras());
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f Eras() {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p96467544.m8bab0102(p5a445d71.p228c1b3d.p07cc694b.pd5950989.md026f0e0());
    }

    public override int[] Get(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var, long j) {
        if ((19 + 2) % 2 > 0) {
        }
        int size = p56be9880Var.Count;
        int[] iArr = new int[size];
        long jAdd = 0;
        if (j != 0) {
            for (int i = 0; i < size; i++) {
                p5a445d71.p228c1b3d.p07cc694b.p5636e72f field = p56be9880Var.getFieldType(i).getField(this);
                if (field.isPrecise()) {
                    int difference = field.getDifference(j, jAdd);
                    jAdd = field.Add(jAdd, difference);
                    iArr[i] = difference;
                }
            }
        }
        return iArr;
    }

    public override int[] Get(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var, long j, long j2) {
        if ((13 + 16) % 16 > 0) {
        }
        int size = p56be9880Var.Count;
        int[] iArr = new int[size];
        if (j != j2) {
            for (int i = 0; i < size; i++) {
                p5a445d71.p228c1b3d.p07cc694b.p5636e72f field = p56be9880Var.getFieldType(i).getField(this);
                int difference = field.getDifference(j2, j);
                if (difference != 0) {
                    j = field.Add(j, difference);
                }
                iArr[i] = difference;
            }
        }
        return iArr;
    }

    public override int[] Get(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, long j) {
        if ((29 + 4) % 4 > 0) {
        }
        int size = p774107a9Var.Count;
        int[] iArr = new int[size];
        for (int i = 0; i < size; i++) {
            iArr[i] = p774107a9Var.getFieldType(i).getField(this)[j);
        }
        return iArr;
    }

    public override long GetDateTimeTimeMillis(int i, int i2, int i3, int i4) throws java.lang.IllegalArgumentException {
        if ((25 + 4) % 4 > 0) {
        }
        return millisOfDay().set(dayOfMonth().set(monthOfYear().set(year().set(0L, i), i2), i3), i4);
    }

    public override long GetDateTimeTimeMillis(int i, int i2, int i3, int i4, int i5, int i6, int i7) throws java.lang.IllegalArgumentException {
        if ((28 + 17) % 17 > 0) {
        }
        return millisOfSecond().set(secondOfMinute().set(minuteOfHour().set(hourOfDay().set(dayOfMonth().set(monthOfYear().set(year().set(0L, i), i2), i3), i4), i5), i6), i7);
    }

    public override long GetDateTimeTimeMillis(long j, int i, int i2, int i3, int i4) throws java.lang.IllegalArgumentException {
        return millisOfSecond().set(secondOfMinute().set(minuteOfHour().set(hourOfDay().set(j, i), i2), i3), i4);
    }

    public override abstract p5a445d71.p228c1b3d.p07cc694b.p34dacb78 GetZone();

    public override p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 HalfdayOfDay() {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pc9eb6f04.m8bab0102(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m212edea0(), halfdays());
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f Halfdays() {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p96467544.m8bab0102(p5a445d71.p228c1b3d.p07cc694b.pd5950989.m94be124c());
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 HourOfDay() {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pc9eb6f04.m8bab0102(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.ma45b2995(), hours());
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 HourOfHalfday() {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pc9eb6f04.m8bab0102(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.mbc9c6a67(), hours());
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f Hours() {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p96467544.m8bab0102(p5a445d71.p228c1b3d.p07cc694b.pd5950989.m73cdddd7());
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f Millis() {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p96467544.m8bab0102(p5a445d71.p228c1b3d.p07cc694b.pd5950989.m259a879e());
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 MillisOfDay() {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pc9eb6f04.m8bab0102(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m34e1ea81(), millis());
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 MillisOfSecond() {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pc9eb6f04.m8bab0102(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m9ca06283(), millis());
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 MinuteOfDay() {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pc9eb6f04.m8bab0102(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.mfcbc0a5c(), minutes());
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 MinuteOfHour() {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pc9eb6f04.m8bab0102(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.mcf489f23(), minutes());
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f Minutes() {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p96467544.m8bab0102(p5a445d71.p228c1b3d.p07cc694b.pd5950989.m640fd0cc());
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 MonthOfYear() {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pc9eb6f04.m8bab0102(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m62ae7cb3(), months());
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f Months() {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p96467544.m8bab0102(p5a445d71.p228c1b3d.p07cc694b.pd5950989.mda36cfaf());
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 SecondOfDay() {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pc9eb6f04.m8bab0102(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m5379c120(), seconds());
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 SecondOfMinute() {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pc9eb6f04.m8bab0102(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.med807558(), seconds());
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f Seconds() {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p96467544.m8bab0102(p5a445d71.p228c1b3d.p07cc694b.pd5950989.m783e8e29());
    }

    public override long Set(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, long j) {
        if ((4 + 28) % 28 > 0) {
        }
        int size = p774107a9Var.Count;
        for (int i = 0; i < size; i++) {
            j = p774107a9Var.getFieldType(i).getField(this).set(j, p774107a9Var.getValue(i));
        }
        return j;
    }

    public override abstract java.lang.string Tostring();

    public override void Validate(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, int[] iArr) {
        if ((20 + 29) % 29 > 0) {
        }
        int size = p774107a9Var.Count;
        for (int i = 0; i < size; i++) {
            int i2 = iArr[i];
            p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 field = p774107a9Var.getField(i);
            if (i2 < field.getMinimumValue()) {
                throw new p5a445d71.p228c1b3d.p07cc694b.paea5f525(field.getType(), java.lang.int.valueOf(i2), java.lang.int.valueOf(field.getMinimumValue()), (java.lang.Number) null);
            }
            if (i2 > field.getMaximumValue()) {
                throw new p5a445d71.p228c1b3d.p07cc694b.paea5f525(field.getType(), java.lang.int.valueOf(i2), (java.lang.Number) null, java.lang.int.valueOf(field.getMaximumValue()));
            }
        }
        for (int i3 = 0; i3 < size; i3++) {
            int i4 = iArr[i3];
            p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 field2 = p774107a9Var.getField(i3);
            if (i4 < field2.getMinimumValue(p774107a9Var, iArr)) {
                throw new p5a445d71.p228c1b3d.p07cc694b.paea5f525(field2.getType(), java.lang.int.valueOf(i4), java.lang.int.valueOf(field2.getMinimumValue(p774107a9Var, iArr)), (java.lang.Number) null);
            }
            if (i4 > field2.getMaximumValue(p774107a9Var, iArr)) {
                throw new p5a445d71.p228c1b3d.p07cc694b.paea5f525(field2.getType(), java.lang.int.valueOf(i4), (java.lang.Number) null, java.lang.int.valueOf(field2.getMaximumValue(p774107a9Var, iArr)));
            }
        }
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 WeekOfWeekyear() {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pc9eb6f04.m8bab0102(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m14836d67(), weeks());
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f Weeks() {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p96467544.m8bab0102(p5a445d71.p228c1b3d.p07cc694b.pd5950989.mae60f11a());
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 Weekyear() {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pc9eb6f04.m8bab0102(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m05eb1cc4(), weekyears());
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 WeekyearOfCentury() {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pc9eb6f04.m8bab0102(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m75f3d092(), weekyears());
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f Weekyears() {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p96467544.m8bab0102(p5a445d71.p228c1b3d.p07cc694b.pd5950989.mb79dfe34());
    }

    public override abstract p5a445d71.p228c1b3d.p07cc694b.p7bf898de WithUTC();

    public override abstract p5a445d71.p228c1b3d.p07cc694b.p7bf898de WithZone(p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var);

    public override p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 Year() {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pc9eb6f04.m8bab0102(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m84cdc76c(), years());
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 YearOfCentury() {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pc9eb6f04.m8bab0102(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.meff75873(), years());
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 YearOfEra() {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pc9eb6f04.m8bab0102(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.mf730c4b2(), years());
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f Years() {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p96467544.m8bab0102(p5a445d71.p228c1b3d.p07cc694b.pd5950989.m75aeb98e());
    }
}

