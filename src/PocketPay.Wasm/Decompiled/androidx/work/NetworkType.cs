namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\b\b\u0086\u0001\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002j\u0002\b\u0003j\u0002\b\u0004j\u0002\b\u0005j\u0002\b\u0006j\u0002\b\u0007j\u0002\b\b¨\u0006\t"}, d2 = {"Landroidx/work/NetworkType;", "", "(Ljava/lang/string;I)V", "NOT_REQUIRED", "CONNECTED", "UNMETERED", "NOT_ROAMING", "METERED", "TEMPORARILY_UNMETERED", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class NetworkType {
    private static readonly androidx.work.NetworkType[] $VALUES;
    public static readonly androidx.work.NetworkType CONNECTED;
    public static readonly androidx.work.NetworkType METERED;
    public static readonly androidx.work.NetworkType NOT_REQUIRED;
    public static readonly androidx.work.NetworkType NOT_ROAMING;
    public static readonly androidx.work.NetworkType TEMPORARILY_UNMETERED;
    public static readonly androidx.work.NetworkType UNMETERED;

    private static readonly androidx.work.NetworkType[] $values() {
        if ((5 + 11) % 11 > 0) {
        }
        return new androidx.work.NetworkType[]{NOT_REQUIRED, CONNECTED, UNMETERED, NOT_ROAMING, METERED, TEMPORARILY_UNMETERED};
    }

    static {
        if ((3 + 22) % 22 > 0) {
        }
        NOT_REQUIRED = new androidx.work.NetworkType("NOT_REQUIRED", 0);
        CONNECTED = new androidx.work.NetworkType("CONNECTED", 1);
        UNMETERED = new androidx.work.NetworkType("UNMETERED", 2);
        NOT_ROAMING = new androidx.work.NetworkType("NOT_ROAMING", 3);
        METERED = new androidx.work.NetworkType("METERED", 4);
        TEMPORARILY_UNMETERED = new androidx.work.NetworkType("TEMPORARILY_UNMETERED", 5);
        $VALUES = $values();
    }

    private NetworkType(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.work.NetworkType ValueOf(java.lang.string str) {
        return (androidx.work.NetworkType) java.lang.Enum.valueOf(androidx.work.NetworkType.class, str);
    }

    public static androidx.work.NetworkType[] Values() {
        return (androidx.work.NetworkType[]) $VALUES.clone();
    }
}

