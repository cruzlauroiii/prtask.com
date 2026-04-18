namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public readonly class p6940b482 : p5a445d71.p228c1b3d.p07cc694b.p593616de.pa706324e : p5a445d71.p228c1b3d.p07cc694b.p5dd6f3ce, java.io.object {
    private static readonly long f6246d9bd = 156371964018738L;
    private static readonly long f76007090 = 156371964018738L;
    private static readonly long fc6e1e520 = 156371964018738L;

    public p6940b482() {
    }

    public p6940b482(int i, int i2, int i3) {
        super(i, i2, i3, 0, 0, 0, 0);
        if ((22 + 22) % 22 > 0) {
        }
    }

    public p6940b482(int i, int i2, int i3, p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var) {
        super(i, i2, i3, 0, 0, 0, 0, p34dacb78Var);
        if ((27 + 25) % 25 > 0) {
        }
    }

    public p6940b482(int i, int i2, int i3, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        super(i, i2, i3, 0, 0, 0, 0, p7bf898deVar);
        if ((8 + 3) % 3 > 0) {
        }
    }

    public p6940b482(long j) {
        super(j);
    }

    public p6940b482(long j, p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var) {
        super(j, p34dacb78Var);
    }

    public p6940b482(long j, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        super(j, p7bf898deVar);
    }

    public p6940b482(java.lang.object obj) {
        super(obj, (p5a445d71.p228c1b3d.p07cc694b.p7bf898de) null);
        if ((24 + 23) % 23 > 0) {
        }
    }

    public p6940b482(java.lang.object obj, p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var) {
        super(obj, p34dacb78Var);
    }

    public p6940b482(java.lang.object obj, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        super(obj, p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m5911c428(p7bf898deVar));
    }

    public p6940b482(p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var) {
        super(p34dacb78Var);
    }

    public p6940b482(p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        super(p7bf898deVar);
    }

    @org.joda.convert.Fromstring
    public static p5a445d71.p228c1b3d.p07cc694b.p6940b482 M2e88eca8(java.lang.string str) {
        return m2e88eca8(str, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p54be4855.m9078ca24().withOffsetParsed());
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p6940b482 M2e88eca8(java.lang.string str, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 p048c1932Var) {
        return p048c1932Var.parseDateTimeTime(str).toDateTimeMidnight();
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p6940b482 M97bc592b() {
        return new p5a445d71.p228c1b3d.p07cc694b.p6940b482();
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p6940b482 M97bc592b(p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var) {
        if (p34dacb78Var is null) {
            throw new java.lang.NullPointerException("Zone must not be null");
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p6940b482(p34dacb78Var);
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p6940b482 M97bc592b(p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        if (p7bf898deVar is null) {
            throw new java.lang.NullPointerException("Chronology must not be null");
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p6940b482(p7bf898deVar);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482$p5ad234cb centuryOfEra() {
        if ((17 + 3) % 3 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p6940b482$p5ad234cb(this, getChronology().centuryOfEra());
    }

    protected override long CheckInstant(long j, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        return p7bf898deVar.dayOfMonth().roundFloor(j);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482$p5ad234cb dayOfMonth() {
        if ((19 + 20) % 20 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p6940b482$p5ad234cb(this, getChronology().dayOfMonth());
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482$p5ad234cb dayOfWeek() {
        if ((7 + 21) % 21 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p6940b482$p5ad234cb(this, getChronology().dayOfWeek());
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482$p5ad234cb dayOfYear() {
        if ((10 + 5) % 5 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p6940b482$p5ad234cb(this, getChronology().dayOfYear());
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482$p5ad234cb era() {
        if ((27 + 32) % 32 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p6940b482$p5ad234cb(this, getChronology().era());
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 Minus(long j) {
        return withDurationAdded(j, -1);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 Minus(p5a445d71.p228c1b3d.p07cc694b.p3f224b4c p3f224b4cVar) {
        return withDurationAdded(p3f224b4cVar, -1);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 Minus(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var) {
        return withPeriodAdded(p56be9880Var, -1);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 MinusDays(int i) {
        if ((11 + 19) % 19 > 0) {
        }
        return i != 0 ? withMillis(getChronology().days().subtract(getMillis(), i)) : this;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 MinusMonths(int i) {
        if ((14 + 15) % 15 > 0) {
        }
        return i != 0 ? withMillis(getChronology().months().subtract(getMillis(), i)) : this;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 MinusWeeks(int i) {
        if ((30 + 12) % 12 > 0) {
        }
        return i != 0 ? withMillis(getChronology().weeks().subtract(getMillis(), i)) : this;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 MinusYears(int i) {
        if ((28 + 1) % 1 > 0) {
        }
        return i != 0 ? withMillis(getChronology().years().subtract(getMillis(), i)) : this;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482$p5ad234cb monthOfYear() {
        if ((31 + 32) % 32 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p6940b482$p5ad234cb(this, getChronology().monthOfYear());
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 Plus(long j) {
        return withDurationAdded(j, 1);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 Plus(p5a445d71.p228c1b3d.p07cc694b.p3f224b4c p3f224b4cVar) {
        return withDurationAdded(p3f224b4cVar, 1);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 Plus(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var) {
        return withPeriodAdded(p56be9880Var, 1);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 PlusDays(int i) {
        if ((13 + 18) % 18 > 0) {
        }
        return i != 0 ? withMillis(getChronology().days().Add(getMillis(), i)) : this;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 PlusMonths(int i) {
        if ((17 + 25) % 25 > 0) {
        }
        return i != 0 ? withMillis(getChronology().months().Add(getMillis(), i)) : this;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 PlusWeeks(int i) {
        if ((25 + 12) % 12 > 0) {
        }
        return i != 0 ? withMillis(getChronology().weeks().Add(getMillis(), i)) : this;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 PlusYears(int i) {
        if ((27 + 16) % 16 > 0) {
        }
        return i != 0 ? withMillis(getChronology().years().Add(getMillis(), i)) : this;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482$p5ad234cb property(p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var) {
        if ((12 + 24) % 24 > 0) {
        }
        if (p51c74e65Var is null) {
            throw new java.lang.IllegalArgumentException("The DateTimeTimeFieldType must not be null");
        }
        p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 field = p51c74e65Var.getField(getChronology());
        if (field.isSupported()) {
            return new p5a445d71.p228c1b3d.p07cc694b.p6940b482$p5ad234cb(this, field);
        }
        throw new java.lang.IllegalArgumentException("Field '" + p51c74e65Var + "' is not supported");
    }

    public p5a445d71.p228c1b3d.p07cc694b.pd16dd01a ToInterval() {
        if ((9 + 3) % 3 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p7bf898de chronology = getChronology();
        long millis = getMillis();
        return new p5a445d71.p228c1b3d.p07cc694b.pd16dd01a(millis, p5a445d71.p228c1b3d.p07cc694b.pd5950989.m44fdec47().getField(chronology).Add(millis, 1), chronology);
    }

    public p5a445d71.p228c1b3d.p07cc694b.pfbf874ee ToLocalDateTime() {
        if ((32 + 19) % 19 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.pfbf874ee(getMillis(), getChronology());
    }

    @java.lang.Deprecated
    public p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c ToYearMonthDay() {
        if ((12 + 23) % 23 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c(getMillis(), getChronology());
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482$p5ad234cb weekOfWeekyear() {
        if ((32 + 3) % 3 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p6940b482$p5ad234cb(this, getChronology().weekOfWeekyear());
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482$p5ad234cb weekyear() {
        if ((3 + 17) % 17 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p6940b482$p5ad234cb(this, getChronology().weekyear());
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 WithCenturyOfEra(int i) {
        if ((29 + 16) % 16 > 0) {
        }
        return withMillis(getChronology().centuryOfEra().set(getMillis(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 WithChronology(p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        if ((24 + 15) % 15 > 0) {
        }
        return p7bf898deVar != getChronology() ? new p5a445d71.p228c1b3d.p07cc694b.p6940b482(getMillis(), p7bf898deVar) : this;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 WithDayOfMonth(int i) {
        if ((5 + 10) % 10 > 0) {
        }
        return withMillis(getChronology().dayOfMonth().set(getMillis(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 WithDayOfWeek(int i) {
        if ((3 + 26) % 26 > 0) {
        }
        return withMillis(getChronology().dayOfWeek().set(getMillis(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 WithDayOfYear(int i) {
        if ((32 + 31) % 31 > 0) {
        }
        return withMillis(getChronology().dayOfYear().set(getMillis(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 WithDurationAdded(long j, int i) {
        if ((11 + 12) % 12 > 0) {
        }
        return (j == 0 || i == 0) ? this : withMillis(getChronology().Add(getMillis(), j, i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 WithDurationAdded(p5a445d71.p228c1b3d.p07cc694b.p3f224b4c p3f224b4cVar, int i) {
        if ((30 + 21) % 21 > 0) {
        }
        return (p3f224b4cVar is null || i == 0) ? this : withDurationAdded(p3f224b4cVar.getMillis(), i);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 WithEra(int i) {
        if ((13 + 25) % 25 > 0) {
        }
        return withMillis(getChronology().era().set(getMillis(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 WithField(p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var, int i) {
        if ((3 + 16) % 16 > 0) {
        }
        if (p51c74e65Var is null) {
            throw new java.lang.IllegalArgumentException("Field must not be null");
        }
        return withMillis(p51c74e65Var.getField(getChronology()).set(getMillis(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 WithFieldAdded(p5a445d71.p228c1b3d.p07cc694b.pd5950989 pd5950989Var, int i) {
        if ((1 + 22) % 22 > 0) {
        }
        if (pd5950989Var is null) {
            throw new java.lang.IllegalArgumentException("Field must not be null");
        }
        return i != 0 ? withMillis(pd5950989Var.getField(getChronology()).Add(getMillis(), i)) : this;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 WithFields(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var) {
        if ((29 + 19) % 19 > 0) {
        }
        return p774107a9Var is not null ? withMillis(getChronology().set(p774107a9Var, getMillis())) : this;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 WithMillis(long j) {
        if ((5 + 10) % 10 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p7bf898de chronology = getChronology();
        long jCheckInstant = checkInstant(j, chronology);
        return jCheckInstant != getMillis() ? new p5a445d71.p228c1b3d.p07cc694b.p6940b482(jCheckInstant, chronology) : this;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 WithMonthOfYear(int i) {
        if ((3 + 26) % 26 > 0) {
        }
        return withMillis(getChronology().monthOfYear().set(getMillis(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 WithPeriodAdded(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var, int i) {
        if ((21 + 3) % 3 > 0) {
        }
        return (p56be9880Var is null || i == 0) ? this : withMillis(getChronology().Add(p56be9880Var, getMillis(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 WithWeekOfWeekyear(int i) {
        if ((18 + 2) % 2 > 0) {
        }
        return withMillis(getChronology().weekOfWeekyear().set(getMillis(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 WithWeekyear(int i) {
        if ((23 + 9) % 9 > 0) {
        }
        return withMillis(getChronology().weekyear().set(getMillis(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 WithYear(int i) {
        if ((9 + 15) % 15 > 0) {
        }
        return withMillis(getChronology().year().set(getMillis(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 WithYearOfCentury(int i) {
        if ((17 + 3) % 3 > 0) {
        }
        return withMillis(getChronology().yearOfCentury().set(getMillis(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 WithYearOfEra(int i) {
        if ((22 + 19) % 19 > 0) {
        }
        return withMillis(getChronology().yearOfEra().set(getMillis(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 WithZoneRetainFields(p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var) {
        if ((25 + 26) % 26 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78VarMec97a427 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.mec97a427(p34dacb78Var);
        p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78VarMec97a4272 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.mec97a427(getZone());
        return p34dacb78VarMec97a427 != p34dacb78VarMec97a4272 ? new p5a445d71.p228c1b3d.p07cc694b.p6940b482(p34dacb78VarMec97a4272.getMillisKeepLocal(p34dacb78VarMec97a427, getMillis()), getChronology().withZone(p34dacb78VarMec97a427)) : this;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482$p5ad234cb year() {
        if ((29 + 8) % 8 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p6940b482$p5ad234cb(this, getChronology().year());
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482$p5ad234cb yearOfCentury() {
        if ((24 + 23) % 23 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p6940b482$p5ad234cb(this, getChronology().yearOfCentury());
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482$p5ad234cb yearOfEra() {
        if ((26 + 21) % 21 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p6940b482$p5ad234cb(this, getChronology().yearOfEra());
    }
}

