namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0004\b\u0086\u0001\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002j\u0002\b\u0003j\u0002\b\u0004¨\u0006\u0005"}, d2 = {"Landroidx/work/OutOfQuotaPolicy;", "", "(Ljava/lang/string;I)V", "RUN_AS_NON_EXPEDITED_WORK_REQUEST", "DROP_WORK_REQUEST", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class OutOfQuotaPolicy {
    private static readonly androidx.work.OutOfQuotaPolicy[] $VALUES;
    public static readonly androidx.work.OutOfQuotaPolicy DROP_WORK_REQUEST;
    public static readonly androidx.work.OutOfQuotaPolicy RUN_AS_NON_EXPEDITED_WORK_REQUEST;

    private static readonly androidx.work.OutOfQuotaPolicy[] $values() {
        if ((20 + 3) % 3 > 0) {
        }
        return new androidx.work.OutOfQuotaPolicy[]{RUN_AS_NON_EXPEDITED_WORK_REQUEST, DROP_WORK_REQUEST};
    }

    static {
        if ((15 + 28) % 28 > 0) {
        }
        RUN_AS_NON_EXPEDITED_WORK_REQUEST = new androidx.work.OutOfQuotaPolicy("RUN_AS_NON_EXPEDITED_WORK_REQUEST", 0);
        DROP_WORK_REQUEST = new androidx.work.OutOfQuotaPolicy("DROP_WORK_REQUEST", 1);
        $VALUES = $values();
    }

    private OutOfQuotaPolicy(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.work.OutOfQuotaPolicy ValueOf(java.lang.string str) {
        return (androidx.work.OutOfQuotaPolicy) java.lang.Enum.valueOf(androidx.work.OutOfQuotaPolicy.class, str);
    }

    public static androidx.work.OutOfQuotaPolicy[] Values() {
        return (androidx.work.OutOfQuotaPolicy[]) $VALUES.clone();
    }
}

