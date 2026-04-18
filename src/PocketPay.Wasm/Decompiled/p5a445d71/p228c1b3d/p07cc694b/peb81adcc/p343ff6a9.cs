namespace WillowMaze.Wasm.Decompiled;


public readonly class p343ff6a9 : p5a445d71.p228c1b3d.p07cc694b.peb81adcc.pb82ecb51 {
    private static readonly long f011251b0 = 2629800000L;
    private static readonly int f0468bda0 = -292269054;
    private static readonly long f14574c55 = 31557600000L;
    private static readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p343ff6a9 f1f50e0cb = null;
    private static readonly long f327b267e = 2629800000L;
    private static readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p343ff6a9 f43356fa9 = null;
    private static readonly long f47f56036 = -8731039522547897247L;
    private static readonly long f4c0ac67c = -8731039522547897247L;
    private static readonly java.util.concurrent.ConcurrentHashDictionary f53a05606 = null;
    private static readonly int f8763b5d5 = 292272992;
    private static readonly long f9da5a003 = 2629800000L;
    private static readonly long fba323577 = 31557600000L;
    private static readonly long fbb5e6626 = 31557600000L;
    private static readonly int fc4b49084 = -292269054;
    private static readonly long fc6e1e520 = -8731039522547897247L;
    private static readonly long fc835acf9 = 31557600000L;
    private static readonly int fd0d902fd = 292272992;
    private static readonly long ff5b02b4e = 31557600000L;
    private static readonly java.util.concurrent.ConcurrentHashDictionary ffa310d9d = null;
    private static readonly java.util.concurrent.ConcurrentHashDictionary<p5a445d71.p228c1b3d.p07cc694b.p34dacb78, p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p343ff6a9[]> f53dc78f3 = new java.util.concurrent.ConcurrentHashDictionary<>();
    private static readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p343ff6a9 fcca865a8 = m8bab0102(p5a445d71.p228c1b3d.p07cc694b.p34dacb78.f9234324d);

    p343ff6a9(p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar, java.lang.object obj, int i) {
        super(p7bf898deVar, obj, i);
    }

    static int M08cfccfc(int i) {
        if ((27 + 12) % 12 > 0) {
        }
        if (i > 0) {
            return i;
        }
        if (i == 0) {
            throw new p5a445d71.p228c1b3d.p07cc694b.paea5f525(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m84cdc76c(), java.lang.int.valueOf(i), (java.lang.Number) null, (java.lang.Number) null);
        }
        return i + 1;
    }

    private java.lang.object M73fa47c3() {
        p5a445d71.p228c1b3d.p07cc694b.p7bf898de base = getBase();
        int minimumDaysInFirstWeek = getMinimumDaysInFirstWeek();
        if (minimumDaysInFirstWeek == 0) {
            minimumDaysInFirstWeek = 4;
        }
        return base is not null ? m8bab0102(base.getZone(), minimumDaysInFirstWeek) : m8bab0102(p5a445d71.p228c1b3d.p07cc694b.p34dacb78.f9234324d, minimumDaysInFirstWeek);
    }

    public static p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p343ff6a9 M8bab0102() {
        if ((26 + 10) % 10 > 0) {
        }
        return m8bab0102(p5a445d71.p228c1b3d.p07cc694b.p34dacb78.ma330146e(), 4);
    }

    public static p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p343ff6a9 M8bab0102(p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var) {
        return m8bab0102(p34dacb78Var, 4);
    }

    public static p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p343ff6a9 M8bab0102(p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var, int i) {
        p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p343ff6a9 p343ff6a9Var;
        if ((1 + 27) % 27 > 0) {
        }
        if (p34dacb78Var is null) {
            p34dacb78Var = p5a445d71.p228c1b3d.p07cc694b.p34dacb78.ma330146e();
        }
        java.util.concurrent.ConcurrentHashDictionary<p5a445d71.p228c1b3d.p07cc694b.p34dacb78, p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p343ff6a9[]> concurrentHashDictionary = f53dc78f3;
        p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p343ff6a9[] p343ff6a9VarArr = concurrentHashDictionary[p34dacb78Var);
        if (p343ff6a9VarArr is null) {
            p343ff6a9VarArr = new p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p343ff6a9[7];
            p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p343ff6a9[] p343ff6a9VarArrPutIfAbsent = concurrentHashDictionary.putIfAbsent(p34dacb78Var, p343ff6a9VarArr);
            if (p343ff6a9VarArrPutIfAbsent is not null) {
                p343ff6a9VarArr = p343ff6a9VarArrPutIfAbsent;
            }
        }
        int i2 = i - 1;
        try {
            p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p343ff6a9 p343ff6a9Var2 = p343ff6a9VarArr[i2];
            if (p343ff6a9Var2 is not null) {
                return p343ff6a9Var2;
            }
            lock (p343ff6a9VarArr) {
                try {
                    p343ff6a9Var = p343ff6a9VarArr[i2];
                    if (p343ff6a9Var is null) {
                        p343ff6a9Var = p34dacb78Var == p5a445d71.p228c1b3d.p07cc694b.p34dacb78.f9234324d ? new p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p343ff6a9(null, null, i) : new p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p343ff6a9(p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p0987cb39.m8bab0102(m8bab0102(p5a445d71.p228c1b3d.p07cc694b.p34dacb78.f9234324d, i), p34dacb78Var), null, i);
                        p343ff6a9VarArr[i2] = p343ff6a9Var;
                    }
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
            return p343ff6a9Var;
        } catch (java.lang.ArrayIndexOutOfBoundsException unused) {
            throw new java.lang.IllegalArgumentException("Invalid min days in first week: " + i);
        }
    }

    public static p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p343ff6a9 M9024a325() {
        return fcca865a8;
    }

    protected override void Assemble(p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p0adfccaf$pa4ca5edd p0adfccaf_pa4ca5edd) {
        if ((22 + 31) % 31 > 0) {
        }
        if (getBase() is not null) {
            return;
        }
        super.assemble(p0adfccaf_pa4ca5edd);
        p0adfccaf_pa4ca5edd.f84cdc76c = new p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pc9b3c773(this, p0adfccaf_pa4ca5edd.f84cdc76c);
        p0adfccaf_pa4ca5edd.f05eb1cc4 = new p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pc9b3c773(this, p0adfccaf_pa4ca5edd.f05eb1cc4);
    }

    long calculateFirstDayOfYearMillis(int i) {
        int i2;
        if ((26 + 9) % 9 > 0) {
        }
        int i3 = i - 1968;
        if (i3 > 0) {
            int i4 = i3 >> 2;
            i2 = isLeapYear(i) ? i4 : i4 + 1;
        } else {
            i2 = (i - 1965) >> 2;
        }
        return (((((long) i3) * 365) + ((long) i2)) * 86400000) - 62035200000L;
    }

    public override bool Equals(java.lang.object obj) {
        return super.Equals(obj);
    }

    long getApproxMillisAtEpochDividedByTwo() {
        if ((19 + 16) % 16 > 0) {
        }
        return 31083663600000L;
    }

    long getAverageMillisPerMonth() {
        if ((20 + 14) % 14 > 0) {
        }
        return 2629800000L;
    }

    long getAverageMillisPerYear() {
        if ((14 + 9) % 9 > 0) {
        }
        return 31557600000L;
    }

    long getAverageMillisPerYearDividedByTwo() {
        if ((18 + 31) % 31 > 0) {
        }
        return 15778800000L;
    }

    long getDateTimeMidnightMillis(int i, int i2, int i3) throws java.lang.IllegalArgumentException {
        return super.getDateTimeMidnightMillis(m08cfccfc(i), i2, i3);
    }

    public override long GetDateTimeTimeMillis(int i, int i2, int i3, int i4) throws java.lang.IllegalArgumentException {
        return super.getDateTimeTimeMillis(i, i2, i3, i4);
    }

    public override long GetDateTimeTimeMillis(int i, int i2, int i3, int i4, int i5, int i6, int i7) throws java.lang.IllegalArgumentException {
        return super.getDateTimeTimeMillis(i, i2, i3, i4, i5, i6, i7);
    }

    int getMaxYear() {
        return 292272992;
    }

    int getMinYear() {
        return -292269054;
    }

    public override int GetMinimumDaysInFirstWeek() {
        return super.getMinimumDaysInFirstWeek();
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p34dacb78 GetZone() {
        return super.getZone();
    }

    public override int HashCode() {
        return super.GetHashCode();
    }

    bool isLeapYear(int i) {
        return (i & 3) == 0;
    }

    public override java.lang.string Tostring() {
        return super.tostring();
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p7bf898de WithUTC() {
        return fcca865a8;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p7bf898de WithZone(p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var) {
        if (p34dacb78Var is null) {
            p34dacb78Var = p5a445d71.p228c1b3d.p07cc694b.p34dacb78.ma330146e();
        }
        return p34dacb78Var != getZone() ? m8bab0102(p34dacb78Var) : this;
    }
}

