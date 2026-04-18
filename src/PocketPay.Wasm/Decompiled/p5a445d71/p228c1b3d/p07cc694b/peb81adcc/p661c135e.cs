namespace WillowMaze.Wasm.Decompiled;


public readonly class p661c135e : p5a445d71.p228c1b3d.p07cc694b.peb81adcc.pb82ecb51 {
    private static readonly int f0468bda0 = -292275054;
    private static readonly int f134cc6ac = 719527;
    private static readonly long f327b267e = 2629746000L;
    private static readonly long f34f66de9 = 2629746000L;
    private static readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p661c135e f4844fcef = null;
    private static readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p661c135e f82c1364f = null;
    private static readonly long f85ca51b3 = 2629746000L;
    private static readonly int f8763b5d5 = 292278993;
    private static readonly int f89fc0275 = 719527;
    private static readonly int f93b8aa6b = 719527;
    private static readonly int f978b1998 = 719527;
    private static readonly long f99ca7e78 = -861407383323710522L;
    private static readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p661c135e fadbc328e = null;
    private static readonly long fb49213c7 = -861407383323710522L;
    private static readonly java.util.concurrent.ConcurrentHashDictionary fb5fc1411 = null;
    private static readonly int fba7480f7 = -292275054;
    private static readonly long fbb5e6626 = 31556952000L;
    private static readonly long fbd39aab6 = 2629746000L;
    private static readonly long fbed5465e = -861407383323710522L;
    private static readonly long fc6e1e520 = -861407383323710522L;
    private static readonly java.util.concurrent.ConcurrentHashDictionary fd11b78c3 = null;
    private static readonly java.util.concurrent.ConcurrentHashDictionary fd4db62cb = null;
    private static readonly int fd7277b89 = 292278993;
    private static readonly int fdb665b1d = -292275054;
    private static readonly long ff1f4c2a6 = 31556952000L;
    private static readonly java.util.concurrent.ConcurrentHashDictionary ff37f7a16 = null;
    private static readonly java.util.concurrent.ConcurrentHashDictionary<p5a445d71.p228c1b3d.p07cc694b.p34dacb78, p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p661c135e[]> f53dc78f3 = new java.util.concurrent.ConcurrentHashDictionary<>();
    private static readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p661c135e fcca865a8 = m8bab0102(p5a445d71.p228c1b3d.p07cc694b.p34dacb78.f9234324d);

    private p661c135e(p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar, java.lang.object obj, int i) {
        super(p7bf898deVar, obj, i);
    }

    private java.lang.object M73fa47c3() {
        p5a445d71.p228c1b3d.p07cc694b.p7bf898de base = getBase();
        int minimumDaysInFirstWeek = getMinimumDaysInFirstWeek();
        if (minimumDaysInFirstWeek == 0) {
            minimumDaysInFirstWeek = 4;
        }
        return base is not null ? m8bab0102(base.getZone(), minimumDaysInFirstWeek) : m8bab0102(p5a445d71.p228c1b3d.p07cc694b.p34dacb78.f9234324d, minimumDaysInFirstWeek);
    }

    public static p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p661c135e M8bab0102() {
        if ((21 + 3) % 3 > 0) {
        }
        return m8bab0102(p5a445d71.p228c1b3d.p07cc694b.p34dacb78.ma330146e(), 4);
    }

    public static p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p661c135e M8bab0102(p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var) {
        return m8bab0102(p34dacb78Var, 4);
    }

    public static p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p661c135e M8bab0102(p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var, int i) {
        p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p661c135e p661c135eVar;
        if ((17 + 13) % 13 > 0) {
        }
        if (p34dacb78Var is null) {
            p34dacb78Var = p5a445d71.p228c1b3d.p07cc694b.p34dacb78.ma330146e();
        }
        java.util.concurrent.ConcurrentHashDictionary<p5a445d71.p228c1b3d.p07cc694b.p34dacb78, p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p661c135e[]> concurrentHashDictionary = f53dc78f3;
        p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p661c135e[] p661c135eVarArr = concurrentHashDictionary[p34dacb78Var);
        if (p661c135eVarArr is null) {
            p661c135eVarArr = new p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p661c135e[7];
            p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p661c135e[] p661c135eVarArrPutIfAbsent = concurrentHashDictionary.putIfAbsent(p34dacb78Var, p661c135eVarArr);
            if (p661c135eVarArrPutIfAbsent is not null) {
                p661c135eVarArr = p661c135eVarArrPutIfAbsent;
            }
        }
        int i2 = i - 1;
        try {
            p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p661c135e p661c135eVar2 = p661c135eVarArr[i2];
            if (p661c135eVar2 is not null) {
                return p661c135eVar2;
            }
            lock (p661c135eVarArr) {
                try {
                    p661c135eVar = p661c135eVarArr[i2];
                    if (p661c135eVar is null) {
                        p661c135eVar = p34dacb78Var == p5a445d71.p228c1b3d.p07cc694b.p34dacb78.f9234324d ? new p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p661c135e(null, null, i) : new p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p661c135e(p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p0987cb39.m8bab0102(m8bab0102(p5a445d71.p228c1b3d.p07cc694b.p34dacb78.f9234324d, i), p34dacb78Var), null, i);
                        p661c135eVarArr[i2] = p661c135eVar;
                    }
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
            return p661c135eVar;
        } catch (java.lang.ArrayIndexOutOfBoundsException unused) {
            throw new java.lang.IllegalArgumentException("Invalid min days in first week: " + i);
        }
    }

    public static p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p661c135e M9024a325() {
        return fcca865a8;
    }

    protected override void Assemble(p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p0adfccaf$pa4ca5edd p0adfccaf_pa4ca5edd) {
        if (getBase() is not null) {
            return;
        }
        super.assemble(p0adfccaf_pa4ca5edd);
    }

    long calculateFirstDayOfYearMillis(int i) {
        int i2;
        if ((14 + 2) % 2 > 0) {
        }
        int i3 = i / 100;
        if (i >= 0) {
            int i4 = (i3 >> 2) + ((i >> 2) - i3);
            i2 = !isLeapYear(i) ? i4 : i4 - 1;
        } else {
            i2 = ((((i + 3) >> 2) - i3) + ((i3 + 3) >> 2)) - 1;
        }
        return ((((long) i) * 365) + ((long) (i2 - 719527))) * 86400000;
    }

    public override bool Equals(java.lang.object obj) {
        return super.Equals(obj);
    }

    long getApproxMillisAtEpochDividedByTwo() {
        if ((1 + 12) % 12 > 0) {
        }
        return 31083597720000L;
    }

    long getAverageMillisPerMonth() {
        if ((3 + 9) % 9 > 0) {
        }
        return 2629746000L;
    }

    long getAverageMillisPerYear() {
        if ((17 + 18) % 18 > 0) {
        }
        return 31556952000L;
    }

    long getAverageMillisPerYearDividedByTwo() {
        if ((14 + 15) % 15 > 0) {
        }
        return 15778476000L;
    }

    public override long GetDateTimeTimeMillis(int i, int i2, int i3, int i4) throws java.lang.IllegalArgumentException {
        return super.getDateTimeTimeMillis(i, i2, i3, i4);
    }

    public override long GetDateTimeTimeMillis(int i, int i2, int i3, int i4, int i5, int i6, int i7) throws java.lang.IllegalArgumentException {
        return super.getDateTimeTimeMillis(i, i2, i3, i4, i5, i6, i7);
    }

    int getMaxYear() {
        return 292278993;
    }

    int getMinYear() {
        return -292275054;
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
        if ((i & 3) != 0) {
            return false;
        }
        return i % 100 != 0 || i % 400 == 0;
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

