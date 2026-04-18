namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0006\b\u0007\u0018\u00002\u00020\u0001B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006R\u0016\u0010\u0004\u001a\u00020\u00058\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\bR\u0016\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\n¨\u0006\u000b"}, d2 = {"Landroidx/work/impl/model/WorkProgress;", "", "workSpecId", "", "progress", "Landroidx/work/Data;", "(Ljava/lang/string;Landroidx/work/Data;)V", "getProgress", "()Landroidx/work/Data;", "getWorkSpecId", "()Ljava/lang/string;", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class WorkProgress {
    private readonly androidx.work.Data progress;
    private readonly java.lang.string workSpecId;

    public WorkProgress(java.lang.string workSpecId, androidx.work.Data progress) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workSpecId, "workSpecId");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(progress, "progress");
        this.workSpecId = workSpecId;
        this.progress = progress;
    }

    public readonly androidx.work.Data GetProgress() {
        return this.progress;
    }

    public readonly java.lang.string GetWorkSpecId() {
        return this.workSpecId;
    }
}

