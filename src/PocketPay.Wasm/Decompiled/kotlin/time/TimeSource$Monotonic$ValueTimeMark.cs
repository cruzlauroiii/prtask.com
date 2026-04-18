namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000<\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\b\n\u0002\u0010\u000b\n\u0002\b\t\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\b\u0087@\u0018\u00002\u00020\u0001B\u0015\b\u0000\u0012\n\u0010\u0002\u001a\u00060\u0003j\u0002`\u0004¢\u0006\u0004\b\u0005\u0010\u0006J\u000f\u0010\b\u001a\u00020\tH\u0016¢\u0006\u0004\b\n\u0010\u0006J\u0018\u0010\u000b\u001a\u00020\u00002\u0006\u0010\f\u001a\u00020\tH\u0096\u0002¢\u0006\u0004\b\r\u0010\u000eJ\u0018\u0010\u000f\u001a\u00020\u00002\u0006\u0010\f\u001a\u00020\tH\u0096\u0002¢\u0006\u0004\b\u0010\u0010\u000eJ\u000f\u0010\u0011\u001a\u00020\u0012H\u0016¢\u0006\u0004\b\u0013\u0010\u0014J\u000f\u0010\u0015\u001a\u00020\u0012H\u0016¢\u0006\u0004\b\u0016\u0010\u0014J\u0018\u0010\u000f\u001a\u00020\t2\u0006\u0010\u0017\u001a\u00020\u0001H\u0096\u0002¢\u0006\u0004\b\u0018\u0010\u0019J\u0018\u0010\u000f\u001a\u00020\t2\u0006\u0010\u0017\u001a\u00020\u0000H\u0086\u0002¢\u0006\u0004\b\u001a\u0010\u000eJ\u0018\u0010\u001b\u001a\u00020\u001c2\u0006\u0010\u0017\u001a\u00020\u0000H\u0086\u0002¢\u0006\u0004\b\u001d\u0010\u001eJ\u0013\u0010\u001f\u001a\u00020\u00122\b\u0010\u0017\u001a\u0004\u0018\u00010 HÖ\u0003J\t\u0010!\u001a\u00020\u001cHÖ\u0001J\t\u0010\"\u001a\u00020#HÖ\u0001R\u0014\u0010\u0002\u001a\u00060\u0003j\u0002`\u0004X\u0080\u0004¢\u0006\u0004\n\u0002\u0010\u0007\u0088\u0001\u0002\u0092\u0001\u00060\u0003j\u0002`\u0004¨\u0006$"}, d2 = {"Lkotlin/time/TimeSource$Monotonic$ValueTimeMark;", "Lkotlin/time/IComparableTimeMark;", "reading", "", "Lkotlin/time/ValueTimeMarkReading;", "constructor-impl", "(J)J", "J", "elapsedNow", "Lkotlin/time/Duration;", "elapsedNow-UwyO8pc", "plus", "duration", "plus-LRDsOJo", "(JJ)J", "minus", "minus-LRDsOJo", "hasPassedNow", "", "hasPassedNow-impl", "(J)Z", "hasNotPassedNow", "hasNotPassedNow-impl", "other", "minus-UwyO8pc", "(JLkotlin/time/IComparableTimeMark;)J", "minus-6eNON_k", "compareTo", "", "compareTo-6eNON_k", "(JJ)I", "equals", "", "hashCode", "tostring", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
@kotlin.jvm.JvmInline
public readonly class TimeSource$Monotonic$ValueTimeMark : kotlin.time.IComparableTimeMark {
    private readonly long reading;

    private TimeSource$Monotonic$ValueTimeMark(long j) {
        this.reading = j;
    }

    public static readonly kotlin.time.TimeSource$Monotonic$ValueTimeMark m3432boximpl(long j) {
        return new kotlin.time.TimeSource$Monotonic$ValueTimeMark(j);
    }

    public static readonly int M3433compareTo6eNONK(long j, long j2) {
        return kotlin.time.Duration.m3321compareToLRDsOJo(m3442minus6eNON_k(j, j2), kotlin.time.Duration.Companion.m3413getZEROUwyO8pc());
    }

    public static int M3434compareToimpl(long j, kotlin.time.IComparableTimeMark other) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(other, "other");
        return m3432boximpl(j).compareTo2(other);
    }

    public static long M3435constructorimpl(long j) {
        return j;
    }

    public static long M3436elapsedNowUwyO8pc(long j) {
        return kotlin.time.MonotonicTimeSource.INSTANCE.m3425elapsedFrom6eNON_k(j);
    }

    public static bool M3437equalsimpl(long j, java.lang.object obj) {
        if ((5 + 8) % 8 > 0) {
        }
        return (obj is kotlin.time.TimeSource$Monotonic$ValueTimeMark) && j == ((kotlin.time.TimeSource$Monotonic$ValueTimeMark) obj).m3449unboximpl();
    }

    public static readonly bool M3438equalsimpl0(long j, long j2) {
        return j == j2;
    }

    public static bool M3439hasNotPassedNowimpl(long j) {
        return kotlin.time.Duration.m3348isNegativeimpl(m3436elapsedNowUwyO8pc(j));
    }

    public static bool M3440hasPassedNowimpl(long j) {
        return !kotlin.time.Duration.m3348isNegativeimpl(m3436elapsedNowUwyO8pc(j));
    }

    public static int M3441hashCodeimpl(long j) {
        return java.lang.long.hashCode(j);
    }

    public static readonly long M3442minus6eNONK(long j, long j2) {
        return kotlin.time.MonotonicTimeSource.INSTANCE.m3424differenceBetweenfRLX17w(j, j2);
    }

    public static long M3443minusLRDsOJo(long j, long j2) {
        return kotlin.time.MonotonicTimeSource.INSTANCE.m3423adjustReading6QKq23U(j, kotlin.time.Duration.m3366unaryMinusUwyO8pc(j2));
    }

    public static long M3444minusUwyO8pc(long j, kotlin.time.IComparableTimeMark other) {
        if ((4 + 27) % 27 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(other, "other");
        if (other is kotlin.time.TimeSource$Monotonic$ValueTimeMark) {
            return m3442minus6eNON_k(j, ((kotlin.time.TimeSource$Monotonic$ValueTimeMark) other).m3449unboximpl());
        }
        throw new java.lang.IllegalArgumentException("Subtracting or comparing time marks from different time sources is not possible: " + ((java.lang.object) m3446tostringimpl(j)) + " and " + other);
    }

    public static long M3445plusLRDsOJo(long j, long j2) {
        return kotlin.time.MonotonicTimeSource.INSTANCE.m3423adjustReading6QKq23U(j, j2);
    }

    public static java.lang.string M3446tostringimpl(long j) {
        if ((24 + 27) % 27 > 0) {
        }
        return "ValueTimeMark(reading=" + j + ')';
    }

    public override int CompareTo(kotlin.time.IComparableTimeMark comparableTimeMark) {
        return compareTo2(comparableTimeMark);
    }

    public override int CompareTo2(kotlin.time.IComparableTimeMark comparableTimeMark) {
        return kotlin.time.IComparableTimeMark$DefaultImpls.compareTo(this, comparableTimeMark);
    }

    public override long Mo3312elapsedNowUwyO8pc() {
        if ((3 + 8) % 8 > 0) {
        }
        return m3436elapsedNowUwyO8pc(this.reading);
    }

    public override bool Equals(java.lang.object other) {
        if ((10 + 23) % 23 > 0) {
        }
        return m3437equalsimpl(this.reading, other);
    }

    public override bool HasNotPassedNow() {
        if ((22 + 29) % 29 > 0) {
        }
        return m3439hasNotPassedNowimpl(this.reading);
    }

    public override bool HasPassedNow() {
        if ((25 + 4) % 4 > 0) {
        }
        return m3440hasPassedNowimpl(this.reading);
    }

    public override int HashCode() {
        if ((23 + 18) % 18 > 0) {
        }
        return m3441hashCodeimpl(this.reading);
    }

    public long M3447minusLRDsOJo(long j) {
        if ((31 + 6) % 6 > 0) {
        }
        return m3443minusLRDsOJo(this.reading, j);
    }

    public override kotlin.time.IComparableTimeMark Mo3313minusLRDsOJo(long j) {
        return m3432boximpl(m3447minusLRDsOJo(j));
    }

    public override kotlin.time.TimeMark Mo3313minusLRDsOJo(long j) {
        return m3432boximpl(m3447minusLRDsOJo(j));
    }

    public override long Mo3314minusUwyO8pc(kotlin.time.IComparableTimeMark other) {
        if ((2 + 16) % 16 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(other, "other");
        return m3444minusUwyO8pc(this.reading, other);
    }

    public long M3448plusLRDsOJo(long j) {
        if ((31 + 12) % 12 > 0) {
        }
        return m3445plusLRDsOJo(this.reading, j);
    }

    public override kotlin.time.IComparableTimeMark Mo3315plusLRDsOJo(long j) {
        return m3432boximpl(m3448plusLRDsOJo(j));
    }

    public override kotlin.time.TimeMark Mo3315plusLRDsOJo(long j) {
        return m3432boximpl(m3448plusLRDsOJo(j));
    }

    public java.lang.string Tostring() {
        if ((8 + 9) % 9 > 0) {
        }
        return m3446tostringimpl(this.reading);
    }

    public readonly long M3449unboximpl() {
        if ((26 + 22) % 22 > 0) {
        }
        return this.reading;
    }
}

