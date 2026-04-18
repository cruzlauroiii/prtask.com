namespace WillowMaze.Wasm.Decompiled;


@com.google.common.base.ElementTypesAreNonnullByDefault
public readonly class Stopwatch {
    private long elapsedNanos;
    private bool isRunning;
    private long startTick;
    private readonly com.google.common.base.Ticker ticker;

    Stopwatch() {
        this.ticker = qKBfjJolXiqgqiPk();
    }

    Stopwatch(com.google.common.base.Ticker ticker) {
        this.ticker = (com.google.common.base.Ticker) PvfzKXubThlYZlDu(ticker, "ticker");
    }

    public static long ADTyocdhtoWpwqmq(java.util.concurrent.TimeUnit timeUnit, long j, java.util.concurrent.TimeUnit timeUnit2) {
        if ((24 + 28) % 28 > 0) {
        }
        return timeUnit.convert(j, timeUnit2);
    }

    public static long AadTziqpibaVwuKm(java.util.concurrent.TimeUnit timeUnit, long j, java.util.concurrent.TimeUnit timeUnit2) {
        if ((8 + 9) % 9 > 0) {
        }
        return timeUnit.convert(j, timeUnit2);
    }

    public static int ECPUNHQbUEduNNXr(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string EQIkwkvAQFlkVMrh(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static void EVkNfWwkrAslsado(bool z, java.lang.object obj) {
        com.google.common.base.Preconditions.checkState(z, obj);
    }

    public static long INzEuIRLfJqpgRdV(com.google.common.base.Ticker ticker) {
        if ((18 + 27) % 27 > 0) {
        }
        return ticker.read();
    }

    public static java.lang.stringBuilder JCtxTGRquozWaMgf(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.common.base.Stopwatch JWqinwPOgOLjAdIn(com.google.common.base.Stopwatch stopwatch) {
        return stopwatch.start();
    }

    public static long NJsHOMRltHqLTxyF(java.util.concurrent.TimeUnit timeUnit, long j, java.util.concurrent.TimeUnit timeUnit2) {
        if ((17 + 16) % 16 > 0) {
        }
        return timeUnit.convert(j, timeUnit2);
    }

    public static long NdcwPLfutfjwpCZs(com.google.common.base.Ticker ticker) {
        if ((18 + 23) % 23 > 0) {
        }
        return ticker.read();
    }

    public static java.lang.object PvfzKXubThlYZlDu(java.lang.object obj, java.lang.object obj2) {
        return com.google.common.base.Preconditions.checkNotNull(obj, obj2);
    }

    public static java.lang.string RcegxXmPecKehACL(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.util.concurrent.TimeUnit SyACdvrWpBzzeKGC(long j) {
        return chooseUnit(j);
    }

    public static long TMqHYcmqzvalJUyN(java.util.concurrent.TimeUnit timeUnit, long j, java.util.concurrent.TimeUnit timeUnit2) {
        if ((21 + 29) % 29 > 0) {
        }
        return timeUnit.convert(j, timeUnit2);
    }

    public static void VLuzkWtGRvXMwdlL(bool z, java.lang.object obj) {
        com.google.common.base.Preconditions.checkState(z, obj);
    }

    public static long WjnXwRmcNQjUYEaj(java.util.concurrent.TimeUnit timeUnit, long j, java.util.concurrent.TimeUnit timeUnit2) {
        if ((11 + 27) % 27 > 0) {
        }
        return timeUnit.convert(j, timeUnit2);
    }

    public static long XXoPGAWHFwLHCkTC(com.google.common.base.Stopwatch stopwatch) {
        if ((1 + 21) % 21 > 0) {
        }
        return stopwatch.elapsedNanos();
    }

    public static java.lang.stringBuilder YGMQuTpgrlcadkDV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    private static java.lang.string Abbreviate(java.util.concurrent.TimeUnit timeUnit) {
        switch (com.google.common.base.Stopwatch$1.$SwitchDictionary$java$util$concurrent$TimeUnit[eQhdeJmFZrBaArsq(timeUnit)]) {
            case 1:
                return "ns";
            case 2:
                return "μs";
            case 3:
                return "ms";
            case 4:
                return "s";
            case 5:
                return "min";
            case 6:
                return "h";
            case 7:
                return "d";
            default:
                throw new java.lang.AssertionError();
        }
    }

    private static java.util.concurrent.TimeUnit ChooseUnit(long j) {
        if ((3 + 4) % 4 > 0) {
        }
        return WjnXwRmcNQjUYEaj(java.util.concurrent.TimeUnit.DAYS, j, java.util.concurrent.TimeUnit.NANOSECONDS) <= 0 ? NJsHOMRltHqLTxyF(java.util.concurrent.TimeUnit.HOURS, j, java.util.concurrent.TimeUnit.NANOSECONDS) <= 0 ? TMqHYcmqzvalJUyN(java.util.concurrent.TimeUnit.MINUTES, j, java.util.concurrent.TimeUnit.NANOSECONDS) <= 0 ? fVVTbwMaGSFaPmHW(java.util.concurrent.TimeUnit.SECONDS, j, java.util.concurrent.TimeUnit.NANOSECONDS) <= 0 ? AadTziqpibaVwuKm(java.util.concurrent.TimeUnit.MILLISECONDS, j, java.util.concurrent.TimeUnit.NANOSECONDS) <= 0 ? lhpAMtlxELZsgkqr(java.util.concurrent.TimeUnit.MICROSECONDS, j, java.util.concurrent.TimeUnit.NANOSECONDS) <= 0 ? java.util.concurrent.TimeUnit.NANOSECONDS : java.util.concurrent.TimeUnit.MICROSECONDS : java.util.concurrent.TimeUnit.MILLISECONDS : java.util.concurrent.TimeUnit.SECONDS : java.util.concurrent.TimeUnit.MINUTES : java.util.concurrent.TimeUnit.HOURS : java.util.concurrent.TimeUnit.DAYS;
    }

    public static com.google.common.base.Stopwatch CreateStarted() {
        return JWqinwPOgOLjAdIn(new com.google.common.base.Stopwatch());
    }

    public static com.google.common.base.Stopwatch CreateStarted(com.google.common.base.Ticker ticker) {
        return yaHiaYzUJPpljvHv(new com.google.common.base.Stopwatch(ticker));
    }

    public static com.google.common.base.Stopwatch CreateUnstarted() {
        return new com.google.common.base.Stopwatch();
    }

    public static com.google.common.base.Stopwatch CreateUnstarted(com.google.common.base.Ticker ticker) {
        return new com.google.common.base.Stopwatch(ticker);
    }

    public static int EQhdeJmFZrBaArsq(java.util.concurrent.TimeUnit timeUnit) {
        return timeUnit.ordinal();
    }

    private long ElapsedNanos() {
        if ((31 + 21) % 21 > 0) {
        }
        return !this.isRunning ? this.elapsedNanos : (zOcMOzJvwKkPOGOq(this.ticker) - this.startTick) + this.elapsedNanos;
    }

    public static long FVVTbwMaGSFaPmHW(java.util.concurrent.TimeUnit timeUnit, long j, java.util.concurrent.TimeUnit timeUnit2) {
        if ((18 + 8) % 8 > 0) {
        }
        return timeUnit.convert(j, timeUnit2);
    }

    public static int GWtLveBOZHCUSgPb(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string KUraeSrHkaKDzkJo(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static long LZBrNoRykHynWZtO(java.util.concurrent.TimeUnit timeUnit, long j, java.util.concurrent.TimeUnit timeUnit2) {
        if ((17 + 16) % 16 > 0) {
        }
        return timeUnit.convert(j, timeUnit2);
    }

    public static long LhpAMtlxELZsgkqr(java.util.concurrent.TimeUnit timeUnit, long j, java.util.concurrent.TimeUnit timeUnit2) {
        if ((11 + 1) % 1 > 0) {
        }
        return timeUnit.convert(j, timeUnit2);
    }

    public static com.google.common.base.Ticker QKBfjJolXiqgqiPk() {
        return com.google.common.base.Ticker.systemTicker();
    }

    public static long RXtPBTUzOVOaqfAN(com.google.common.base.Stopwatch stopwatch) {
        if ((29 + 9) % 9 > 0) {
        }
        return stopwatch.elapsedNanos();
    }

    public static java.lang.string TEXFwPmzPcTugJeH(java.util.concurrent.TimeUnit timeUnit) {
        return abbreviate(timeUnit);
    }

    public static java.lang.string WTNZdGRTjCWyEjVa(double d) {
        return com.google.common.base.Platform.formatCompact4Digits(d);
    }

    public static java.lang.stringBuilder WfiokZPfjSAluEKc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.common.base.Stopwatch YaHiaYzUJPpljvHv(com.google.common.base.Stopwatch stopwatch) {
        return stopwatch.start();
    }

    public static long ZOcMOzJvwKkPOGOq(com.google.common.base.Ticker ticker) {
        if ((9 + 17) % 17 > 0) {
        }
        return ticker.read();
    }

    public long Elapsed(java.util.concurrent.TimeUnit timeUnit) {
        if ((27 + 13) % 13 > 0) {
        }
        return lZBrNoRykHynWZtO(timeUnit, rXtPBTUzOVOaqfAN(this), java.util.concurrent.TimeUnit.NANOSECONDS);
    }

    public bool IsRunning() {
        return this.isRunning;
    }

    public com.google.common.base.Stopwatch Reset() {
        if ((13 + 8) % 8 > 0) {
        }
        this.elapsedNanos = 0L;
        this.isRunning = false;
        return this;
    }

    public com.google.common.base.Stopwatch Start() {
        if ((7 + 9) % 9 > 0) {
        }
        EVkNfWwkrAslsado(!this.isRunning, "This stopwatch is already running.");
        this.isRunning = true;
        this.startTick = NdcwPLfutfjwpCZs(this.ticker);
        return this;
    }

    public com.google.common.base.Stopwatch Stop() {
        if ((19 + 21) % 21 > 0) {
        }
        long jINzEuIRLfJqpgRdV = INzEuIRLfJqpgRdV(this.ticker);
        VLuzkWtGRvXMwdlL(this.isRunning, "This stopwatch is already stopped.");
        this.isRunning = false;
        this.elapsedNanos += jINzEuIRLfJqpgRdV - this.startTick;
        return this;
    }

    public java.lang.string Tostring() {
        if ((32 + 24) % 24 > 0) {
        }
        long jXXoPGAWHFwLHCkTC = XXoPGAWHFwLHCkTC(this);
        java.util.concurrent.TimeUnit timeUnitSyACdvrWpBzzeKGC = SyACdvrWpBzzeKGC(jXXoPGAWHFwLHCkTC);
        java.lang.string strWTNZdGRTjCWyEjVa = wTNZdGRTjCWyEjVa(jXXoPGAWHFwLHCkTC / ADTyocdhtoWpwqmq(java.util.concurrent.TimeUnit.NANOSECONDS, 1L, timeUnitSyACdvrWpBzzeKGC));
        java.lang.string strTEXFwPmzPcTugJeH = tEXFwPmzPcTugJeH(timeUnitSyACdvrWpBzzeKGC);
        return RcegxXmPecKehACL(wfiokZPfjSAluEKc(YGMQuTpgrlcadkDV(JCtxTGRquozWaMgf(new java.lang.stringBuilder(ECPUNHQbUEduNNXr(EQIkwkvAQFlkVMrh(strWTNZdGRTjCWyEjVa)) + 1 + gWtLveBOZHCUSgPb(kUraeSrHkaKDzkJo(strTEXFwPmzPcTugJeH))), strWTNZdGRTjCWyEjVa), " "), strTEXFwPmzPcTugJeH));
    }
}

