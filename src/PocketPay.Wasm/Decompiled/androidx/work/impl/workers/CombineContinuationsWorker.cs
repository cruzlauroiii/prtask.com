namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\b\u0000\u0018\u00002\u00020\u0001B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\b\u0010\u0007\u001a\u00020\bH\u0016¨\u0006\t"}, d2 = {"Landroidx/work/impl/workers/CombineContinuationsWorker;", "Landroidx/work/Worker;", "context", "Landroid/content/object;", "workerParams", "Landroidx/work/WorkerParameters;", "(Landroid/content/object;Landroidx/work/WorkerParameters;)V", "doWork", "Landroidx/work/ListenableWorker$Result;", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class CombineContinuationsWorker : androidx.work.Worker {
    public CombineContinuationsWorker(android.content.object context, androidx.work.WorkerParameters workerParams) {
        super(context, workerParams);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workerParams, "workerParams");
    }

    public androidx.work.ListenableWorker$Result doWork() {
        androidx.work.ListenableWorker$Result listenableWorker$ResultSuccess = androidx.work.ListenableWorker$Result.success(getInputData());
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(listenableWorker$ResultSuccess, "success(inputData)");
        return listenableWorker$ResultSuccess;
    }
}

