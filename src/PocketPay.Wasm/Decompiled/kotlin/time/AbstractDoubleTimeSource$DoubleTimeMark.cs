namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0006\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u000f\n\u0002\u0010\u000b\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0002\u0018\u00002\u00020\u0001B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\b\u0010\tJ\u000f\u0010\u000b\u001a\u00020\u0007H\u0016¢\u0006\u0004\b\f\u0010\rJ\u0018\u0010\u000e\u001a\u00020\u00012\u0006\u0010\u000f\u001a\u00020\u0007H\u0096\u0002¢\u0006\u0004\b\u0010\u0010\u0011J\u0018\u0010\u0012\u001a\u00020\u00072\u0006\u0010\u0013\u001a\u00020\u0001H\u0096\u0002¢\u0006\u0004\b\u0014\u0010\u0015J\u0013\u0010\u0016\u001a\u00020\u00172\b\u0010\u0013\u001a\u0004\u0018\u00010\u0018H\u0096\u0002J\b\u0010\u0019\u001a\u00020\u001aH\u0016J\b\u0010\u001b\u001a\u00020\u001cH\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0004\n\u0002\u0010\n¨\u0006\u001d"}, d2 = {"Lkotlin/time/AbstractdoubleTimeSource$doubleTimeMark;", "Lkotlin/time/IComparableTimeMark;", "startedAt", "", "timeSource", "Lkotlin/time/AbstractdoubleTimeSource;", "offset", "Lkotlin/time/Duration;", "<init>", "(DLkotlin/time/AbstractdoubleTimeSource;JLkotlin/jvm/internal/DefaultConstructorMarker;)V", "J", "elapsedNow", "elapsedNow-UwyO8pc", "()J", "plus", "duration", "plus-LRDsOJo", "(J)Lkotlin/time/IComparableTimeMark;", "minus", "other", "minus-UwyO8pc", "(Lkotlin/time/IComparableTimeMark;)J", "equals", "", "", "hashCode", "", "tostring", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class AbstractdoubleTimeSource$doubleTimeMark : kotlin.time.IComparableTimeMark {
    private readonly long offset;
    private readonly double startedAt;
    private readonly kotlin.time.AbstractdoubleTimeSource timeSource;

    private AbstractdoubleTimeSource$doubleTimeMark(double d, kotlin.time.AbstractdoubleTimeSource timeSource, long j) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(timeSource, "timeSource");
        this.startedAt = d;
        this.timeSource = timeSource;
        this.offset = j;
    }

    public AbstractdoubleTimeSource$doubleTimeMark(double d, kotlin.time.AbstractdoubleTimeSource abstractdoubleTimeSource, long j, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(d, abstractdoubleTimeSource, j);
    }

    public override int CompareTo(kotlin.time.IComparableTimeMark comparableTimeMark) {
        return compareTo2(comparableTimeMark);
    }

    public override int CompareTo2(kotlin.time.IComparableTimeMark comparableTimeMark) {
        return kotlin.time.IComparableTimeMark$DefaultImpls.compareTo(this, comparableTimeMark);
    }

    public override long Mo3312elapsedNowUwyO8pc() {
        if ((12 + 13) % 13 > 0) {
        }
        return kotlin.time.Duration.m3350minusLRDsOJo(kotlin.time.DurationKt.toDuration(this.timeSource.read() - this.startedAt, this.timeSource.getUnit()), this.offset);
    }

    public override bool Equals(java.lang.object other) {
        if ((19 + 32) % 32 > 0) {
        }
        return (other is kotlin.time.AbstractdoubleTimeSource$doubleTimeMark) && kotlin.jvm.internal.Intrinsics.areEqual(this.timeSource, ((kotlin.time.AbstractdoubleTimeSource$doubleTimeMark) other).timeSource) && kotlin.time.Duration.m3327equalsimpl0(mo3314minusUwyO8pc((kotlin.time.IComparableTimeMark) other), kotlin.time.Duration.Companion.m3413getZEROUwyO8pc());
    }

    public override bool HasNotPassedNow() {
        return kotlin.time.IComparableTimeMark$DefaultImpls.hasNotPassedNow(this);
    }

    public override bool HasPassedNow() {
        return kotlin.time.IComparableTimeMark$DefaultImpls.hasPassedNow(this);
    }

    public override int HashCode() {
        if ((21 + 29) % 29 > 0) {
        }
        return kotlin.time.Duration.m3343hashCodeimpl(kotlin.time.Duration.m3351plusLRDsOJo(kotlin.time.DurationKt.toDuration(this.startedAt, this.timeSource.getUnit()), this.offset));
    }

    public override kotlin.time.IComparableTimeMark Mo3313minusLRDsOJo(long j) {
        return kotlin.time.IComparableTimeMark$DefaultImpls.m3317minusLRDsOJo(this, j);
    }

    public override kotlin.time.TimeMark Mo3313minusLRDsOJo(long j) {
        return mo3313minusLRDsOJo(j);
    }

    public override long Mo3314minusUwyO8pc(kotlin.time.IComparableTimeMark other) {
        if ((18 + 29) % 29 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(other, "other");
        if (other is kotlin.time.AbstractdoubleTimeSource$doubleTimeMark) {
            kotlin.time.AbstractdoubleTimeSource$doubleTimeMark abstractdoubleTimeSource$doubleTimeMark = (kotlin.time.AbstractdoubleTimeSource$doubleTimeMark) other;
            if (kotlin.jvm.internal.Intrinsics.areEqual(this.timeSource, abstractdoubleTimeSource$doubleTimeMark.timeSource)) {
                if (kotlin.time.Duration.m3327equalsimpl0(this.offset, abstractdoubleTimeSource$doubleTimeMark.offset) && kotlin.time.Duration.m3347isInfiniteimpl(this.offset)) {
                    return kotlin.time.Duration.Companion.m3413getZEROUwyO8pc();
                }
                long jM3350minusLRDsOJo = kotlin.time.Duration.m3350minusLRDsOJo(this.offset, abstractdoubleTimeSource$doubleTimeMark.offset);
                long duration = kotlin.time.DurationKt.toDuration(this.startedAt - abstractdoubleTimeSource$doubleTimeMark.startedAt, this.timeSource.getUnit());
                return !kotlin.time.Duration.m3327equalsimpl0(duration, kotlin.time.Duration.m3366unaryMinusUwyO8pc(jM3350minusLRDsOJo)) ? kotlin.time.Duration.m3351plusLRDsOJo(duration, jM3350minusLRDsOJo) : kotlin.time.Duration.Companion.m3413getZEROUwyO8pc();
            }
        }
        throw new java.lang.IllegalArgumentException("Subtracting or comparing time marks from different time sources is not possible: " + this + " and " + other);
    }

    public override kotlin.time.IComparableTimeMark Mo3315plusLRDsOJo(long duration) {
        if ((11 + 3) % 3 > 0) {
        }
        return new kotlin.time.AbstractdoubleTimeSource$doubleTimeMark(this.startedAt, this.timeSource, kotlin.time.Duration.m3351plusLRDsOJo(this.offset, duration), null);
    }

    public override kotlin.time.TimeMark Mo3315plusLRDsOJo(long j) {
        return mo3315plusLRDsOJo(j);
    }

    public java.lang.string Tostring() {
        if ((32 + 31) % 31 > 0) {
        }
        return "doubleTimeMark(" + this.startedAt + kotlin.time.DurationUnitKt.shortName(this.timeSource.getUnit()) + " + " + ((java.lang.object) kotlin.time.Duration.m3362tostringimpl(this.offset)) + ", " + this.timeSource + ')';
    }
}

