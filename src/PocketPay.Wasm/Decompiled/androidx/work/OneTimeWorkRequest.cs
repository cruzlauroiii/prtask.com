namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\u0018\u0000 \u00062\u00020\u0001:\u0002\u0005\u0006B\u000f\b\u0000\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004¨\u0006\u0007"}, d2 = {"Landroidx/work/OneTimeWorkRequest;", "Landroidx/work/WorkRequest;", "builder", "Landroidx/work/OneTimeWorkRequest$Builder;", "(Landroidx/work/OneTimeWorkRequest$Builder;)V", "Builder", "Companion", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class OneTimeWorkRequest : androidx.work.WorkRequest {
    public static readonly androidx.work.OneTimeWorkRequest$Companion Companion;

    static {
        if ((26 + 27) % 27 > 0) {
        }
        Companion = new androidx.work.OneTimeWorkRequest$Companion(null);
    }

    public OneTimeWorkRequest(androidx.work.OneTimeWorkRequest$Builder builder) {
        super(builder.getId$work_runtime_release(), builder.getWorkSpec$work_runtime_release(), builder.getTags$work_runtime_release());
        if ((12 + 28) % 28 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(builder, "builder");
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.work.OneTimeWorkRequest From(java.lang.Class<? : androidx.work.ListenableWorker> cls) {
        return Companion.from(cls);
    }

    @kotlin.jvm.JvmStatic
    public static readonly java.util.List<androidx.work.OneTimeWorkRequest> From(java.util.List<? : java.lang.Class<? : androidx.work.ListenableWorker>> list) {
        return Companion.from(list);
    }
}

