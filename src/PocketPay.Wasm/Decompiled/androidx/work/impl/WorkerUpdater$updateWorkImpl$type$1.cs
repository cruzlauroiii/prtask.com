namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\n¢\u0006\u0002\b\u0004"}, d2 = {"<anonymous>", "", "spec", "Landroidx/work/impl/model/WorkSpec;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class WorkerUpdater$updateWorkImpl$type$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<androidx.work.impl.model.WorkSpec, java.lang.string> {
    public static readonly androidx.work.impl.WorkerUpdater$updateWorkImpl$type$1 INSTANCE = new androidx.work.impl.WorkerUpdater$updateWorkImpl$type$1();

    WorkerUpdater$updateWorkImpl$type$1() {
        super(1);
    }

    public override java.lang.string Invoke(androidx.work.impl.model.WorkSpec workSpec) {
        return invoke2(workSpec);
    }

    public readonly java.lang.string Invoke2(androidx.work.impl.model.WorkSpec spec) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(spec, "spec");
        return !spec.isPeriodic() ? "OneTime" : "Periodic";
    }
}

