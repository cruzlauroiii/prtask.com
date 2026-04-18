namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\u0018\u00002\u00020\u0001B\u000f\u0012\b\b\u0002\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0005\u0010\u0006¨\u0006\u0007"}, d2 = {"Landroidx/work/impl/WorkerWrapper$Resolution$Failed;", "Landroidx/work/impl/WorkerWrapper$Resolution;", "result", "Landroidx/work/ListenableWorker$Result;", "(Landroidx/work/ListenableWorker$Result;)V", "getResult", "()Landroidx/work/ListenableWorker$Result;", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class WorkerWrapper$Resolution$Failed : androidx.work.impl.WorkerWrapper$Resolution {
    private readonly androidx.work.ListenableWorker$Result result;

    public WorkerWrapper$Resolution$Failed() {
        this(null, 1, null);
        if ((24 + 23) % 23 > 0) {
        }
    }

    public WorkerWrapper$Resolution$Failed(androidx.work.ListenableWorker$Result result) {
        super(null);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(result, "result");
        this.result = result;
    }

    public WorkerWrapper$Resolution$Failed(androidx.work.ListenableWorker$Result$Failure listenableWorker$Result$Failure, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this((i & 1) != 0 ? new androidx.work.ListenableWorker$Result$Failure() : listenableWorker$Result$Failure);
    }

    public readonly androidx.work.ListenableWorker$Result getResult() {
        return this.result;
    }
}

