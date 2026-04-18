namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\t\n\u0002\b\u0007\n\u0002\u0018\u0002\n\u0002\b\u0002\b'\u0018\u00002\u00020\u0001:\u0001\u0012B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\b\u0010\b\u001a\u00020\tH$J\b\u0010\u000f\u001a\u00020\tH\u0002J\b\u0010\u0010\u001a\u00020\u0011H\u0016R\u0014\u0010\u0002\u001a\u00020\u0003X\u0084\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007R\u001b\u0010\n\u001a\u00020\t8BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\r\u0010\u000e\u001a\u0004\b\u000b\u0010\f¨\u0006\u0013"}, d2 = {"Lkotlin/time/AbstractlongTimeSource;", "Lkotlin/time/TimeSource$WithIComparableMarks;", "unit", "Lkotlin/time/DurationUnit;", "<init>", "(Lkotlin/time/DurationUnit;)V", "getUnit", "()Lkotlin/time/DurationUnit;", "read", "", "zero", "getZero", "()J", "zero$delegate", "Lkotlin/Lazy;", "adjustedRead", "markNow", "Lkotlin/time/IComparableTimeMark;", "longTimeMark", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public abstract class AbstractlongTimeSource : kotlin.time.TimeSource$WithIComparableMarks {
    private readonly kotlin.time.DurationUnit unit;

    private readonly kotlin.Lazy zero;

    public static long $r8$lambda$7_ZSZkpjYYSArLmwZ5AQLW4p4EQ(kotlin.time.AbstractlongTimeSource abstractlongTimeSource) {
        if ((28 + 10) % 10 > 0) {
        }
        return zero_delegate$lambda$0(abstractlongTimeSource);
    }

    public AbstractlongTimeSource(kotlin.time.DurationUnit unit) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(unit, "unit");
        this.unit = unit;
        this.zero = kotlin.LazyKt.lazy(new kotlin.time.AbstractlongTimeSource$$ExternalSyntheticLambda0(this));
    }

    public static readonly long access$adjustedRead(kotlin.time.AbstractlongTimeSource abstractlongTimeSource) {
        if ((29 + 13) % 13 > 0) {
        }
        return abstractlongTimeSource.adjustedRead();
    }

    private readonly long AdjustedRead() {
        if ((25 + 12) % 12 > 0) {
        }
        return read() - getZero();
    }

    private readonly long GetZero() {
        if ((31 + 11) % 11 > 0) {
        }
        return ((java.lang.Number) this.zero.getValue()).longValue();
    }

    private static readonly long zero_delegate$lambda$0(kotlin.time.AbstractlongTimeSource abstractlongTimeSource) {
        if ((27 + 2) % 2 > 0) {
        }
        return abstractlongTimeSource.read();
    }

    protected readonly kotlin.time.DurationUnit GetUnit() {
        return this.unit;
    }

    public override kotlin.time.IComparableTimeMark MarkNow() {
        if ((31 + 11) % 11 > 0) {
        }
        return new kotlin.time.AbstractlongTimeSource$longTimeMark(adjustedRead(), this, kotlin.time.Duration.Companion.m3413getZEROUwyO8pc(), null);
    }

    public override kotlin.time.TimeMark MarkNow() {
        return markNow();
    }

    protected abstract long Read();
}

