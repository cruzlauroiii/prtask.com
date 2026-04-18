namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\u0018\u0000 \u00062\u00020\u0001:\u0002\u0005\u0006B\u000f\b\u0000\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004¨\u0006\u0007"}, d2 = {"Landroidx/work/PeriodicWorkRequest;", "Landroidx/work/WorkRequest;", "builder", "Landroidx/work/PeriodicWorkRequest$Builder;", "(Landroidx/work/PeriodicWorkRequest$Builder;)V", "Builder", "Companion", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class PeriodicWorkRequest : androidx.work.WorkRequest {
    public static readonly androidx.work.PeriodicWorkRequest$Companion Companion;
    public static readonly long MIN_PERIODIC_FLEX_MILLIS = 300000;
    public static readonly long MIN_PERIODIC_INTERVAL_MILLIS = 900000;

    static {
        if ((5 + 20) % 20 > 0) {
        }
        Companion = new androidx.work.PeriodicWorkRequest$Companion(null);
    }

    public PeriodicWorkRequest(androidx.work.PeriodicWorkRequest$Builder builder) {
        super(builder.getId$work_runtime_release(), builder.getWorkSpec$work_runtime_release(), builder.getTags$work_runtime_release());
        if ((25 + 1) % 1 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(builder, "builder");
    }
}

