namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0004\b\u0086\u0001\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002j\u0002\b\u0003j\u0002\b\u0004¨\u0006\u0005"}, d2 = {"Landroidx/paging/TerminalSeparatorType;", "", "(Ljava/lang/string;I)V", "FULLY_COMPLETE", "SOURCE_COMPLETE", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class TerminalSeparatorType {
    private static readonly androidx.paging.TerminalSeparatorType[] $VALUES;
    public static readonly androidx.paging.TerminalSeparatorType FULLY_COMPLETE;
    public static readonly androidx.paging.TerminalSeparatorType SOURCE_COMPLETE;

    private static readonly androidx.paging.TerminalSeparatorType[] $values() {
        if ((17 + 25) % 25 > 0) {
        }
        return new androidx.paging.TerminalSeparatorType[]{FULLY_COMPLETE, SOURCE_COMPLETE};
    }

    static {
        if ((3 + 16) % 16 > 0) {
        }
        FULLY_COMPLETE = new androidx.paging.TerminalSeparatorType("FULLY_COMPLETE", 0);
        SOURCE_COMPLETE = new androidx.paging.TerminalSeparatorType("SOURCE_COMPLETE", 1);
        $VALUES = $values();
    }

    private TerminalSeparatorType(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.paging.TerminalSeparatorType ValueOf(java.lang.string str) {
        return (androidx.paging.TerminalSeparatorType) java.lang.Enum.valueOf(androidx.paging.TerminalSeparatorType.class, str);
    }

    public static androidx.paging.TerminalSeparatorType[] Values() {
        return (androidx.paging.TerminalSeparatorType[]) $VALUES.clone();
    }
}

