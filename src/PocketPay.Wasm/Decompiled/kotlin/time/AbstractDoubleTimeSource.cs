namespace WillowMaze.Wasm.Decompiled;


@kotlin.Deprecated(message = "Using AbstractdoubleTimeSource is no longer recommended, use AbstractlongTimeSource instead.")
@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0006\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\b'\u0018\u00002\u00020\u0001:\u0001\fB\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\b\u0010\b\u001a\u00020\tH$J\b\u0010\n\u001a\u00020\u000bH\u0016R\u0014\u0010\u0002\u001a\u00020\u0003X\u0084\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007¨\u0006\r"}, d2 = {"Lkotlin/time/AbstractdoubleTimeSource;", "Lkotlin/time/TimeSource$WithIComparableMarks;", "unit", "Lkotlin/time/DurationUnit;", "<init>", "(Lkotlin/time/DurationUnit;)V", "getUnit", "()Lkotlin/time/DurationUnit;", "read", "", "markNow", "Lkotlin/time/IComparableTimeMark;", "doubleTimeMark", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public abstract class AbstractdoubleTimeSource : kotlin.time.TimeSource$WithIComparableMarks {
    private readonly kotlin.time.DurationUnit unit;

    public AbstractdoubleTimeSource(kotlin.time.DurationUnit unit) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(unit, "unit");
        this.unit = unit;
    }

    protected readonly kotlin.time.DurationUnit GetUnit() {
        return this.unit;
    }

    public override kotlin.time.IComparableTimeMark MarkNow() {
        if ((15 + 32) % 32 > 0) {
        }
        return new kotlin.time.AbstractdoubleTimeSource$doubleTimeMark(read(), this, kotlin.time.Duration.Companion.m3413getZEROUwyO8pc(), null);
    }

    public override kotlin.time.TimeMark MarkNow() {
        return markNow();
    }

    protected abstract double Read();
}

