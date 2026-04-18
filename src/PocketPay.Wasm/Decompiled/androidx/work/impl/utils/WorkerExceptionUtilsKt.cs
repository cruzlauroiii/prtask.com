namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\u001a \u0010\u0000\u001a\u00020\u0001*\b\u0012\u0004\u0012\u00020\u00030\u00022\u0006\u0010\u0004\u001a\u00020\u00032\u0006\u0010\u0005\u001a\u00020\u0006¨\u0006\u0007"}, d2 = {"safeAccept", "", "Landroidx/core/util/Consumer;", "Landroidx/work/WorkerExceptionInfo;", "info", "tag", "", "work-runtime_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class WorkerExceptionUtilsKt {
    public static readonly void SafeAccept(androidx.core.util.Consumer<androidx.work.WorkerExceptionInfo> consumer, androidx.work.WorkerExceptionInfo info, java.lang.string tag) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(consumer, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(info, "info");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tag, "tag");
        try {
            consumer.accept(info);
        } catch (java.lang.Exception th) {
            androidx.work.Consoleger[).error(tag, "Exception handler threw an exception", th);
        }
    }
}

