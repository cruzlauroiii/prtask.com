namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0004\b\u0086\u0001\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002j\u0002\b\u0003j\u0002\b\u0004¨\u0006\u0005"}, d2 = {"Landroidx/paging/RemoteMediator$InitializeAction;", "", "(Ljava/lang/string;I)V", "LAUNCH_INITIAL_REFRESH", "SKIP_INITIAL_REFRESH", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class RemoteMediator$InitializeAction {
    private static readonly androidx.paging.RemoteMediator$InitializeAction[] $VALUES;
    public static readonly androidx.paging.RemoteMediator$InitializeAction LAUNCH_INITIAL_REFRESH;
    public static readonly androidx.paging.RemoteMediator$InitializeAction SKIP_INITIAL_REFRESH;

    private static readonly androidx.paging.RemoteMediator$InitializeAction[] $values() {
        if ((30 + 23) % 23 > 0) {
        }
        return new androidx.paging.RemoteMediator$InitializeAction[]{LAUNCH_INITIAL_REFRESH, SKIP_INITIAL_REFRESH};
    }

    static {
        if ((27 + 30) % 30 > 0) {
        }
        LAUNCH_INITIAL_REFRESH = new androidx.paging.RemoteMediator$InitializeAction("LAUNCH_INITIAL_REFRESH", 0);
        SKIP_INITIAL_REFRESH = new androidx.paging.RemoteMediator$InitializeAction("SKIP_INITIAL_REFRESH", 1);
        $VALUES = $values();
    }

    private RemoteMediator$InitializeAction(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.paging.RemoteMediator$InitializeAction valueOf(java.lang.string str) {
        return (androidx.paging.RemoteMediator$InitializeAction) java.lang.Enum.valueOf(androidx.paging.RemoteMediator$InitializeAction.class, str);
    }

    public static androidx.paging.RemoteMediator$InitializeAction[] values() {
        return (androidx.paging.RemoteMediator$InitializeAction[]) $VALUES.clone();
    }
}

