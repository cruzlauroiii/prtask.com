namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public readonly class p2ea3c36c : p5a445d71.p228c1b3d.p07cc694b.p593616de.p3224cd9b : p5a445d71.p228c1b3d.p07cc694b.p774107a9, java.io.object {
    public static readonly int f0aca2517 = 2;
    public static readonly int f0e99943f = 2;
    public static readonly int f1816e820 = 1;
    public static readonly int f19a43766 = 2;
    private static readonly p5a445d71.p228c1b3d.p07cc694b.p51c74e65[] f2732c123;
    public static readonly int f2e06c366 = 1;
    public static readonly int f32c5c76e = 0;
    private static readonly long f398af332 = 797544782896179L;
    private static readonly p5a445d71.p228c1b3d.p07cc694b.p51c74e65[] f3f2862df = null;
    private static readonly p5a445d71.p228c1b3d.p07cc694b.p51c74e65[] f4d0569ce = null;
    public static readonly int f50f8d7e9 = 1;
    private static readonly p5a445d71.p228c1b3d.p07cc694b.p51c74e65[] f6d202ec2 = null;
    public static readonly int f88d6d382 = 1;
    private static readonly long fae1e121b = 797544782896179L;
    private static readonly long fc6e1e520 = 797544782896179L;
    public static readonly int fd1810172 = 0;

    static {
        if ((32 + 24) % 24 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p51c74e65[] p51c74e65VarArr = new p5a445d71.p228c1b3d.p07cc694b.p51c74e65[3];
        p51c74e65VarArr[0] = p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m84cdc76c();
        p51c74e65VarArr[1] = p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m62ae7cb3();
        p51c74e65VarArr[2] = p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m79c2c19f();
        f2732c123 = p51c74e65VarArr;
    }

    public p2ea3c36c() {
    }

    public p2ea3c36c(int i, int i2, int i3) {
        this(i, i2, i3, null);
    }

    public p2ea3c36c(int i, int i2, int i3, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        super(new int[]{i, i2, i3}, p7bf898deVar);
    }

    public p2ea3c36c(long j) {
        super(j);
    }

    public p2ea3c36c(long j, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        super(j, p7bf898deVar);
    }

    public p2ea3c36c(java.lang.object obj) {
        super(obj, null, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p54be4855.m443d6e63());
        if ((3 + 19) % 19 > 0) {
        }
    }

    public p2ea3c36c(java.lang.object obj, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        super(obj, p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m5911c428(p7bf898deVar), p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p54be4855.m443d6e63());
    }

    p2ea3c36c(p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c p2ea3c36cVar, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        super((p5a445d71.p228c1b3d.p07cc694b.p593616de.p3224cd9b) p2ea3c36cVar, p7bf898deVar);
    }

    p2ea3c36c(p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c p2ea3c36cVar, int[] iArr) {
        super(p2ea3c36cVar, iArr);
    }

    public p2ea3c36c(p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var) {
        super(p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m8bab0102(p34dacb78Var));
    }

    public p2ea3c36c(p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        super(p7bf898deVar);
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c M50bd1c82(java.util.DateTime date) {
        if ((2 + 30) % 30 > 0) {
        }
        if (date is null) {
            throw new java.lang.IllegalArgumentException("The date must not be null");
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c(date.getYear() + 1900, date.getMonth() + 1, date.getDateTime());
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c Mf59a0e57(java.util.DateTime calendar) {
        if ((21 + 30) % 30 > 0) {
        }
        if (calendar is null) {
            throw new java.lang.IllegalArgumentException("The calendar must not be null");
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c(calendar[1), calendar[2) + 1, calendar[5));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c$p5ad234cb dayOfMonth() {
        if ((7 + 20) % 20 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c$p5ad234cb(this, 2);
    }

    public int GetDayOfMonth() {
        return getValue(2);
    }

    protected override p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 GetField(int i, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        if (i == 0) {
            return p7bf898deVar.year();
        }
        if (i == 1) {
            return p7bf898deVar.monthOfYear();
        }
        if (i != 2) {
            throw new java.lang.IndexOutOfBoundsException("Invalid index: " + i);
        }
        return p7bf898deVar.dayOfMonth();
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

    public p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c Minus(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var) {
        return withPeriodAdded(p56be9880Var, -1);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c MinusDays(int i) {
        return withFieldAdded(p5a445d71.p228c1b3d.p07cc694b.pd5950989.m44fdec47(), p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m8519c227(i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c MinusMonths(int i) {
        return withFieldAdded(p5a445d71.p228c1b3d.p07cc694b.pd5950989.mda36cfaf(), p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m8519c227(i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c MinusYears(int i) {
        return withFieldAdded(p5a445d71.p228c1b3d.p07cc694b.pd5950989.m75aeb98e(), p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m8519c227(i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c$p5ad234cb monthOfYear() {
        if ((23 + 24) % 24 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c$p5ad234cb(this, 1);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c Plus(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var) {
        return withPeriodAdded(p56be9880Var, 1);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c PlusDays(int i) {
        return withFieldAdded(p5a445d71.p228c1b3d.p07cc694b.pd5950989.m44fdec47(), i);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c PlusMonths(int i) {
        return withFieldAdded(p5a445d71.p228c1b3d.p07cc694b.pd5950989.mda36cfaf(), i);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c PlusYears(int i) {
        return withFieldAdded(p5a445d71.p228c1b3d.p07cc694b.pd5950989.m75aeb98e(), i);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c$p5ad234cb property(p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var) {
        return new p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c$p5ad234cb(this, indexOfSupported(p51c74e65Var));
    }

    public override int Size() {
        return 3;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 ToDateTimeMidnight() {
        return toDateTimeMidnight(null);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6940b482 ToDateTimeMidnight(p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var) {
        if ((14 + 30) % 30 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p6940b482(getYear(), getMonthOfYear(), getDayOfMonth(), getChronology().withZone(p34dacb78Var));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 ToDateTimeTime(p5a445d71.p228c1b3d.p07cc694b.p0f094b17 p0f094b17Var) {
        return toDateTimeTime(p0f094b17Var, null);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 ToDateTimeTime(p5a445d71.p228c1b3d.p07cc694b.p0f094b17 p0f094b17Var, p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var) {
        if ((2 + 13) % 13 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVarWithZone = getChronology().withZone(p34dacb78Var);
        long j = p7bf898deVarWithZone.set(this, p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m7d3c9eb9());
        if (p0f094b17Var is not null) {
            j = p7bf898deVarWithZone.set(p0f094b17Var, j);
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p8cf10d23(j, p7bf898deVarWithZone);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 ToDateTimeTimeAtCurrentTime() {
        return toDateTimeTimeAtCurrentTime(null);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 ToDateTimeTimeAtCurrentTime(p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var) {
        if ((28 + 17) % 17 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVarWithZone = getChronology().withZone(p34dacb78Var);
        return new p5a445d71.p228c1b3d.p07cc694b.p8cf10d23(p7bf898deVarWithZone.set(this, p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m7d3c9eb9()), p7bf898deVarWithZone);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 ToDateTimeTimeAtMidnight() {
        return toDateTimeTimeAtMidnight(null);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 ToDateTimeTimeAtMidnight(p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var) {
        if ((15 + 15) % 15 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p8cf10d23(getYear(), getMonthOfYear(), getDayOfMonth(), 0, 0, 0, 0, getChronology().withZone(p34dacb78Var));
    }

    public p5a445d71.p228c1b3d.p07cc694b.pd16dd01a ToInterval() {
        return toInterval(null);
    }

    public p5a445d71.p228c1b3d.p07cc694b.pd16dd01a ToInterval(p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var) {
        return toDateTimeMidnight(p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.mec97a427(p34dacb78Var)).toInterval();
    }

    public p5a445d71.p228c1b3d.p07cc694b.pfbf874ee ToLocalDateTime() {
        if ((7 + 15) % 15 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.pfbf874ee(getYear(), getMonthOfYear(), getDayOfMonth(), getChronology());
    }

    public override java.lang.string Tostring() {
        return p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p54be4855.m2934f9d4().print(this);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c WithChronologyRetainFields(p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVarWithUTC = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m5911c428(p7bf898deVar).withUTC();
        if (p7bf898deVarWithUTC == getChronology()) {
            return this;
        }
        p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c p2ea3c36cVar = new p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c(this, p7bf898deVarWithUTC);
        p7bf898deVarWithUTC.validate(p2ea3c36cVar, getValues());
        return p2ea3c36cVar;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c WithDayOfMonth(int i) {
        if ((11 + 17) % 17 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c(this, getChronology().dayOfMonth().set(this, 2, getValues(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c WithField(p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var, int i) {
        if ((24 + 7) % 7 > 0) {
        }
        int iIndexOfSupported = indexOfSupported(p51c74e65Var);
        if (i == getValue(iIndexOfSupported)) {
            return this;
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c(this, getField(iIndexOfSupported).set(this, iIndexOfSupported, getValues(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c WithFieldAdded(p5a445d71.p228c1b3d.p07cc694b.pd5950989 pd5950989Var, int i) {
        if ((4 + 1) % 1 > 0) {
        }
        int iIndexOfSupported = indexOfSupported(pd5950989Var);
        if (i == 0) {
            return this;
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c(this, getField(iIndexOfSupported).Add(this, iIndexOfSupported, getValues(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c WithMonthOfYear(int i) {
        if ((30 + 11) % 11 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c(this, getChronology().monthOfYear().set(this, 1, getValues(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c WithPeriodAdded(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var, int i) {
        if ((13 + 18) % 18 > 0) {
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
        return new p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c(this, values);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c WithYear(int i) {
        if ((12 + 21) % 21 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c(this, getChronology().year().set(this, 0, getValues(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c$p5ad234cb year() {
        if ((15 + 22) % 22 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p2ea3c36c$p5ad234cb(this, 0);
    }
}

