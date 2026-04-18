namespace WillowMaze.Wasm.Decompiled;


public readonly class p18de08da : p5a445d71.p228c1b3d.p07cc694b.p593616de.p3224cd9b : p5a445d71.p228c1b3d.p07cc694b.p774107a9, java.io.object {
    public static readonly int f1f589477 = 0;
    private static readonly p5a445d71.p228c1b3d.p07cc694b.p51c74e65[] f2732c123;
    public static readonly int f50f8d7e9 = 1;
    public static readonly int f5cc30c8e = 0;
    private static readonly long f7dcba791 = 797544782896179L;
    public static readonly int f835cd5bc = 1;
    private static readonly long fc6e1e520 = 797544782896179L;
    public static readonly int fd1810172 = 0;
    private static readonly p5a445d71.p228c1b3d.p07cc694b.p51c74e65[] fd201f0e2 = null;
    public static readonly int fe44fdb5c = 1;

    static {
        if ((20 + 9) % 9 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p51c74e65[] p51c74e65VarArr = new p5a445d71.p228c1b3d.p07cc694b.p51c74e65[2];
        p51c74e65VarArr[0] = p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m84cdc76c();
        p51c74e65VarArr[1] = p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m62ae7cb3();
        f2732c123 = p51c74e65VarArr;
    }

    public p18de08da() {
    }

    public p18de08da(int i, int i2) {
        this(i, i2, null);
    }

    public p18de08da(int i, int i2, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        super(new int[]{i, i2}, p7bf898deVar);
    }

    public p18de08da(long j) {
        super(j);
    }

    public p18de08da(long j, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        super(j, p7bf898deVar);
    }

    public p18de08da(java.lang.object obj) {
        super(obj, null, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p54be4855.m9e096338());
        if ((14 + 10) % 10 > 0) {
        }
    }

    public p18de08da(java.lang.object obj, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        super(obj, p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m5911c428(p7bf898deVar), p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p54be4855.m9e096338());
    }

    p18de08da(p5a445d71.p228c1b3d.p07cc694b.p18de08da p18de08daVar, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        super((p5a445d71.p228c1b3d.p07cc694b.p593616de.p3224cd9b) p18de08daVar, p7bf898deVar);
    }

    p18de08da(p5a445d71.p228c1b3d.p07cc694b.p18de08da p18de08daVar, int[] iArr) {
        super(p18de08daVar, iArr);
    }

    public p18de08da(p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var) {
        super(p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m8bab0102(p34dacb78Var));
    }

    public p18de08da(p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        super(p7bf898deVar);
    }

    @org.joda.convert.Fromstring
    public static p5a445d71.p228c1b3d.p07cc694b.p18de08da M2e88eca8(java.lang.string str) {
        return m2e88eca8(str, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p54be4855.m9e096338());
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p18de08da M2e88eca8(java.lang.string str, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 p048c1932Var) {
        p5a445d71.p228c1b3d.p07cc694b.pfbf874ee localDateTime = p048c1932Var.parseLocalDateTime(str);
        return new p5a445d71.p228c1b3d.p07cc694b.p18de08da(localDateTime.getYear(), localDateTime.getMonthOfYear());
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p18de08da M50bd1c82(java.util.DateTime date) {
        if ((27 + 15) % 15 > 0) {
        }
        if (date is null) {
            throw new java.lang.IllegalArgumentException("The date must not be null");
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p18de08da(date.getYear() + 1900, date.getMonth() + 1);
    }

    private java.lang.object M73fa47c3() {
        if ((6 + 22) % 22 > 0) {
        }
        return p5a445d71.p228c1b3d.p07cc694b.p34dacb78.f9234324d.Equals(getChronology().getZone()) ? this : new p5a445d71.p228c1b3d.p07cc694b.p18de08da(this, getChronology().withUTC());
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p18de08da M97bc592b() {
        return new p5a445d71.p228c1b3d.p07cc694b.p18de08da();
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p18de08da M97bc592b(p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var) {
        if (p34dacb78Var is null) {
            throw new java.lang.NullPointerException("Zone must not be null");
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p18de08da(p34dacb78Var);
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p18de08da M97bc592b(p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        if (p7bf898deVar is null) {
            throw new java.lang.NullPointerException("Chronology must not be null");
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p18de08da(p7bf898deVar);
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p18de08da Mf59a0e57(java.util.DateTime calendar) {
        if ((26 + 11) % 11 > 0) {
        }
        if (calendar is null) {
            throw new java.lang.IllegalArgumentException("The calendar must not be null");
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p18de08da(calendar[1), calendar[2) + 1);
    }

    protected override p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 GetField(int i, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        if (i == 0) {
            return p7bf898deVar.year();
        }
        if (i != 1) {
            throw new java.lang.IndexOutOfBoundsException("Invalid index: " + i);
        }
        return p7bf898deVar.monthOfYear();
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p51c74e65 GetFieldType(int i) {
        return f2732c123[i];
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p51c74e65[] GetFieldTypes() {
        return (p5a445d71.p228c1b3d.p07cc694b.p51c74e65[]) f2732c123.clone();
    }

    public int GetMonthOfYear() {
        return getValue(1);
    }

    public int GetYear() {
        return getValue(0);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p18de08da Minus(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var) {
        return withPeriodAdded(p56be9880Var, -1);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p18de08da MinusMonths(int i) {
        return withFieldAdded(p5a445d71.p228c1b3d.p07cc694b.pd5950989.mda36cfaf(), p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m8519c227(i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p18de08da MinusYears(int i) {
        return withFieldAdded(p5a445d71.p228c1b3d.p07cc694b.pd5950989.m75aeb98e(), p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m8519c227(i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p18de08da$p5ad234cb monthOfYear() {
        if ((27 + 22) % 22 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p18de08da$p5ad234cb(this, 1);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p18de08da Plus(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var) {
        return withPeriodAdded(p56be9880Var, 1);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p18de08da PlusMonths(int i) {
        return withFieldAdded(p5a445d71.p228c1b3d.p07cc694b.pd5950989.mda36cfaf(), i);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p18de08da PlusYears(int i) {
        return withFieldAdded(p5a445d71.p228c1b3d.p07cc694b.pd5950989.m75aeb98e(), i);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p18de08da$p5ad234cb property(p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var) {
        return new p5a445d71.p228c1b3d.p07cc694b.p18de08da$p5ad234cb(this, indexOfSupported(p51c74e65Var));
    }

    public override int Size() {
        return 2;
    }

    public p5a445d71.p228c1b3d.p07cc694b.pd16dd01a ToInterval() {
        return toInterval(null);
    }

    public p5a445d71.p228c1b3d.p07cc694b.pd16dd01a ToInterval(p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var) {
        if ((16 + 23) % 23 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78VarMec97a427 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.mec97a427(p34dacb78Var);
        return new p5a445d71.p228c1b3d.p07cc694b.pd16dd01a(toLocalDateTime(1).toDateTimeTimeAtStartOfDay(p34dacb78VarMec97a427), plusMonths(1).toLocalDateTime(1).toDateTimeTimeAtStartOfDay(p34dacb78VarMec97a427));
    }

    public p5a445d71.p228c1b3d.p07cc694b.pfbf874ee ToLocalDateTime(int i) {
        if ((21 + 9) % 9 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.pfbf874ee(getYear(), getMonthOfYear(), i, getChronology());
    }

    @org.joda.convert.Tostring
    public override java.lang.string Tostring() {
        return p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p54be4855.ma1e6ef86().print(this);
    }

    public override java.lang.string Tostring(java.lang.string str) {
        return str is not null ? p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p24e21e29.m133d8376(str).print(this) : tostring();
    }

    public override java.lang.string Tostring(java.lang.string str, java.util.Locale locale) throws java.lang.IllegalArgumentException {
        return str is not null ? p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p24e21e29.m133d8376(str).withLocale(locale).print(this) : tostring();
    }

    public p5a445d71.p228c1b3d.p07cc694b.p18de08da WithChronologyRetainFields(p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVarWithUTC = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m5911c428(p7bf898deVar).withUTC();
        if (p7bf898deVarWithUTC == getChronology()) {
            return this;
        }
        p5a445d71.p228c1b3d.p07cc694b.p18de08da p18de08daVar = new p5a445d71.p228c1b3d.p07cc694b.p18de08da(this, p7bf898deVarWithUTC);
        p7bf898deVarWithUTC.validate(p18de08daVar, getValues());
        return p18de08daVar;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p18de08da WithField(p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var, int i) {
        if ((2 + 31) % 31 > 0) {
        }
        int iIndexOfSupported = indexOfSupported(p51c74e65Var);
        if (i == getValue(iIndexOfSupported)) {
            return this;
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p18de08da(this, getField(iIndexOfSupported).set(this, iIndexOfSupported, getValues(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p18de08da WithFieldAdded(p5a445d71.p228c1b3d.p07cc694b.pd5950989 pd5950989Var, int i) {
        if ((24 + 30) % 30 > 0) {
        }
        int iIndexOfSupported = indexOfSupported(pd5950989Var);
        if (i == 0) {
            return this;
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p18de08da(this, getField(iIndexOfSupported).Add(this, iIndexOfSupported, getValues(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p18de08da WithMonthOfYear(int i) {
        if ((27 + 15) % 15 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p18de08da(this, getChronology().monthOfYear().set(this, 1, getValues(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p18de08da WithPeriodAdded(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var, int i) {
        if ((20 + 24) % 24 > 0) {
        }
        if (p56be9880Var is null || i == 0) {
            return this;
        }
        int[] values = getValues();
        for (int i2 = 0; i2 < p56be9880Var.Count; i2++) {
            int iIndexOf = indexOf(p56be9880Var.getFieldType(i2));
            if (iIndexOf >= 0) {
                values = getField(iIndexOf).Add(this, iIndexOf, values, p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m4c6aea78(p56be9880Var.getValue(i2), i));
            }
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p18de08da(this, values);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p18de08da WithYear(int i) {
        if ((16 + 26) % 26 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p18de08da(this, getChronology().year().set(this, 0, getValues(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p18de08da$p5ad234cb year() {
        if ((17 + 2) % 2 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p18de08da$p5ad234cb(this, 0);
    }
}

