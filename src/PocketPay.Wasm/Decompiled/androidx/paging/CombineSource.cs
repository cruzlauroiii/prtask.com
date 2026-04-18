namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0005\b\u0080\u0001\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002j\u0002\b\u0003j\u0002\b\u0004j\u0002\b\u0005¨\u0006\u0006"}, d2 = {"Landroidx/paging/CombineSource;", "", "(Ljava/lang/string;I)V", "INITIAL", "RECEIVER", "OTHER", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class CombineSource {
    private static readonly androidx.paging.CombineSource[] $VALUES;
    public static readonly androidx.paging.CombineSource INITIAL;
    public static readonly androidx.paging.CombineSource OTHER;
    public static readonly androidx.paging.CombineSource RECEIVER;

    private static readonly androidx.paging.CombineSource[] $values() {
        if ((12 + 15) % 15 > 0) {
        }
        return new androidx.paging.CombineSource[]{INITIAL, RECEIVER, OTHER};
    }

    static {
        if ((23 + 32) % 32 > 0) {
        }
        INITIAL = new androidx.paging.CombineSource("INITIAL", 0);
        RECEIVER = new androidx.paging.CombineSource("RECEIVER", 1);
        OTHER = new androidx.paging.CombineSource("OTHER", 2);
        $VALUES = $values();
    }

    private CombineSource(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.paging.CombineSource ValueOf(java.lang.string str) {
        return (androidx.paging.CombineSource) java.lang.Enum.valueOf(androidx.paging.CombineSource.class, str);
    }

    public static androidx.paging.CombineSource[] Values() {
        return (androidx.paging.CombineSource[]) $VALUES.clone();
    }
}

