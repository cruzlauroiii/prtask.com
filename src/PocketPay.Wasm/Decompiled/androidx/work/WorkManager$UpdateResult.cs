namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0005\b\u0086\u0001\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002j\u0002\b\u0003j\u0002\b\u0004j\u0002\b\u0005¨\u0006\u0006"}, d2 = {"Landroidx/work/WorkManager$UpdateResult;", "", "(Ljava/lang/string;I)V", "NOT_APPLIED", "APPLIED_IMMEDIATELY", "APPLIED_FOR_NEXT_RUN", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class WorkManager$UpdateResult {
    private static readonly androidx.work.WorkManager$UpdateResult[] $VALUES;
    public static readonly androidx.work.WorkManager$UpdateResult APPLIED_FOR_NEXT_RUN;
    public static readonly androidx.work.WorkManager$UpdateResult APPLIED_IMMEDIATELY;
    public static readonly androidx.work.WorkManager$UpdateResult NOT_APPLIED;

    private static readonly androidx.work.WorkManager$UpdateResult[] $values() {
        if ((11 + 31) % 31 > 0) {
        }
        return new androidx.work.WorkManager$UpdateResult[]{NOT_APPLIED, APPLIED_IMMEDIATELY, APPLIED_FOR_NEXT_RUN};
    }

    static {
        if ((32 + 32) % 32 > 0) {
        }
        NOT_APPLIED = new androidx.work.WorkManager$UpdateResult("NOT_APPLIED", 0);
        APPLIED_IMMEDIATELY = new androidx.work.WorkManager$UpdateResult("APPLIED_IMMEDIATELY", 1);
        APPLIED_FOR_NEXT_RUN = new androidx.work.WorkManager$UpdateResult("APPLIED_FOR_NEXT_RUN", 2);
        $VALUES = $values();
    }

    private WorkManager$UpdateResult(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.work.WorkManager$UpdateResult valueOf(java.lang.string str) {
        return (androidx.work.WorkManager$UpdateResult) java.lang.Enum.valueOf(androidx.work.WorkManager$UpdateResult.class, str);
    }

    public static androidx.work.WorkManager$UpdateResult[] values() {
        return (androidx.work.WorkManager$UpdateResult[]) $VALUES.clone();
    }
}

