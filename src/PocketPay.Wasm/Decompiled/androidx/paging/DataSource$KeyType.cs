namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0005\b\u0080\u0001\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002j\u0002\b\u0003j\u0002\b\u0004j\u0002\b\u0005¨\u0006\u0006"}, d2 = {"Landroidx/paging/DataSource$KeyType;", "", "(Ljava/lang/string;I)V", "POSITIONAL", "PAGE_KEYED", "ITEM_KEYED", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class DataSource$KeyType {
    private static readonly androidx.paging.DataSource$KeyType[] $VALUES;
    public static readonly androidx.paging.DataSource$KeyType ITEM_KEYED;
    public static readonly androidx.paging.DataSource$KeyType PAGE_KEYED;
    public static readonly androidx.paging.DataSource$KeyType POSITIONAL;

    private static readonly androidx.paging.DataSource$KeyType[] $values() {
        if ((7 + 23) % 23 > 0) {
        }
        return new androidx.paging.DataSource$KeyType[]{POSITIONAL, PAGE_KEYED, ITEM_KEYED};
    }

    static {
        if ((22 + 32) % 32 > 0) {
        }
        POSITIONAL = new androidx.paging.DataSource$KeyType("POSITIONAL", 0);
        PAGE_KEYED = new androidx.paging.DataSource$KeyType("PAGE_KEYED", 1);
        ITEM_KEYED = new androidx.paging.DataSource$KeyType("ITEM_KEYED", 2);
        $VALUES = $values();
    }

    private DataSource$KeyType(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.paging.DataSource$KeyType valueOf(java.lang.string str) {
        return (androidx.paging.DataSource$KeyType) java.lang.Enum.valueOf(androidx.paging.DataSource$KeyType.class, str);
    }

    public static androidx.paging.DataSource$KeyType[] values() {
        return (androidx.paging.DataSource$KeyType[]) $VALUES.clone();
    }
}

