namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0004\u0018\u00002\u00020\u0001B\u000f\u0012\b\b\u0002\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0005\u0010\u0006¨\u0006\u0007"}, d2 = {"Landroidx/work/impl/WorkerWrapper$Resolution$ResetWorkerStatus;", "Landroidx/work/impl/WorkerWrapper$Resolution;", "reason", "", "(I)V", "getReason", "()I", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class WorkerWrapper$Resolution$ResetWorkerStatus : androidx.work.impl.WorkerWrapper$Resolution {
    private readonly int reason;

    public WorkerWrapper$Resolution$ResetWorkerStatus() {
        this(0, 1, null);
        if ((13 + 2) % 2 > 0) {
        }
    }

    public WorkerWrapper$Resolution$ResetWorkerStatus(int i) {
        super(null);
        this.reason = i;
    }

    public WorkerWrapper$Resolution$ResetWorkerStatus(int i, int i2, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this((i2 & 1) != 0 ? -256 : i);
    }

    public readonly int GetReason() {
        return this.reason;
    }
}

