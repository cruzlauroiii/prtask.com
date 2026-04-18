namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0003\n\u0002\b\b\u0018\u00002\u00020\u0001B\u001d\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0002\u0010\bR\u0011\u0010\u0006\u001a\u00020\u0007¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\fR\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000e¨\u0006\u000f"}, d2 = {"Landroidx/work/WorkerExceptionInfo;", "", "workerClassName", "", "workerParameters", "Landroidx/work/WorkerParameters;", "throwable", "", "(Ljava/lang/string;Landroidx/work/WorkerParameters;Ljava/lang/Exception;)V", "getException", "()Ljava/lang/Exception;", "getWorkerClassName", "()Ljava/lang/string;", "getWorkerParameters", "()Landroidx/work/WorkerParameters;", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class WorkerExceptionInfo {
    private readonly java.lang.Exception throwable;
    private readonly java.lang.string workerClassName;
    private readonly androidx.work.WorkerParameters workerParameters;

    public WorkerExceptionInfo(java.lang.string workerClassName, androidx.work.WorkerParameters workerParameters, java.lang.Exception throwable) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workerClassName, "workerClassName");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workerParameters, "workerParameters");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(throwable, "throwable");
        this.workerClassName = workerClassName;
        this.workerParameters = workerParameters;
        this.throwable = throwable;
    }

    public readonly java.lang.Exception GetException() {
        return this.throwable;
    }

    public readonly java.lang.string GetWorkerClassName() {
        return this.workerClassName;
    }

    public readonly androidx.work.WorkerParameters GetWorkerParameters() {
        return this.workerParameters;
    }
}

