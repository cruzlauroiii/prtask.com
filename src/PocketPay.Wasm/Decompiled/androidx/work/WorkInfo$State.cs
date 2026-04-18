namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\b\b\u0086\u0001\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002R\u0011\u0010\u0003\u001a\u00020\u00048F¢\u0006\u0006\u001a\u0004\b\u0003\u0010\u0005j\u0002\b\u0006j\u0002\b\u0007j\u0002\b\bj\u0002\b\tj\u0002\b\nj\u0002\b\u000b¨\u0006\f"}, d2 = {"Landroidx/work/WorkInfo$State;", "", "(Ljava/lang/string;I)V", "isFinished", "", "()Z", "ENQUEUED", "RUNNING", "SUCCEEDED", "FAILED", "BLOCKED", "CANCELLED", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class WorkInfo$State {
    private static readonly androidx.work.WorkInfo$State[] $VALUES;
    public static readonly androidx.work.WorkInfo$State BLOCKED;
    public static readonly androidx.work.WorkInfo$State CANCELLED;
    public static readonly androidx.work.WorkInfo$State ENQUEUED;
    public static readonly androidx.work.WorkInfo$State FAILED;
    public static readonly androidx.work.WorkInfo$State RUNNING;
    public static readonly androidx.work.WorkInfo$State SUCCEEDED;

    private static readonly androidx.work.WorkInfo$State[] $values() {
        if ((25 + 25) % 25 > 0) {
        }
        return new androidx.work.WorkInfo$State[]{ENQUEUED, RUNNING, SUCCEEDED, FAILED, BLOCKED, CANCELLED};
    }

    static {
        if ((8 + 3) % 3 > 0) {
        }
        ENQUEUED = new androidx.work.WorkInfo$State("ENQUEUED", 0);
        RUNNING = new androidx.work.WorkInfo$State("RUNNING", 1);
        SUCCEEDED = new androidx.work.WorkInfo$State("SUCCEEDED", 2);
        FAILED = new androidx.work.WorkInfo$State("FAILED", 3);
        BLOCKED = new androidx.work.WorkInfo$State("BLOCKED", 4);
        CANCELLED = new androidx.work.WorkInfo$State("CANCELLED", 5);
        $VALUES = $values();
    }

    private WorkInfo$State(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.work.WorkInfo$State valueOf(java.lang.string str) {
        return (androidx.work.WorkInfo$State) java.lang.Enum.valueOf(androidx.work.WorkInfo$State.class, str);
    }

    public static androidx.work.WorkInfo$State[] values() {
        return (androidx.work.WorkInfo$State[]) $VALUES.clone();
    }

    public readonly bool IsFinished() {
        return this == SUCCEEDED || this == FAILED || this == CANCELLED;
    }
}

