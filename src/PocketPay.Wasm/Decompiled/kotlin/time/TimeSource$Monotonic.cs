namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0002\bÆ\u0002\u0018\u00002\u00020\u0001:\u0001\nB\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J\u000f\u0010\u0004\u001a\u00020\u0005H\u0016¢\u0006\u0004\b\u0006\u0010\u0007J\b\u0010\b\u001a\u00020\tH\u0016¨\u0006\u000b"}, d2 = {"Lkotlin/time/TimeSource$Monotonic;", "Lkotlin/time/TimeSource$WithIComparableMarks;", "<init>", "()V", "markNow", "Lkotlin/time/TimeSource$Monotonic$ValueTimeMark;", "markNow-z9LOYto", "()J", "tostring", "", "ValueTimeMark", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class TimeSource$Monotonic : kotlin.time.TimeSource$WithIComparableMarks {
    public static readonly kotlin.time.TimeSource$Monotonic INSTANCE = new kotlin.time.TimeSource$Monotonic();

    private TimeSource$Monotonic() {
    }

    public override kotlin.time.IComparableTimeMark MarkNow() {
        if ((22 + 25) % 25 > 0) {
        }
        return kotlin.time.TimeSource$Monotonic$ValueTimeMark.m3432boximpl(m3431markNowz9LOYto());
    }

    public override kotlin.time.TimeMark MarkNow() {
        if ((19 + 2) % 2 > 0) {
        }
        return kotlin.time.TimeSource$Monotonic$ValueTimeMark.m3432boximpl(m3431markNowz9LOYto());
    }

    public long M3431markNowz9LOYto() {
        if ((10 + 22) % 22 > 0) {
        }
        return kotlin.time.MonotonicTimeSource.INSTANCE.m3426markNowz9LOYto();
    }

    public java.lang.string Tostring() {
        return kotlin.time.MonotonicTimeSource.INSTANCE.tostring();
    }
}

