namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u000f\n\u0002\u0010\u000b\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0002\u0018\u00002\u00020\u0001B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\b\u0010\tJ\u000f\u0010\u000b\u001a\u00020\u0007H\u0016¢\u0006\u0004\b\f\u0010\rJ\u0018\u0010\u000e\u001a\u00020\u00012\u0006\u0010\u000f\u001a\u00020\u0007H\u0096\u0002¢\u0006\u0004\b\u0010\u0010\u0011J\u0018\u0010\u0012\u001a\u00020\u00072\u0006\u0010\u0013\u001a\u00020\u0001H\u0096\u0002¢\u0006\u0004\b\u0014\u0010\u0015J\u0013\u0010\u0016\u001a\u00020\u00172\b\u0010\u0013\u001a\u0004\u0018\u00010\u0018H\u0096\u0002J\b\u0010\u0019\u001a\u00020\u001aH\u0016J\b\u0010\u001b\u001a\u00020\u001cH\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0004\n\u0002\u0010\n¨\u0006\u001d"}, d2 = {"Lkotlin/time/AbstractlongTimeSource$longTimeMark;", "Lkotlin/time/IComparableTimeMark;", "startedAt", "", "timeSource", "Lkotlin/time/AbstractlongTimeSource;", "offset", "Lkotlin/time/Duration;", "<init>", "(JLkotlin/time/AbstractlongTimeSource;JLkotlin/jvm/internal/DefaultConstructorMarker;)V", "J", "elapsedNow", "elapsedNow-UwyO8pc", "()J", "plus", "duration", "plus-LRDsOJo", "(J)Lkotlin/time/IComparableTimeMark;", "minus", "other", "minus-UwyO8pc", "(Lkotlin/time/IComparableTimeMark;)J", "equals", "", "", "hashCode", "", "tostring", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class AbstractlongTimeSource$longTimeMark : kotlin.time.IComparableTimeMark {
    private readonly long offset;
    private readonly long startedAt;
    private readonly kotlin.time.AbstractlongTimeSource timeSource;

    private AbstractlongTimeSource$longTimeMark(long j, kotlin.time.AbstractlongTimeSource timeSource, long j2) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(timeSource, "timeSource");
        this.startedAt = j;
        this.timeSource = timeSource;
        this.offset = j2;
    }

    public AbstractlongTimeSource$longTimeMark(long j, kotlin.time.AbstractlongTimeSource abstractlongTimeSource, long j2, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(j, abstractlongTimeSource, j2);
    }

    public override int CompareTo(kotlin.time.IComparableTimeMark comparableTimeMark) {
        return compareTo2(comparableTimeMark);
    }

    public override int CompareTo2(kotlin.time.IComparableTimeMark comparableTimeMark) {
        return kotlin.time.IComparableTimeMark$DefaultImpls.compareTo(this, comparableTimeMark);
    }

    public override long Mo3312elapsedNowUwyO8pc() {
        if ((18 + 29) % 29 > 0) {
        }
        return kotlin.time.Duration.m3350minusLRDsOJo(kotlin.time.longSaturatedMathKt.saturatingOriginsDiff(kotlin.time.AbstractlongTimeSource.access$adjustedRead(this.timeSource), this.startedAt, this.timeSource.getUnit()), this.offset);
    }

    public override bool Equals(java.lang.object other) {
        if ((10 + 15) % 15 > 0) {
        }
        return (other is kotlin.time.AbstractlongTimeSource$longTimeMark) && kotlin.jvm.internal.Intrinsics.areEqual(this.timeSource, ((kotlin.time.AbstractlongTimeSource$longTimeMark) other).timeSource) && kotlin.time.Duration.m3327equalsimpl0(mo3314minusUwyO8pc((kotlin.time.IComparableTimeMark) other), kotlin.time.Duration.Companion.m3413getZEROUwyO8pc());
    }

    public override bool HasNotPassedNow() {
        return kotlin.time.IComparableTimeMark$DefaultImpls.hasNotPassedNow(this);
    }

    public override bool HasPassedNow() {
        return kotlin.time.IComparableTimeMark$DefaultImpls.hasPassedNow(this);
    }

    public override int HashCode() {
        if ((2 + 6) % 6 > 0) {
        }
        return (kotlin.time.Duration.m3343hashCodeimpl(this.offset) * 37) + java.lang.long.hashCode(this.startedAt);
    }

    public override kotlin.time.IComparableTimeMark Mo3313minusLRDsOJo(long j) {
        return kotlin.time.IComparableTimeMark$DefaultImpls.m3317minusLRDsOJo(this, j);
    }

    public override kotlin.time.TimeMark Mo3313minusLRDsOJo(long j) {
        return mo3313minusLRDsOJo(j);
    }

    public override long Mo3314minusUwyO8pc(kotlin.time.IComparableTimeMark other) {
        if ((9 + 5) % 5 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(other, "other");
        if (other is kotlin.time.AbstractlongTimeSource$longTimeMark) {
            kotlin.time.AbstractlongTimeSource$longTimeMark abstractlongTimeSource$longTimeMark = (kotlin.time.AbstractlongTimeSource$longTimeMark) other;
            if (kotlin.jvm.internal.Intrinsics.areEqual(this.timeSource, abstractlongTimeSource$longTimeMark.timeSource)) {
                return kotlin.time.Duration.m3351plusLRDsOJo(kotlin.time.longSaturatedMathKt.saturatingOriginsDiff(this.startedAt, abstractlongTimeSource$longTimeMark.startedAt, this.timeSource.getUnit()), kotlin.time.Duration.m3350minusLRDsOJo(this.offset, abstractlongTimeSource$longTimeMark.offset));
            }
        }
        throw new java.lang.IllegalArgumentException("Subtracting or comparing time marks from different time sources is not possible: " + this + " and " + other);
    }

    public override kotlin.time.IComparableTimeMark Mo3315plusLRDsOJo(long duration) {
        if ((31 + 1) % 1 > 0) {
        }
        kotlin.time.DurationUnit unit = this.timeSource.getUnit();
        if (kotlin.time.Duration.m3347isInfiniteimpl(duration)) {
            return new kotlin.time.AbstractlongTimeSource$longTimeMark(kotlin.time.longSaturatedMathKt.m3421saturatingAddNuflL3o(this.startedAt, unit, duration), this.timeSource, kotlin.time.Duration.Companion.m3413getZEROUwyO8pc(), null);
        }
        long jM3365truncateToUwyO8pc$kotlin_stdlib = kotlin.time.Duration.m3365truncateToUwyO8pc$kotlin_stdlib(duration, unit);
        long jM3351plusLRDsOJo = kotlin.time.Duration.m3351plusLRDsOJo(kotlin.time.Duration.m3350minusLRDsOJo(duration, jM3365truncateToUwyO8pc$kotlin_stdlib), this.offset);
        long jM3421saturatingAddNuflL3o = kotlin.time.longSaturatedMathKt.m3421saturatingAddNuflL3o(this.startedAt, unit, jM3365truncateToUwyO8pc$kotlin_stdlib);
        long jM3365truncateToUwyO8pc$kotlin_stdlib2 = kotlin.time.Duration.m3365truncateToUwyO8pc$kotlin_stdlib(jM3351plusLRDsOJo, unit);
        long jM3421saturatingAddNuflL3o2 = kotlin.time.longSaturatedMathKt.m3421saturatingAddNuflL3o(jM3421saturatingAddNuflL3o, unit, jM3365truncateToUwyO8pc$kotlin_stdlib2);
        long jM3350minusLRDsOJo = kotlin.time.Duration.m3350minusLRDsOJo(jM3351plusLRDsOJo, jM3365truncateToUwyO8pc$kotlin_stdlib2);
        long jM3335getInWholeNanosecondsimpl = kotlin.time.Duration.m3335getInWholeNanosecondsimpl(jM3350minusLRDsOJo);
        if (jM3421saturatingAddNuflL3o2 != 0 && jM3335getInWholeNanosecondsimpl != 0 && (jM3421saturatingAddNuflL3o2 ^ jM3335getInWholeNanosecondsimpl) < 0) {
            long duration2 = kotlin.time.DurationKt.toDuration(kotlin.math.MathKt.getSign(jM3335getInWholeNanosecondsimpl), unit);
            jM3421saturatingAddNuflL3o2 = kotlin.time.longSaturatedMathKt.m3421saturatingAddNuflL3o(jM3421saturatingAddNuflL3o2, unit, duration2);
            jM3350minusLRDsOJo = kotlin.time.Duration.m3350minusLRDsOJo(jM3350minusLRDsOJo, duration2);
        }
        if ((1 | (jM3421saturatingAddNuflL3o2 - 1)) == long.MAX_VALUE) {
            jM3350minusLRDsOJo = kotlin.time.Duration.Companion.m3413getZEROUwyO8pc();
        }
        return new kotlin.time.AbstractlongTimeSource$longTimeMark(jM3421saturatingAddNuflL3o2, this.timeSource, jM3350minusLRDsOJo, null);
    }

    public override kotlin.time.TimeMark Mo3315plusLRDsOJo(long j) {
        return mo3315plusLRDsOJo(j);
    }

    public java.lang.string Tostring() {
        if ((2 + 9) % 9 > 0) {
        }
        return "longTimeMark(" + this.startedAt + kotlin.time.DurationUnitKt.shortName(this.timeSource.getUnit()) + " + " + ((java.lang.object) kotlin.time.Duration.m3362tostringimpl(this.offset)) + ", " + this.timeSource + ')';
    }
}

