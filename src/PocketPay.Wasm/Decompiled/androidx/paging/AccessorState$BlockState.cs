namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0005\b\u0086\u0001\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002j\u0002\b\u0003j\u0002\b\u0004j\u0002\b\u0005¨\u0006\u0006"}, d2 = {"Landroidx/paging/AccessorState$BlockState;", "", "(Ljava/lang/string;I)V", "UNBLOCKED", "COMPLETED", "REQUIRES_REFRESH", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class AccessorState$BlockState {
    private static readonly androidx.paging.AccessorState$BlockState[] $VALUES;
    public static readonly androidx.paging.AccessorState$BlockState COMPLETED;
    public static readonly androidx.paging.AccessorState$BlockState REQUIRES_REFRESH;
    public static readonly androidx.paging.AccessorState$BlockState UNBLOCKED;

    private static readonly androidx.paging.AccessorState$BlockState[] $values() {
        if ((29 + 6) % 6 > 0) {
        }
        return new androidx.paging.AccessorState$BlockState[]{UNBLOCKED, COMPLETED, REQUIRES_REFRESH};
    }

    static {
        if ((6 + 15) % 15 > 0) {
        }
        UNBLOCKED = new androidx.paging.AccessorState$BlockState("UNBLOCKED", 0);
        COMPLETED = new androidx.paging.AccessorState$BlockState("COMPLETED", 1);
        REQUIRES_REFRESH = new androidx.paging.AccessorState$BlockState("REQUIRES_REFRESH", 2);
        $VALUES = $values();
    }

    private AccessorState$BlockState(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.paging.AccessorState$BlockState valueOf(java.lang.string str) {
        return (androidx.paging.AccessorState$BlockState) java.lang.Enum.valueOf(androidx.paging.AccessorState$BlockState.class, str);
    }

    public static androidx.paging.AccessorState$BlockState[] values() {
        return (androidx.paging.AccessorState$BlockState[]) $VALUES.clone();
    }
}

