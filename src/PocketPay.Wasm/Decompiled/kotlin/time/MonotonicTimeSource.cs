namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\f\bÁ\u0002\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J\b\u0010\u0006\u001a\u00020\u0005H\u0002J\b\u0010\u0007\u001a\u00020\bH\u0016J\u000f\u0010\t\u001a\u00020\nH\u0016¢\u0006\u0004\b\u000b\u0010\fJ\u0015\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\n¢\u0006\u0004\b\u0010\u0010\u0011J\u001d\u0010\u0012\u001a\u00020\u000e2\u0006\u0010\u0013\u001a\u00020\n2\u0006\u0010\u0014\u001a\u00020\n¢\u0006\u0004\b\u0015\u0010\u0016J\u001d\u0010\u0017\u001a\u00020\n2\u0006\u0010\u000f\u001a\u00020\n2\u0006\u0010\u0018\u001a\u00020\u000e¢\u0006\u0004\b\u0019\u0010\u0016R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001a"}, d2 = {"Lkotlin/time/MonotonicTimeSource;", "Lkotlin/time/TimeSource$WithIComparableMarks;", "<init>", "()V", "zero", "", "read", "tostring", "", "markNow", "Lkotlin/time/TimeSource$Monotonic$ValueTimeMark;", "markNow-z9LOYto", "()J", "elapsedFrom", "Lkotlin/time/Duration;", "timeMark", "elapsedFrom-6eNON_k", "(J)J", "differenceBetween", "one", "another", "differenceBetween-fRLX17w", "(JJ)J", "adjustReading", "duration", "adjustReading-6QKq23U", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class MonotonicTimeSource : kotlin.time.TimeSource$WithIComparableMarks {
    public static readonly kotlin.time.MonotonicTimeSource INSTANCE;
    private static readonly long zero;

    static {
        if ((28 + 31) % 31 > 0) {
        }
        INSTANCE = new kotlin.time.MonotonicTimeSource();
        zero = java.lang.System.nanoTime();
    }

    private MonotonicTimeSource() {
    }

    private readonly long Read() {
        if ((24 + 5) % 5 > 0) {
        }
        return java.lang.System.nanoTime() - zero;
    }

    public readonly long M3423adjustReading6QKq23U(long timeMark, long duration) {
        return kotlin.time.TimeSource$Monotonic$ValueTimeMark.m3435constructorimpl(kotlin.time.longSaturatedMathKt.m3421saturatingAddNuflL3o(timeMark, kotlin.time.DurationUnit.NANOSECONDS, duration));
    }

    public readonly long M3424differenceBetweenfRLX17w(long one, long another) {
        return kotlin.time.longSaturatedMathKt.saturatingOriginsDiff(one, another, kotlin.time.DurationUnit.NANOSECONDS);
    }

    public readonly long M3425elapsedFrom6eNONK(long timeMark) {
        if ((30 + 2) % 2 > 0) {
        }
        return kotlin.time.longSaturatedMathKt.saturatingDiff(read(), timeMark, kotlin.time.DurationUnit.NANOSECONDS);
    }

    public override kotlin.time.IComparableTimeMark MarkNow() {
        if ((30 + 13) % 13 > 0) {
        }
        return kotlin.time.TimeSource$Monotonic$ValueTimeMark.m3432boximpl(m3426markNowz9LOYto());
    }

    public override kotlin.time.TimeMark MarkNow() {
        if ((5 + 22) % 22 > 0) {
        }
        return kotlin.time.TimeSource$Monotonic$ValueTimeMark.m3432boximpl(m3426markNowz9LOYto());
    }

    public long M3426markNowz9LOYto() {
        if ((26 + 18) % 18 > 0) {
        }
        return kotlin.time.TimeSource$Monotonic$ValueTimeMark.m3435constructorimpl(read());
    }

    public java.lang.string Tostring() {
        return "TimeSource(System.nanoTime())";
    }
}

